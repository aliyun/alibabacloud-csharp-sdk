// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The user configurations.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<DescribeCdnUserConfigsResponseBodyConfigs> Configs { get; set; }
        public class DescribeCdnUserConfigsResponseBodyConfigs : TeaModel {
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
            /// <item><description><b>cc_rule</b>: HTTP flood protection rules</description></item>
            /// <item><description><b>ddos_dispatch</b>: integration with Anti-DDoS</description></item>
            /// <item><description><b>edge_safe</b>: application security settings on POPs</description></item>
            /// <item><description><b>blocked_regions</b>: blocked regions</description></item>
            /// <item><description><b>http_acl_policy</b>: access control list (ACL) rules</description></item>
            /// <item><description><b>bot_manager</b>: bot traffic management</description></item>
            /// <item><description><b>ip_reputation</b>: IP reputation library</description></item>
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
