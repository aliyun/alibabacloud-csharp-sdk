// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBasicAccelerateIpEndpointRelationRequest : TeaModel {
        /// <summary>
        /// The ID of the accelerated IP address.
        /// 
        /// You can call the [ListBasicAccelerateIps](https://help.aliyun.com/document_detail/2253393.html) operation to query the ID of the accelerated IP address.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccelerateIpId")]
        [Validation(Required=false)]
        public string AccelerateIpId { get; set; }

        /// <summary>
        /// The ID of the basic GA instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the endpoint.
        /// 
        /// You can call the [ListBasicEndpoints](https://help.aliyun.com/document_detail/2253406.html) operation to query the ID of the endpoint.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
