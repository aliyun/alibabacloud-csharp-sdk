// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateHostGroupRequest : TeaModel {
        /// <summary>
        /// The description of the host group. The description can be up to 500 characters in length.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The name of the host group. The name can be up to 128 characters in length.
        /// </summary>
        [NameInMap("HostGroupName")]
        [Validation(Required=false)]
        public string HostGroupName { get; set; }

        /// <summary>
        /// The ID of the bastion host on which you want to create a host group.
        /// 
        /// > You can call the [DescribeInstances](~~153281~~) operation to query the ID of the bastion host.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID of the bastion host on which you want to create a host group.
        /// 
        /// **
        /// 
        /// **For more information about the mapping between region IDs and region names, see **Regions and zones[.](~~40654~~)
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
