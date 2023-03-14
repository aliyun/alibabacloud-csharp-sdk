/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AddHostsToGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the host group to which you want to add hosts.
        /// 
        /// >  You can call the [ListHostGroups](~~201307~~) operation to query the ID of the host group.
        /// </summary>
        [NameInMap("HostGroupId")]
        [Validation(Required=false)]
        public string HostGroupId { get; set; }

        /// <summary>
        /// The ID of the host that you want to add to the host group. The value is a JSON string. You can add up to 100 host IDs.
        /// 
        /// >  You can call the [ListHosts](~~200665~~) operation to query the IDs of hosts.
        /// </summary>
        [NameInMap("HostIds")]
        [Validation(Required=false)]
        public string HostIds { get; set; }

        /// <summary>
        /// The ID of the bastion host for which you want to add hosts to the host group.
        /// 
        /// >  You can call the [DescribeInstances](~~153281~~) operation to query the ID of the bastion host.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID of the bastion host for which you want to add hosts to the host group.
        /// 
        /// >  For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
