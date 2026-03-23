// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMaskingRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeMaskingRulesResponseBodyData Data { get; set; }
        public class DescribeMaskingRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of encryption or desensitization rules</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeMaskingRulesResponseBodyDataRules> Rules { get; set; }
            public class DescribeMaskingRulesResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>Default encryption or masking algorithm</para>
                /// 
                /// <b>Example:</b>
                /// <para>aes-128-gcm</para>
                /// </summary>
                [NameInMap("DefaultAlgo")]
                [Validation(Required=false)]
                public string DefaultAlgo { get; set; }

                /// <summary>
                /// <para>Whether the rule is enabled</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public string Enabled { get; set; }

                /// <summary>
                /// <para>Rule algorithm. Multiple algorithms can be selected. Masking algorithms can include additional parameters. Format: {name: algorithm1}, {name: algorithm2, params: {encryption position, number of encrypted digits}}</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;name&quot;: &quot;aes-128-gcm&quot;},
                ///         {&quot;name&quot;:&quot;sm4-128-gcm&quot;}]</para>
                /// </summary>
                [NameInMap("MaskingAlgo")]
                [Validation(Required=false)]
                public string MaskingAlgo { get; set; }

                /// <summary>
                /// <para>Rule configuration</para>
                /// </summary>
                [NameInMap("RuleConfig")]
                [Validation(Required=false)]
                public DescribeMaskingRulesResponseBodyDataRulesRuleConfig RuleConfig { get; set; }
                public class DescribeMaskingRulesResponseBodyDataRulesRuleConfig : TeaModel {
                    /// <summary>
                    /// <para>List of columns</para>
                    /// </summary>
                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public List<string> Columns { get; set; }

                    /// <summary>
                    /// <para>List of databases</para>
                    /// </summary>
                    [NameInMap("Databases")]
                    [Validation(Required=false)]
                    public List<string> Databases { get; set; }

                    /// <summary>
                    /// <para>Table List</para>
                    /// </summary>
                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<string> Tables { get; set; }

                }

                /// <summary>
                /// <para>Rule Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>69779000-57A4-38F6-BF85-**********A2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
