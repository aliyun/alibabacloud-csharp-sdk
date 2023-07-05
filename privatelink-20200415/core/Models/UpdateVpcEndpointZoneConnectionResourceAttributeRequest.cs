// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class UpdateVpcEndpointZoneConnectionResourceAttributeRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The endpoint ID.
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// The region ID of the endpoint connection whose bandwidth you want to modify.
        /// 
        /// You can call the [DescribeRegions](~~120468~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource allocation mode. You can change the resource allocation mode only if the endpoint connection is in the **Disconnected** state. Valid values:
        /// 
        /// *   **Auto**: automatically and randomly allocates the service resource. In this mode, the service resource is deleted.
        /// *   **Mannual**: manually allocates the service resource. If you set the value to Mannual, you must also specify the **ResourceId** and **ResourceType** parameters.
        /// </summary>
        [NameInMap("ResourceAllocateMode")]
        [Validation(Required=false)]
        public string ResourceAllocateMode { get; set; }

        /// <summary>
        /// The ID of the service resource that you want to manually allocate or migrate in the zone where the endpoint connection is deployed.
        /// 
        /// > If **ResourceAllocateMode** is set to **Mannual**, or **ResourceReplaceMode** is set, this parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The migration mode of the service resource. Valid values:
        /// 
        /// *   **Graceful**: smoothly migrates the service resource in the zone.
        /// *   **Force**: forcefully migrates the service resource in the zone.
        /// 
        /// > If you want to migrate the service resource, you need to set this parameter. This parameter is available only if the endpoint connection is in the **Connected** state. If you set this parameter, you must also specify the **ResourceId** and **ResourceType** parameters.
        /// </summary>
        [NameInMap("ResourceReplaceMode")]
        [Validation(Required=false)]
        public string ResourceReplaceMode { get; set; }

        /// <summary>
        /// The type of the service resource. Valid values:
        /// 
        /// *   **slb**: a CLB instance that supports PrivateLink. In addition, the CLB instance is deployed in a VPC.
        /// *   **alb**: an Application Load Balancer (ALB) instance that supports PrivateLink. In addition, the ALB instance is deployed in a VPC.
        /// 
        /// > If **ResourceAllocateMode** is set to **Mannual**, or **ResourceReplaceMode** is set, this parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The endpoint service ID.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The zone ID.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
