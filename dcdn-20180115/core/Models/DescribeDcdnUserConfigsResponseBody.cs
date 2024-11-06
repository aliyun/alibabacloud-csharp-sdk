// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The user configurations.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<DescribeDcdnUserConfigsResponseBodyConfigs> Configs { get; set; }
        public class DescribeDcdnUserConfigsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The name of the configuration.</para>
            /// <para>The configuration is specified by enterprise users and public service sectors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>allow_function</para>
            /// </summary>
            [NameInMap("ArgName")]
            [Validation(Required=false)]
            public string ArgName { get; set; }

            /// <summary>
            /// <para>The value of the configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cc_rule: HTTP flood protection</description></item>
            /// <item><description>ddos_dispatch: DDoS mitigation</description></item>
            /// <item><description>edge_safe: application security on points of presence (POPs)</description></item>
            /// <item><description>blocked_regions: region blacklist</description></item>
            /// <item><description>http_acl_policy: precise access control</description></item>
            /// <item><description>bot_manager: bot traffic management</description></item>
            /// <item><description>ip_reputation: IP reputation library</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;dcdn_allow\&quot;:[\&quot;cc_rule\&quot;,\&quot;ddos_dispatch\&quot;]}</para>
            /// </summary>
            [NameInMap("ArgValue")]
            [Validation(Required=false)]
            public string ArgValue { get; set; }

            /// <summary>
            /// <para>The name of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>domain_business_control</para>
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06D29681-B7CD-4034-A8CC-28AFFA213539</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
