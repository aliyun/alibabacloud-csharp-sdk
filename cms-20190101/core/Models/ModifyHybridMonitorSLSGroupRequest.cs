// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyHybridMonitorSLSGroupRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SLSGroupConfig")]
        [Validation(Required=false)]
        public List<ModifyHybridMonitorSLSGroupRequestSLSGroupConfig> SLSGroupConfig { get; set; }
        public class ModifyHybridMonitorSLSGroupRequestSLSGroupConfig : TeaModel {
            [NameInMap("SLSLogstore")]
            [Validation(Required=false)]
            public string SLSLogstore { get; set; }

            [NameInMap("SLSProject")]
            [Validation(Required=false)]
            public string SLSProject { get; set; }

            [NameInMap("SLSRegion")]
            [Validation(Required=false)]
            public string SLSRegion { get; set; }

            [NameInMap("SLSUserId")]
            [Validation(Required=false)]
            public string SLSUserId { get; set; }

        }

        [NameInMap("SLSGroupDescription")]
        [Validation(Required=false)]
        public string SLSGroupDescription { get; set; }

        [NameInMap("SLSGroupName")]
        [Validation(Required=false)]
        public string SLSGroupName { get; set; }

    }

}
