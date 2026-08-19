// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class BatchSetVodDomainConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain names for ApsaraVideo VOD. Separate multiple domain names with commas (,). You can configure up to 50 domain names at a time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

        /// <summary>
        /// <para>The list of features.</para>
        /// <list type="bullet">
        /// <item><description>functionName (feature name, required): For the features that can be configured and their feature name parameters, see <a href="https://help.aliyun.com/document_detail/2411639.html">Domain name configuration features</a>.</description></item>
        /// <item><description>argName (parameter name, required): The configuration items of functionName. You can configure multiple configuration items.</description></item>
        /// <item><description>argValue (parameter value, required): The values of the configuration items of functionName.</description></item>
        /// </list>
        /// <para>For detailed information about the features that can be configured for accelerated domain names, including feature names and parameter names, see <a href="https://help.aliyun.com/document_detail/2411639.html">Domain name configuration features</a>.</para>
        /// <remarks>
        /// <para>Some features, such as filetype_based_ttl_set (file expiration time), support multiple configuration rules. To update a specific configuration rule, specify the configId of that rule. Example:
        /// <c>[{&quot;functionArgs&quot;:[{&quot;argName&quot;:&quot;file_type&quot;,&quot;argValue&quot;:&quot;jpg&quot;},{&quot;argName&quot;:&quot;ttl&quot;,&quot;argValue&quot;:&quot;18&quot;},{&quot;argName&quot;:&quot;weight&quot;,&quot;argValue&quot;:&quot;30&quot;}],&quot;functionName&quot;:&quot;filetype_based_ttl_set&quot;,&quot;configId&quot;:5068995}]</c></para>
        /// </remarks>
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
