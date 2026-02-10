// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAIProduceRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0df228-4a64- af62-20e91b96****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleInfoList")]
        [Validation(Required=false)]
        public DescribeLiveAIProduceRulesResponseBodyRuleInfoList RuleInfoList { get; set; }
        public class DescribeLiveAIProduceRulesResponseBodyRuleInfoList : TeaModel {
            [NameInMap("RuleInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveAIProduceRulesResponseBodyRuleInfoListRuleInfo> RuleInfo { get; set; }
            public class DescribeLiveAIProduceRulesResponseBodyRuleInfoListRuleInfo : TeaModel {
                [NameInMap("App")]
                [Validation(Required=false)]
                public string App { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("GmtModifyTime")]
                [Validation(Required=false)]
                public string GmtModifyTime { get; set; }

                [NameInMap("IsLazy")]
                [Validation(Required=false)]
                public bool? IsLazy { get; set; }

                [NameInMap("LiveTemplate")]
                [Validation(Required=false)]
                public string LiveTemplate { get; set; }

                [NameInMap("RulesId")]
                [Validation(Required=false)]
                public string RulesId { get; set; }

                [NameInMap("StudioName")]
                [Validation(Required=false)]
                public string StudioName { get; set; }

                [NameInMap("SubtitleName")]
                [Validation(Required=false)]
                public string SubtitleName { get; set; }

                [NameInMap("SuffixName")]
                [Validation(Required=false)]
                public string SuffixName { get; set; }

            }

        }

    }

}
