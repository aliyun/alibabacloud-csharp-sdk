// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamWatermarkRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleInfoList")]
        [Validation(Required=false)]
        public DescribeLiveStreamWatermarkRulesResponseBodyRuleInfoList RuleInfoList { get; set; }
        public class DescribeLiveStreamWatermarkRulesResponseBodyRuleInfoList : TeaModel {
            [NameInMap("RuleInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamWatermarkRulesResponseBodyRuleInfoListRuleInfo> RuleInfo { get; set; }
            public class DescribeLiveStreamWatermarkRulesResponseBodyRuleInfoListRuleInfo : TeaModel {
                [NameInMap("App")]
                [Validation(Required=false)]
                public string App { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("Stream")]
                [Validation(Required=false)]
                public string Stream { get; set; }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

            }

        }

    }

}
