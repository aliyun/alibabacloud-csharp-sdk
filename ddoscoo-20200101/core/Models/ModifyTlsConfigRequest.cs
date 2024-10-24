// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyTlsConfigRequest : TeaModel {
        /// <summary>
        /// <para>The details of the TLS policy. The value is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ssl_protocols</b>: the version of TLS. This field is required. Data type: string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>tls1.0</b>: TLS 1.0 and later</description></item>
        /// <item><description><b>tls1.1</b>: TLS 1.1 and later</description></item>
        /// <item><description><b>tls1.2</b>: TLS 1.2 and later</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>ssl_ciphers</b>: the type of the cipher suite. This field is required. Data type: string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all</b>: all cipher suites, which include strong and weak cipher suites</description></item>
        /// <item><description><b>improved</b>: enhanced cipher suites</description></item>
        /// <item><description><b>strong</b>: strong cipher suites</description></item>
        /// <item><description><b>default</b>: default cipher suites, which include only strong cipher suites</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ssl_protocols&quot;:&quot;tls1.0&quot;,&quot;ssl_ciphers&quot;:&quot;all&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <remarks>
        /// <para>A forwarding rule must be configured for the domain name. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query all domain names.</para>
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
        /// <para>The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
