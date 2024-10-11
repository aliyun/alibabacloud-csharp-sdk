// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class BatchSetVodDomainConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The domain name for CDN. Separate multiple domain names with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

        /// <summary>
        /// <para>The features to configure.</para>
        /// <list type="bullet">
        /// <item><description>Set this parameter in the following format: <c>[{&quot;functionArgs&quot;:[{&quot;argName&quot;:&quot;domain_name&quot;,&quot;argValue&quot;:&quot;www.example.com&quot;}],&quot;functionName&quot;:&quot;set_req_host_header&quot;}]</c>.</description></item>
        /// <item><description>Specific features, such as filetype_based_ttl_set, support more than one configuration record. To update one of the configuration records, use the configId field to specify the record. <c>[{&quot;functionArgs&quot;:[{&quot;argName&quot;:&quot;file_type&quot;,&quot;argValue&quot;:&quot;jpg&quot;},{&quot;argName&quot;:&quot;ttl&quot;,&quot;argValue&quot;:&quot;18&quot;},{&quot;argName&quot;:&quot;weight&quot;,&quot;argValue&quot;:&quot;30&quot;}],&quot;functionName&quot;:&quot;filetype_based_ttl_set&quot;,&quot;configId&quot;:5068995}]</c></description></item>
        /// <item><description>For more information, see the <b>Feature description</b> section.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;functionArgs&quot;:[{&quot;argName&quot;:&quot;domain_name&quot;,&quot;argValue&quot;:&quot;<a href="http://www.example.com%22%7D%5D,%22functionName%22:%22set_req_host_header%22%7D%5D">www.example.com&quot;}],&quot;functionName&quot;:&quot;set_req_host_header&quot;}]</a></para>
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
