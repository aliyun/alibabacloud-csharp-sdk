// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMaskingRulesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeMaskingRulesResponseBodyData Data { get; set; }
        public class DescribeMaskingRulesResponseBodyData : TeaModel {
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeMaskingRulesResponseBodyDataRules> Rules { get; set; }
            public class DescribeMaskingRulesResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>aes-128-gcm</para>
                /// </summary>
                [NameInMap("DefaultAlgo")]
                [Validation(Required=false)]
                public string DefaultAlgo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public string Enabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{&quot;name&quot;: &quot;aes-128-gcm&quot;},
                ///         {&quot;name&quot;:&quot;sm4-128-gcm&quot;}]</para>
                /// </summary>
                [NameInMap("MaskingAlgo")]
                [Validation(Required=false)]
                public string MaskingAlgo { get; set; }

                [NameInMap("RuleConfig")]
                [Validation(Required=false)]
                public DescribeMaskingRulesResponseBodyDataRulesRuleConfig RuleConfig { get; set; }
                public class DescribeMaskingRulesResponseBodyDataRulesRuleConfig : TeaModel {
                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public List<string> Columns { get; set; }

                    [NameInMap("Databases")]
                    [Validation(Required=false)]
                    public List<string> Databases { get; set; }

                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<string> Tables { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>69779000-57A4-38F6-BF85-**********A2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
