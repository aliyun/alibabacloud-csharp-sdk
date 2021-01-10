// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecLinkefabricFabricSchedulerofflinetaskRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("DevTaskEnable")]
        [Validation(Required=false)]
        public bool? DevTaskEnable { get; set; }

        [NameInMap("NetTaskEnable")]
        [Validation(Required=false)]
        public bool? NetTaskEnable { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ShareOpenAPI")]
        [Validation(Required=false)]
        public bool? ShareOpenAPI { get; set; }

        [NameInMap("SitTaskEnable")]
        [Validation(Required=false)]
        public bool? SitTaskEnable { get; set; }

        [NameInMap("SynacCheckedEnvZones")]
        [Validation(Required=false)]
        public string SynacCheckedEnvZones { get; set; }

        [NameInMap("SynacCheckedEnvZoneNames")]
        [Validation(Required=false)]
        public string SynacCheckedEnvZoneNames { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("DevStageListRepeatList")]
        [Validation(Required=false)]
        public List<string> DevStageListRepeatList { get; set; }

        [NameInMap("SchedulerConfigsRepeatList")]
        [Validation(Required=false)]
        public List<string> SchedulerConfigsRepeatList { get; set; }

    }

}
