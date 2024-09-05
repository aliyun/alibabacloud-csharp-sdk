// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunScriptPlanningRequest : TeaModel {
        [NameInMap("additionalNote")]
        [Validation(Required=false)]
        public string AdditionalNote { get; set; }

        [NameInMap("dialogueInScene")]
        [Validation(Required=false)]
        public bool? DialogueInScene { get; set; }

        [NameInMap("plotConflict")]
        [Validation(Required=false)]
        public bool? PlotConflict { get; set; }

        [NameInMap("scriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

        [NameInMap("scriptShotCount")]
        [Validation(Required=false)]
        public int? ScriptShotCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("scriptSummary")]
        [Validation(Required=false)]
        public string ScriptSummary { get; set; }

        [NameInMap("scriptTypeKeyword")]
        [Validation(Required=false)]
        public string ScriptTypeKeyword { get; set; }

    }

}
