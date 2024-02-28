// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class RemoveUsersFromGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the bastion host for which you want to remove users from the user group.
        /// 
        /// >  You can call the [DescribeInstances](~~153281~~) operation to query the ID of the bastion host.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID of the bastion host for which you want to remove users from the user group.
        /// 
        /// >  For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the user group from which you want to remove users.
        /// 
        /// >  You can call the [ListUserGroups](~~204509~~) operation to query the ID of the user group.
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// The ID of the user who you want to remove. The value is a JSON string. You can add up to 100 user IDs. If you specify multiple IDs, separate the IDs with commas (,).
        /// 
        /// >  You can call the [ListUsers](~~204522~~) operation to query the IDs of users.
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

    }

}
