// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetUserRequest : TeaModel {
        /// <summary>
        /// The ID of the bastion host on which you want to query the user.
        /// 
        /// > You can call the [DescribeInstances](~~153281~~) operation to query the ID of the bastion host.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID of the bastion host on which you want to query the user.
        /// 
        /// > For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the user.
        /// 
        /// > You can call the [ListUsers](~~204522~~) operation to query the ID of the user.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
