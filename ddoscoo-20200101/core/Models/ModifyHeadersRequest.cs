// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyHeadersRequest : TeaModel {
        /// <summary>
        /// The key-value pair of the custom header. Key indicates the header name and Value indicates the header value. You can specify up to five key-value pairs. The key-value pairs can be up to 200 characters in length.
        /// 
        /// Take note of the following items:
        /// 
        /// *   Do not use X-Forwarded-ClientSrcPort as a custom header.
        /// *   Do not use a standard HTTP header such as User-Agent. If you use a standard HTTP header, the original header may be overwritten.
        /// 
        /// > If you set Key to X-Forwarded-ClientSrcPort, the actual source port of the client that accesses Anti-DDoS Pro or Anti-DDoS Premium (a Layer 7 proxy) is obtained. In this case, the Value is "".
        /// </summary>
        [NameInMap("CustomHeaders")]
        [Validation(Required=false)]
        public string CustomHeaders { get; set; }

        /// <summary>
        /// The domain name of the website.
        /// 
        /// > A forwarding rule must be configured for the domain name. You can call the [DescribeDomains](~~91724~~) operation to query all domain names.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs.
        /// 
        /// > 
        /// 
        /// *   You can query resource group IDs in the Anti-DDoS Pro or Anti-DDoS Premium console or by calling the [ListResourceGroups](~~158855~~) operation. For more information, see [View basic information of a resource group](~~151181~~).
        /// 
        /// *   Before you modify the resource group to which an instance belongs, you can call the [ListResources](~~158866~~) operation to view the current resource group of the instance.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
