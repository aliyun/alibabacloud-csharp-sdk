// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAssetGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the new server group to which the servers belong.
        /// 
        /// > You can call the [DescribeAllGroups](~~DescribeAllGroups~~) operation to query the IDs of server groups.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The UUIDs of the servers for which you want to change the server group. Separate multiple UUIDs with commas (,).
        /// 
        /// > You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
