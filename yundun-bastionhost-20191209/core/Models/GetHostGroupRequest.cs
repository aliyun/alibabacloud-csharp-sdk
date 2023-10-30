// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetHostGroupRequest : TeaModel {
        /// <summary>
        /// The region ID of the Bastionhost instance where you want to query the host group.
        /// 
        /// >  For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("HostGroupId")]
        [Validation(Required=false)]
        public string HostGroupId { get; set; }

        /// <summary>
        /// MyHostGroup
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the Bastionhost instance where you want to query the host group.
        /// 
        /// >  You can call the [DescribeInstances](~~153281~~) operation to query the ID of the Bastionhost instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
