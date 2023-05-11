// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetEdgeInstanceResponseBody : TeaModel {
        /// <summary>
        /// The return code of the operation. A value of Success indicates that the call was successful. Other values indicate that specific errors occurred. For more information, see [Error codes](~~135200~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data that is returned if the call was successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEdgeInstanceResponseBodyData Data { get; set; }
        public class GetEdgeInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the edge instance was enabled. Valid values:
            /// 
            /// *   true: enabled
            /// *   false: disabled
            /// </summary>
            [NameInMap("BizEnable")]
            [Validation(Required=false)]
            public bool? BizEnable { get; set; }

            /// <summary>
            /// The time when the edge instance was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The UNIX timestamp when the edge instance was created.
            /// </summary>
            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=false)]
            public long? GmtCreateTimestamp { get; set; }

            /// <summary>
            /// The last time when the edge instance was updated.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The last UNIX timestamp when the edge instance was updated.
            /// </summary>
            [NameInMap("GmtModifiedTimestamp")]
            [Validation(Required=false)]
            public long? GmtModifiedTimestamp { get; set; }

            /// <summary>
            /// The ID of the edge instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The status of the latest deployment task. Valid values:
            /// 
            /// *   0: The task was not started.
            /// *   1: The task was being processed.
            /// *   2: The task was successful.
            /// *   3: The task failed.
            /// </summary>
            [NameInMap("LatestDeploymentStatus")]
            [Validation(Required=false)]
            public int? LatestDeploymentStatus { get; set; }

            /// <summary>
            /// The type of the latest deployment task. Valid values:
            /// 
            /// *   deploy: deploys the edge instance.
            /// *   reset: resets the edge instance.
            /// </summary>
            [NameInMap("LatestDeploymentType")]
            [Validation(Required=false)]
            public string LatestDeploymentType { get; set; }

            /// <summary>
            /// The name of the edge instance.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the RAM role.
            /// </summary>
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// The time when the RAM role was attached to IoT Platform.
            /// </summary>
            [NameInMap("RoleAttachTime")]
            [Validation(Required=false)]
            public string RoleAttachTime { get; set; }

            /// <summary>
            /// The UNIX timestamp when the RAM role was attached to IoT Platform.
            /// </summary>
            [NameInMap("RoleAttachTimestamp")]
            [Validation(Required=false)]
            public long? RoleAttachTimestamp { get; set; }

            /// <summary>
            /// The name of the RAM role.
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// The specifications of the edge instance. Valid values:
            /// 
            /// *   10: Lite Edition
            /// *   20: Standard Edition
            /// *   30: Pro Edition
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public int? Spec { get; set; }

            /// <summary>
            /// The tags of the edge instance. Each tag is a `key-value` pair. Multiple tags are separated with commas(,). Example: `k1:v1,k2:v2`.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// Indicates whether you own the edge instance or you are authorized to use the edge instance. Valid values:
            /// 
            /// *   0: You own the edge instance.
            /// *   1: You are authorized to use the edge instance.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The error message that is returned if the call failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. A value of true indicates that the call was successful. A value of false indicates that the call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
