﻿using Models.Base;
using Models.TopoModels.Eulynx.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx.Common
{
    public abstract partial class BaseObject : IManageable
    {

        public static bool operator ==(BaseObject baseObject1, BaseObject baseObject2)
        {
            if(object.ReferenceEquals(baseObject1, null))
            {
                return object.ReferenceEquals(baseObject2, null);
            }

            return baseObject1.Equals(baseObject2);
        }

        public static bool operator !=(BaseObject baseObject1, BaseObject baseObject2)
        {
            return !(baseObject1 == baseObject2);
        }

        public override bool Equals(Object obj)
        {
            return this.Equals(obj as BaseObject);
        }

        public bool Equals(BaseObject baseObject)
        {
            if (baseObject == null) return false;
            return this.uuid == baseObject.uuid;
        }

        public bool Equals(tElementWithIDref idRef)
        {
            return this.uuid == idRef.@ref;
        }

        public static implicit operator tElementWithIDref(BaseObject bo)
        {
            return new tElementWithIDref(bo.uuid);
        }

        public static implicit operator tElementWithIDref[](BaseObject bo)
        {
            return new tElementWithIDref[] { new tElementWithIDref(bo.uuid) };
        }

        public static implicit operator BaseObject[](BaseObject bo)
        {
            return new BaseObject[] { bo };
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static IEnumerable<T> Find<T>(IEnumerable<T> allElements, tElementWithIDref[] needles) where T : BaseObject
        {
            return Find(allElements.ToArray(), needles);
        }

        public static T Find<T>(IEnumerable<T> allElements, tElementWithIDref needle) where T : BaseObject
        {
            return Find(allElements.ToArray(), needle);
        }

        public static T[] Find<T>(T[] allElements, tElementWithIDref[] needles) where T : BaseObject
        {
            var allElementsList = allElements.ToList();
            var e = needles.Any(idRef => idRef.@ref == "ff442c00-0082-496f-9f41-461ac9cb55ab");

            //allElementsList.Where(element => needles.Any(needle => element.uuid == needle.@ref))

            var filtered = allElements.ToList().Where(element => (needles.Any(idRef => idRef.@ref.Equals(element.uuid))));
            if (filtered == null) return null;

            return filtered.ToArray();
        }

        public static T[] FindWithDuplicates<T>(T[] allElements, tElementWithIDref needle) where T : BaseObject
        {
            if (needle == null || needle.@ref == null) return null;
            var filtered = allElements.ToList().Where(element => needle.@ref.Equals(element.uuid));
            if (filtered == null) return null;
            return filtered.ToArray();
        }

        public static T Find<T>(T[] allElements, tElementWithIDref needle) where T : BaseObject
        {
            if (needle == null || needle.@ref == null) return null;
            var filtered = allElements.ToList().Where(element => needle.@ref.Equals(element.uuid));
            if (filtered == null || filtered.Count() == 0) return null;
            return filtered.First();
        }
    }
}
