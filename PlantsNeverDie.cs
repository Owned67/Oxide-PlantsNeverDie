using Oxide.Core;
using Oxide.Core.Libraries.Covalence;
using UnityEngine;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Oxide.Plugins
{
    [Info("Plants Never Die", "ArtiIOMI", "0.0.1")]
    [Description("Plants never die")]
    internal class PlantsNeverDie : RustPlugin
    {
    #region Oxide Hooks
        void OnGrowableStateChange(GrowableEntity entity, PlantProperties.State state){
            if(state != PlantProperties.State.Dying)
                return;
            state = PlantProperties.State.Ripe;
            entity.stageAge = 0.0f;
        }
    #endregion
    }
}