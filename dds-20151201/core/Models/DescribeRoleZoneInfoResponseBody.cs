// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRoleZoneInfoResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of information of nodes in the zone.
        /// </summary>
        [NameInMap("ZoneInfos")]
        [Validation(Required=false)]
        public DescribeRoleZoneInfoResponseBodyZoneInfos ZoneInfos { get; set; }
        public class DescribeRoleZoneInfoResponseBodyZoneInfos : TeaModel {
            [NameInMap("ZoneInfo")]
            [Validation(Required=false)]
            public List<DescribeRoleZoneInfoResponseBodyZoneInfosZoneInfo> ZoneInfo { get; set; }
            public class DescribeRoleZoneInfoResponseBodyZoneInfosZoneInfo : TeaModel {
                /// <summary>
                /// The ID of the node.
                /// </summary>
                [NameInMap("InsName")]
                [Validation(Required=false)]
                public string InsName { get; set; }

                /// <summary>
                /// The type of the node. Valid values:
                /// 
                /// *   **normal**
                /// *   **configServer**
                /// *   **shard**
                /// *   **mongos**
                /// 
                /// >  Valid value for replica set instances: **normal**. Valid values for replica set instances: **configServer**, **shard**, and **mongos**.
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// The ID of the role.
                /// </summary>
                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                /// <summary>
                /// The role of the node. Valid values:
                /// 
                /// *   **Primary**
                /// *   **Secondary**
                /// *   **Hidden**
                /// </summary>
                [NameInMap("RoleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
