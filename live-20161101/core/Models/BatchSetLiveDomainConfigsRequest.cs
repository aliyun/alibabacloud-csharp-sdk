// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class BatchSetLiveDomainConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The domain names that you want to batch configure. Supported domain names include ingest domains, main streaming domains, and sub-streaming domains. Separate multiple domain names with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com,example.aliyundoc.com,example.com</para>
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

        /// <summary>
        /// <para>The list of features.</para>
        /// <para>Some features, such as <c>filetype_based_ttl_set</c>, support multiple configuration records. To update one of the configuration records, use <c>configId</c> to identify the record. For more information, see <b>Format of the Functions parameter</b> and <b>Features specified by the Functions parameter</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;functionArgs&quot;:[{&quot;argName&quot;:&quot;file_type&quot;,&quot;argValue&quot;:&quot;jpg&quot;},{&quot;argName&quot;:&quot;ttl&quot;,&quot;argValue&quot;:&quot;18&quot;},{&quot;argName&quot;:&quot;weight&quot;,&quot;argValue&quot;:&quot;30&quot;}],&quot;functionName&quot;:&quot;filetype_based_ttl_set&quot;,&quot;configId&quot;:506***}]</para>
        /// </summary>
        [NameInMap("Functions")]
        [Validation(Required=false)]
        public string Functions { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
