// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamWatermarkRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0df228-4a64- af62-20e91b9676b3</para>
        /// </summary>
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

        /// <summary>
        /// <para>The total number of entries that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
