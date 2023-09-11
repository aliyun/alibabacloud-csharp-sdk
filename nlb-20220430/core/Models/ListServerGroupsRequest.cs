// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListServerGroupsRequest : TeaModel {
        /// <summary>
        /// The number of entries per page. Valid values: **1** to **100**. Default value: **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   You do not need to specify this parameter for the first request.
        /// *   You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID of the NLB instance.
        /// 
        /// You can call the [DescribeRegions](~~443657~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the server group belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The server group ID. You can specify up to 20 server group IDs in each call.
        /// </summary>
        [NameInMap("ServerGroupIds")]
        [Validation(Required=false)]
        public List<string> ServerGroupIds { get; set; }

        /// <summary>
        /// The names of the server groups to be queried. You can specify up to 20 names in each call.
        /// </summary>
        [NameInMap("ServerGroupNames")]
        [Validation(Required=false)]
        public List<string> ServerGroupNames { get; set; }

        /// <summary>
        /// The type of server group. Valid values:
        /// 
        /// *   **Instance** : allows you to add servers of the **Ecs**, **Ens**, and **Eci** types.
        /// *   **Ip**: allows you to add servers by specifying IP addresses.
        /// </summary>
        [NameInMap("ServerGroupType")]
        [Validation(Required=false)]
        public string ServerGroupType { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListServerGroupsRequestTag> Tag { get; set; }
        public class ListServerGroupsRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag. You can specify up to 10 tag keys.
            /// 
            /// The tag key can be up to 64 characters in length, and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag. You can specify up to 10 tag values.
            /// 
            /// The tag value can be up to 128 characters in length, and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the server group belongs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
