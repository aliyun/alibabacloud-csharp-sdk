// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayConfigRequest : TeaModel {
        /// <summary>
        /// <para>The language in which you want to display the results. Valid values: zh (default): Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The configuration name of the parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>EnableHttp2</para>
        /// </description></item>
        /// <item><description><para>DownstreamIdleTime</para>
        /// </description></item>
        /// <item><description><para>PreserveHeaderFormat</para>
        /// </description></item>
        /// <item><description><para>UpstreamIdleTimeout</para>
        /// </description></item>
        /// <item><description><para>EnableXffTrustedCidrs</para>
        /// </description></item>
        /// <item><description><para>EnableK8sSourceWorkloadFilter</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EnableK8sSourceWorkloadFilter</para>
        /// </summary>
        [NameInMap("ConfigName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// <para>The configuration value of the parameter. Examples:</para>
        /// <list type="bullet">
        /// <item><description>EnableHttp2</description></item>
        /// </list>
        /// <pre><c>true / false
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>DownstreamIdleTime</description></item>
        /// </list>
        /// <pre><c>15
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>PreserveHeaderFormat</description></item>
        /// </list>
        /// <pre><c>true / false
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>UpstreamIdleTimeout</description></item>
        /// </list>
        /// <pre><c>60
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>EnableXffTrustedCidrs</description></item>
        /// </list>
        /// <pre><code class="language-json">{&quot;enable&quot;:true,&quot;ipListContent&quot;:&quot;192.168.1.0/24
        /// 2.2.2.2&quot;}
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>EnableK8sSourceWorkloadFilter</description></item>
        /// </list>
        /// <pre><code class="language-json">    
        /// {&quot;enable&quot;:true,&quot;filterOpt&quot;:&quot;EQUAL&quot;,&quot;labelKey&quot;:&quot;key&quot;,&quot;labelValue&quot;:&quot;value&quot;}
        /// </c></pre>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enable&quot;:true,&quot;filterOpt&quot;:&quot;EQUAL&quot;,&quot;labelKey&quot;:&quot;key&quot;,&quot;labelValue&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-b525dc1adf3c486ab96224a6346*****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

    }

}
