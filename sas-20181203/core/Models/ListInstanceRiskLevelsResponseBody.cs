// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInstanceRiskLevelsResponseBody : TeaModel {
        /// <summary>
        /// The risk levels of instances.
        /// </summary>
        [NameInMap("InstanceRiskLevels")]
        [Validation(Required=false)]
        public List<ListInstanceRiskLevelsResponseBodyInstanceRiskLevels> InstanceRiskLevels { get; set; }
        public class ListInstanceRiskLevelsResponseBodyInstanceRiskLevels : TeaModel {
            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The risk level. Valid values:
            /// 
            /// *   **high**
            /// *   **medium**
            /// *   **low**
            /// *   **none**
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The UUID of the server for which you want to modify the defense rule. You can call the [DescribeCloudCenterInstances](~~141932~~) operation to query the UUIDs of servers.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
