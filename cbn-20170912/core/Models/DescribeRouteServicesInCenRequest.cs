// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeRouteServicesInCenRequest : TeaModel {
        /// <summary>
        /// The ID of the region where the cloud service is accessed.
        /// </summary>
        [NameInMap("AccessRegionId")]
        [Validation(Required=false)]
        public string AccessRegionId { get; set; }

        /// <summary>
        /// The ID of the Cloud Enterprise Network (CEN) instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The service address of the cloud service.
        /// 
        /// You can enter a domain name, an IP address, or a CIDR block.
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// The region ID of the cloud service.
        /// 
        /// You can call the [DescribeChildInstanceRegions](https://help.aliyun.com/document_detail/132080.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("HostRegionId")]
        [Validation(Required=false)]
        public string HostRegionId { get; set; }

        /// <summary>
        /// The ID of the VPC associated with the cloud service.
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

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **10**. Valid values: **1** to **50**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
