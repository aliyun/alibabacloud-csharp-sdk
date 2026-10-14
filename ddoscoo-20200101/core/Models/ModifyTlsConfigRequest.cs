// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyTlsConfigRequest : TeaModel {
        /// <summary>
        /// <para>The details of the TLS security policy, expressed as a JSON-formatted string with the following structure.</para>
        /// <list type="bullet">
        /// <item><description><b>ssl_protocols</b>: String type, required. The TLS version. Valid values:<list type="bullet">
        /// <item><description><b>tls1.0</b>: TLS 1.0 and later are supported.</description></item>
        /// <item><description><b>tls1.1</b>: TLS 1.1 and later are supported.</description></item>
        /// <item><description><b>tls1.2</b>: TLS 1.2 and later are supported.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>ssl_ciphers</b>: String type, required. The cipher suite type. Valid values:<list type="bullet">
        /// <item><description><b>all</b>: all cipher suites, including strong and weak cipher suites</description></item>
        /// <item><description><b>improved</b>: enhanced cipher suites</description></item>
        /// <item><description><b>strong</b>: strong cipher suites only</description></item>
        /// <item><description><b>default</b>: default cipher suites, which include only strong cipher suites</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>ssl_13_enabled</b>: Boolean type, optional. Specifies whether to enable TLS 1.3. Valid values:<list type="bullet">
        /// <item><description><b>true</b>: Enables TLS 1.3.</description></item>
        /// <item><description><b>false</b>: Disables TLS 1.3.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>custom_ciphers</b>: Array type, optional. The list of custom cipher suites for TLS versions earlier than 1.3.</description></item>
        /// <item><description><b>tls_13_custom_ciphers</b>: Array type, optional. The list of custom cipher suites for TLS 1.3. If TLS 1.3 is enabled, select at least one cipher suite for TLS versions earlier than 1.3.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;ssl_protocols&quot;: &quot;tls1.2&quot;,
        ///   &quot;ssl_ciphers&quot;: &quot;default&quot;,
        ///   &quot;ssl_13_enabled&quot;: true,
        ///   &quot;custom_ciphers&quot;: [
        ///     &quot;ECDHE-ECDSA-AES128-GCM-SHA256&quot;
        ///   ],
        ///   &quot;tls_13_custom_ciphers&quot;: [
        ///     &quot;TLS_AES_256_GCM_SHA384&quot;
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <remarks>
        /// <para>The domain name must have a website forwarding rule configured. You can call <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> to query all domain names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Pro or Anti-DDoS Premium instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
