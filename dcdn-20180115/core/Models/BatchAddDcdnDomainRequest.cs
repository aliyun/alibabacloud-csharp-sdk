// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchAddDcdnDomainRequest : TeaModel {
        /// <summary>
        /// <para>The URL that is used for health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com/test.html">www.example.com/test.html</a></para>
        /// </summary>
        [NameInMap("CheckUrl")]
        [Validation(Required=false)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// <para>You can add up to 20 domain names to DCDN for each of your Alibaba Cloud account. If you specify multiple domain names, separate them with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,example.org</para>
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
        /// <para>testID</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The acceleration region. Default value: domestic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>domestic: Chinese mainland</description></item>
        /// <item><description>overseas: global (excluding the Chinese mainland)</description></item>
        /// <item><description>global: global</description></item>
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
        /// <para>[{&quot;content&quot;:&quot;10.10.10.10&quot;,&quot;type&quot;:&quot;ipaddr&quot;,&quot;priority&quot;:&quot;20&quot;,&quot;port&quot;:80,&quot;weight&quot;:&quot;15&quot;}]</para>
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
