// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudGroupsResponseBody : TeaModel {
        /// <summary>
        /// The node groups.
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudGroupsResponseBodyGroups> Groups { get; set; }
        public class DescribeHybridCloudGroupsResponseBodyGroups : TeaModel {
            /// <summary>
            /// The back-to-origin mark of the protected cluster. The value is in the {ISP name}-{Continent name}-{City name}-{Back-to-origin identifier} format. The back-to-origin identifier is optional.
            /// 
            /// >  For more information about ISP names, continent names, city names, and back-to-origin identifiers, see the following sections.
            /// </summary>
            [NameInMap("BackSourceMark")]
            [Validation(Required=false)]
            public string BackSourceMark { get; set; }

            /// <summary>
            /// The continent code of the protected cluster.
            /// 
            /// >  For more information about continent codes, see Continent codes in this topic.
            /// </summary>
            [NameInMap("ContinentsValue")]
            [Validation(Required=false)]
            public int? ContinentsValue { get; set; }

            /// <summary>
            /// The ID of the node group.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            /// <summary>
            /// The name of the node group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The type of the node group. Valid values:
            /// 
            /// *   **protect**
            /// *   **control**
            /// *   **storage**
            /// *   **controlStorage**
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// The IP address of the server used for load balancing.
            /// </summary>
            [NameInMap("LoadBalanceIp")]
            [Validation(Required=false)]
            public string LoadBalanceIp { get; set; }

            /// <summary>
            /// The ID of the protection node.
            /// </summary>
            [NameInMap("LocationId")]
            [Validation(Required=false)]
            public long? LocationId { get; set; }

            /// <summary>
            /// The ISP code of the protected cluster.
            /// 
            /// >  For more information about ISP codes, see ISP codes in this topic.
            /// </summary>
            [NameInMap("OperatorValue")]
            [Validation(Required=false)]
            public int? OperatorValue { get; set; }

            /// <summary>
            /// The port that is used by the hybrid cloud cluster. The value of this parameter is a string. If multiple ports are returned, the value is in the **port1,port2,port3** format.
            /// </summary>
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public string Ports { get; set; }

            /// <summary>
            /// The city code of the protected cluster.
            /// 
            /// >  For more information about city codes, see City codes in this topic.
            /// </summary>
            [NameInMap("RegionCodeValue")]
            [Validation(Required=false)]
            public int? RegionCodeValue { get; set; }

            /// <summary>
            /// The description of the node group.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
