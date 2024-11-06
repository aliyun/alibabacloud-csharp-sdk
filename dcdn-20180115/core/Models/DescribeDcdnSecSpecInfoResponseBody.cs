// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSecSpecInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32f6cbb7-13e5-403a-9941-4d4e978dd227</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The code and configurations of the security rules.</para>
        /// </summary>
        [NameInMap("SpecInfos")]
        [Validation(Required=false)]
        public List<DescribeDcdnSecSpecInfoResponseBodySpecInfos> SpecInfos { get; set; }
        public class DescribeDcdnSecSpecInfoResponseBodySpecInfos : TeaModel {
            /// <summary>
            /// <para>The code of the security rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accurate_***</para>
            /// </summary>
            [NameInMap("RuleCode")]
            [Validation(Required=false)]
            public string RuleCode { get; set; }

            /// <summary>
            /// <para>The configurations of the security rule.</para>
            /// </summary>
            [NameInMap("RuleConfigs")]
            [Validation(Required=false)]
            public List<DescribeDcdnSecSpecInfoResponseBodySpecInfosRuleConfigs> RuleConfigs { get; set; }
            public class DescribeDcdnSecSpecInfoResponseBodySpecInfosRuleConfigs : TeaModel {
                /// <summary>
                /// <para>The configuration code of the security rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>custom_****_number</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The configuration expression of the security rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>equal</para>
                /// </summary>
                [NameInMap("Expr")]
                [Validation(Required=false)]
                public string Expr { get; set; }

                /// <summary>
                /// <para>The value of the configuration expression of the security rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The version of secure DCDN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
