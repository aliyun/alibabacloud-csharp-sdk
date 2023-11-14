// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyContainerPluginRuleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyContainerPluginRuleResponseBodyData Data { get; set; }
        public class ModifyContainerPluginRuleResponseBodyData : TeaModel {
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
