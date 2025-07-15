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

        /// <summary>
        /// <para>The subtitle rules.</para>
        /// </summary>
        [NameInMap("RuleInfoList")]
        [Validation(Required=false)]
        public DescribeLiveAIProduceRulesResponseBodyRuleInfoList RuleInfoList { get; set; }
        public class DescribeLiveAIProduceRulesResponseBodyRuleInfoList : TeaModel {
            [NameInMap("RuleInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveAIProduceRulesResponseBodyRuleInfoListRuleInfo> RuleInfo { get; set; }
            public class DescribeLiveAIProduceRulesResponseBodyRuleInfoListRuleInfo : TeaModel {
                /// <summary>
                /// <para>The name of the application to which the live stream belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>App Name</para>
                /// </summary>
                [NameInMap("App")]
                [Validation(Required=false)]
                public string App { get; set; }

                /// <summary>
                /// <para>The description of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>live AI subtitle template</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo.aliyundoc.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The last time when the rule was modified. The value is a timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715594344000</para>
                /// </summary>
                [NameInMap("GmtModifyTime")]
                [Validation(Required=false)]
                public string GmtModifyTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule takes effect when stream pulling starts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsLazy")]
                [Validation(Required=false)]
                public bool? IsLazy { get; set; }

                /// <summary>
                /// <para>The specification of the exported subtitles.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lp_ld</para>
                /// </summary>
                [NameInMap("LiveTemplate")]
                [Validation(Required=false)]
                public string LiveTemplate { get; set; }

                /// <summary>
                /// <para>The ID of the subtitle rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72fba656-2cc2-40fd-923c-2a10c3b9****</para>
                /// </summary>
                [NameInMap("RulesId")]
                [Validation(Required=false)]
                public string RulesId { get; set; }

                /// <summary>
                /// <para>The name of the virtual background template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test0708</para>
                /// </summary>
                [NameInMap("StudioName")]
                [Validation(Required=false)]
                public string StudioName { get; set; }

                /// <summary>
                /// <para>The name of the subtitle template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sub1</para>
                /// </summary>
                [NameInMap("SubtitleName")]
                [Validation(Required=false)]
                public string SubtitleName { get; set; }

                /// <summary>
                /// <para>The suffix of the subtitle rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test0506</para>
                /// </summary>
                [NameInMap("SuffixName")]
                [Validation(Required=false)]
                public string SuffixName { get; set; }

            }

        }

    }

}
