// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class BizTraceConfig : TeaModel {
        [NameInMap("advancedConfig")]
        [Validation(Required=false)]
        public string AdvancedConfig { get; set; }

        [NameInMap("bizTraceCode")]
        [Validation(Required=false)]
        public string BizTraceCode { get; set; }

        [NameInMap("bizTraceId")]
        [Validation(Required=false)]
        public string BizTraceId { get; set; }

        [NameInMap("bizTraceName")]
        [Validation(Required=false)]
        public string BizTraceName { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ruleConfig")]
        [Validation(Required=false)]
        public string RuleConfig { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
