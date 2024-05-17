// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DeleteRouteServiceInCenRequest : TeaModel {
        /// <summary>
        /// The ID of the region where the cloud service is accessed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccessRegionId")]
        [Validation(Required=false)]
        public string AccessRegionId { get; set; }

        /// <summary>
        /// The ID of the CEN instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The IP addresses or CIDR blocks of the cloud service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// The region ID of the cloud service.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("HostRegionId")]
        [Validation(Required=false)]
        public string HostRegionId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) that is associated with the cloud service.
        /// </summary>
        [NameInMap("HostVpcId")]
        [Validation(Required=false)]
        public string HostVpcId { get; set; }

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

    }

}
