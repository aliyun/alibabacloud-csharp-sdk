// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafSpecInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The version of WAF.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcdnwaf_afterpay</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7281593a-f414-42c1-b7ba-2ce65e21cc00</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The supported types of protection policies and the configuration information of protection rules.</para>
        /// </summary>
        [NameInMap("SpecInfos")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafSpecInfoResponseBodySpecInfos> SpecInfos { get; set; }
        public class DescribeDcdnWafSpecInfoResponseBodySpecInfos : TeaModel {
            /// <summary>
            /// <para>The configuration information of the protection rule.</para>
            /// </summary>
            [NameInMap("Configs")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafSpecInfoResponseBodySpecInfosConfigs> Configs { get; set; }
            public class DescribeDcdnWafSpecInfoResponseBodySpecInfosConfigs : TeaModel {
                /// <summary>
                /// <para>The configuration code of the protection rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// <para>The configuration expression of the protection rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>equal</para>
                /// </summary>
                [NameInMap("Expr")]
                [Validation(Required=false)]
                public string Expr { get; set; }

                /// <summary>
                /// <para>The value of the configuration expression of the protection rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the protection policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>waf_group: basic web protection</description></item>
            /// <item><description>custom_acl: custom</description></item>
            /// <item><description>whitelist: whitelist</description></item>
            /// <item><description>ip_blacklist: IP address blacklist</description></item>
            /// <item><description>region_block: region blacklist</description></item>
            /// <item><description>bot: bot management</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom_acl</para>
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

        }

    }

}
