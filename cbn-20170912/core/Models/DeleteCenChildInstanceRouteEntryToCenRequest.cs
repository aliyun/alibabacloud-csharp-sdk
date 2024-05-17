// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DeleteCenChildInstanceRouteEntryToCenRequest : TeaModel {
        /// <summary>
        /// The ID of the CEN instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the network instance belongs.
        /// 
        /// > If the network instance and the CEN instance belong to different Alibaba Cloud accounts, this parameter is required.
        /// </summary>
        [NameInMap("ChildInstanceAliUid")]
        [Validation(Required=false)]
        public long? ChildInstanceAliUid { get; set; }

        /// <summary>
        /// The ID of the network instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChildInstanceId")]
        [Validation(Required=false)]
        public string ChildInstanceId { get; set; }

        /// <summary>
        /// The ID of the region where the network instance is deployed.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to obtain the region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChildInstanceRegionId")]
        [Validation(Required=false)]
        public string ChildInstanceRegionId { get; set; }

        /// <summary>
        /// The type of the network instance. Valid values:
        /// 
        /// *   **VPC**: a virtual private cloud (VPC)
        /// *   **VBR**: a virtual border router (VBR)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChildInstanceType")]
        [Validation(Required=false)]
        public string ChildInstanceType { get; set; }

        /// <summary>
        /// The destination CIDR block of the route.
        /// 
        /// Specify the value of this parameter in CIDR notation. Example: 192.168.10.0/24.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the route table configured on the network instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

    }

}
