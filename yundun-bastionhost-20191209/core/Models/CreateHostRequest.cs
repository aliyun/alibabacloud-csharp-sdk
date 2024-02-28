// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateHostRequest : TeaModel {
        /// <summary>
        /// The endpoint type of the host that you want to create. Valid values:
        /// 
        /// *   **Public**: public endpoint
        /// *   **Private**: internal endpoint
        /// </summary>
        [NameInMap("ActiveAddressType")]
        [Validation(Required=false)]
        public string ActiveAddressType { get; set; }

        /// <summary>
        /// The description of the host that you want to create. The value can be up to 500 characters in length.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The name of the host that you want to create. The name can be up to 128 characters in length.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The internal endpoint of the host that you want to create. You can set this parameter to a domain name or an IP address.
        /// 
        /// > This parameter is required if the **ActiveAddressType** parameter is set to **Private**.
        /// </summary>
        [NameInMap("HostPrivateAddress")]
        [Validation(Required=false)]
        public string HostPrivateAddress { get; set; }

        /// <summary>
        /// The public endpoint of the host that you want to create. You can set this parameter to a domain name or an IP address.
        /// 
        /// > This parameter is required if the **ActiveAddressType** parameter is set to **Public**.
        /// </summary>
        [NameInMap("HostPublicAddress")]
        [Validation(Required=false)]
        public string HostPublicAddress { get; set; }

        /// <summary>
        /// The ID of the bastion host in which you want to create the host.
        /// 
        /// > You can call the [DescribeInstances](~~153281~~) operation to query the ID of the bastion host.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the region to which the ECS instance or the host in an ApsaraDB MyBase dedicated cluster belongs.
        /// 
        /// > This parameter is required if the **Source** parameter is set to **Ecs** or **Rds**.
        /// </summary>
        [NameInMap("InstanceRegionId")]
        [Validation(Required=false)]
        public string InstanceRegionId { get; set; }

        /// <summary>
        /// The ID of the network domain to which the host belongs.
        /// </summary>
        [NameInMap("NetworkDomainId")]
        [Validation(Required=false)]
        public string NetworkDomainId { get; set; }

        /// <summary>
        /// The operating system of the host that you want to create. Valid values:
        /// 
        /// *   **Linux**
        /// *   **Windows**
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        /// <summary>
        /// The region ID of the bastion host in which you want to create the host.
        /// 
        /// > For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The source of the host that you want to create. Valid values:
        /// 
        /// *   **Local**: a host in a data center
        /// *   **Ecs**: an Elastic Compute Service (ECS) instance
        /// *   **Rds**: a host in an ApsaraDB MyBase dedicated cluster
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The ID of the ECS instance or the host in an ApsaraDB MyBase dedicated cluster.
        /// 
        /// > This parameter is required if the **Source** parameter is set to **Ecs** or **Rds**.
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

    }

}
