﻿using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Services.Factory.Base;
using Services.Managers.Assets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Factory.Manager
{
    public class TrackAssetManagerFactory : ManagerFactory<TrackAssetManager, TrackAsset>
    {
        public override TrackAssetManager CreateDefault()
        {
            return new TrackAssetManagerLimited();
        }
    }
}
