// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class BatchAddCdnDomainRequest : TeaModel {
        /// <summary>
        /// <para>The workload type of the domain name to accelerate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>web</b>: images and small files</description></item>
        /// <item><description><b>download</b>: large files</description></item>
        /// <item><description><b>video</b>: on-demand video and audio streaming</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("CdnType")]
        [Validation(Required=false)]
        public string CdnType { get; set; }

        /// <summary>
        /// <para>The URL that is used for health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>url</para>
        /// </summary>
        [NameInMap("CheckUrl")]
        [Validation(Required=false)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// <para>The domain names that you want to add to Alibaba Cloud CDN. Separate domain names with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. If you do not specify a value for this parameter, the system uses the ID of the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyuji4b6r4**</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The acceleration region. Default value: domestic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: Chinese mainland</description></item>
        /// <item><description><b>overseas</b>: global (excluding the Chinese mainland)</description></item>
        /// <item><description><b>global</b>: global</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>domestic</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The information about the addresses of origin servers.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;content&quot;: &quot;192.0.2.0&quot;,
        ///             &quot;type&quot;: &quot;ipaddr&quot;,
        ///             &quot;priority&quot;: &quot;20&quot;,
        ///             &quot;port&quot;: 80,
        ///             &quot;weight&quot;: &quot;15&quot;
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

        /// <summary>
        /// <para>The top-level domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("TopLevelDomain")]
        [Validation(Required=false)]
        public string TopLevelDomain { get; set; }

    }

}
