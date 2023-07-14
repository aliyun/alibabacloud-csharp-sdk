// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ApplyScenarioShrinkRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public string ConfigShrink { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        [NameInMap("Sign")]
        [Validation(Required=false)]
        public string Sign { get; set; }

        [NameInMap("SnDump")]
        [Validation(Required=false)]
        public bool? SnDump { get; set; }

        [NameInMap("SnForce")]
        [Validation(Required=false)]
        public bool? SnForce { get; set; }

        [NameInMap("SnStat")]
        [Validation(Required=false)]
        public bool? SnStat { get; set; }

        [NameInMap("SnTransfer")]
        [Validation(Required=false)]
        public bool? SnTransfer { get; set; }

        [NameInMap("UpdateOption")]
        [Validation(Required=false)]
        public bool? UpdateOption { get; set; }

    }

}
