// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyHostRequest : TeaModel {
        /// <summary>
        /// The new internal endpoint of the host. You can set this parameter to a domain name or an IP address.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The ID of the Bastionhost instance where you want to modify the information of the host.
        /// 
        /// >  You can call the [DescribeInstances](~~153281~~) operation to query the ID of the Bastionhost instance.
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// The new name of the host. The name can be up to 128 characters.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The new description of the host. The value can be up to 500 characters in length.
        /// </summary>
        [NameInMap("HostPrivateAddress")]
        [Validation(Required=false)]
        public string HostPrivateAddress { get; set; }

        /// <summary>
        /// The region ID of the Bastionhost instance where you want to modify the information of the host.
        /// 
        /// >  For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("HostPublicAddress")]
        [Validation(Required=false)]
        public string HostPublicAddress { get; set; }

        /// <summary>
        /// You can call this operation to modify the basic information of an on-premises host, an Elastic Compute Service (ECS) instance, or a host in a dedicated cluster.
        /// 
        /// >  The basic information of ECS instances and hosts in dedicated clusters within your Alibaba Cloud account is synchronized to Bastionhost on a regular basis. After you modify the basic information of an ECS instance or a host in a dedicated cluster, the modification result may be overwritten by the synchronized information.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the host.
        /// 
        /// >  You can call the [ListHosts](~~200665~~) operation to query the ID of the host.
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        /// <summary>
        /// The new operating system of the host. Valid values:
        /// 
        /// *   **Linux**
        /// *   **Windows**
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
