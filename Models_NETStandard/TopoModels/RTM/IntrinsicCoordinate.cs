﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class IntrinsicCoordinate
    {
        public IntrinsicCoordinate()
        {

        }

        public IntrinsicCoordinate(tElementWithIDref[] cartesianCoordinates, string uuid)
        {
            this.coordinates = cartesianCoordinates;
            this.uuid = uuid;
        }
    }
}