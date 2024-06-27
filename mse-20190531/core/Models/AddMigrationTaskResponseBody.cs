// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddMigrationTaskResponseBody : TeaModel {
        /// <summary>
        /// The data structure.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddMigrationTaskResponseBodyData Data { get; set; }
        public class AddMigrationTaskResponseBodyData : TeaModel {
            /// <summary>
            /// The type of the instance. Valid values:
            /// 
            /// *   Nacos-Ans
            /// *   ZooKeeper
            /// *   Eureka
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The endpoint of the source instance node.
            /// </summary>
            [NameInMap("OriginInstanceAddress")]
            [Validation(Required=false)]
            public string OriginInstanceAddress { get; set; }

            /// <summary>
            /// The name of the source instance.
            /// </summary>
            [NameInMap("OriginInstanceName")]
            [Validation(Required=false)]
            public string OriginInstanceName { get; set; }

            /// <summary>
            /// The list of namespaces. This parameter is optional if applications are migrated from a Nacos instance.
            /// </summary>
            [NameInMap("OriginInstanceNamespace")]
            [Validation(Required=false)]
            public string OriginInstanceNamespace { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("ProjectDesc")]
            [Validation(Required=false)]
            public string ProjectDesc { get; set; }

            [NameInMap("SyncType")]
            [Validation(Required=false)]
            public string SyncType { get; set; }

            /// <summary>
            /// The name of the destination instance.
            /// </summary>
            [NameInMap("TargetClusterName")]
            [Validation(Required=false)]
            public string TargetClusterName { get; set; }

            /// <summary>
            /// The URL of the destination instance.
            /// </summary>
            [NameInMap("TargetClusterUrl")]
            [Validation(Required=false)]
            public string TargetClusterUrl { get; set; }

            /// <summary>
            /// The ID of the destination instance.
            /// </summary>
            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

            /// <summary>
            /// The ID of the user.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
