// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class BatchUpdateCdnDomainRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain names. You can specify one or more accelerated domain names. Separate domain names with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,example.org</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyuji4b6r4**</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The information about the addresses of origin servers.</para>
        /// <remarks>
        /// <para>Do not set <b>Sources</b> and <b>TopLevelDomain</b> at the same time. If you set <b>Sources</b> and <b>TopLevelDomain</b> at the same time, <b>TopLevelDomain</b> does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;content&quot;:&quot;10.10.10.10&quot;,&quot;type&quot;:&quot;ipaddr&quot;,&quot;priority&quot;:&quot;20&quot;,&quot;port&quot;:80,&quot;weight&quot;:&quot;15&quot;}]</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

        /// <summary>
        /// <para>The root domain.</para>
        /// <remarks>
        /// <para>Do not set <b>Sources</b> and <b>TopLevelDomain</b> at the same time. If you set <b>Sources</b> and <b>TopLevelDomain</b> at the same time, <b>TopLevelDomain</b> does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("TopLevelDomain")]
        [Validation(Required=false)]
        public string TopLevelDomain { get; set; }

    }

}
