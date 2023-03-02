// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetQualityEntityResponseBody : TeaModel {
        /// <summary>
        /// The information about the partition filter expression.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetQualityEntityResponseBodyData> Data { get; set; }
        public class GetQualityEntityResponseBodyData : TeaModel {
            /// <summary>
            /// The time when the partition filter expression was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The level of the partition filter expression. Valid values:
            /// 
            /// *   0: The partition filter expression is at the SQL level. This indicates that the system checks data quality after each SQL statement is executed.
            /// *   1: The partition filter expression is at the node level. This indicates that the system checks data quality after all the SQL statements for a node are executed.
            /// </summary>
            [NameInMap("EntityLevel")]
            [Validation(Required=false)]
            public int? EntityLevel { get; set; }

            /// <summary>
            /// The type of the compute engine instance or data source.
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to receive alert notifications.
            /// </summary>
            [NameInMap("Followers")]
            [Validation(Required=false)]
            public string Followers { get; set; }

            /// <summary>
            /// Indicates whether the partition filter expression is associated with a node. Valid values:
            /// 
            /// *   true: The partition filter expression is associated with a node.
            /// *   false: The partition filter expression is not associated with a node.
            /// </summary>
            [NameInMap("HasRelativeNode")]
            [Validation(Required=false)]
            public bool? HasRelativeNode { get; set; }

            /// <summary>
            /// The ID of the partition filter expression.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The partition filter expression.
            /// </summary>
            [NameInMap("MatchExpression")]
            [Validation(Required=false)]
            public string MatchExpression { get; set; }

            /// <summary>
            /// The time when the partition filter expression was modified.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to modify the partition filter expression.
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to configure the partition filter expression.
            /// </summary>
            [NameInMap("OnDuty")]
            [Validation(Required=false)]
            public string OnDuty { get; set; }

            /// <summary>
            /// The name of the Alibaba Cloud account that is used to configure the partition filter expression.
            /// </summary>
            [NameInMap("OnDutyAccountName")]
            [Validation(Required=false)]
            public string OnDutyAccountName { get; set; }

            /// <summary>
            /// The name of the compute engine instance or data source.
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// The information about the node with which the partition filter expression is associated. The information includes the following items:
            /// 
            /// *   ProjectName: the name of the workspace to which the node belongs.
            /// *   NodeID: the ID of the node.
            /// </summary>
            [NameInMap("RelativeNode")]
            [Validation(Required=false)]
            public string RelativeNode { get; set; }

            /// <summary>
            /// Indicates that the partition filter expression is at the SQL level.
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public int? Sql { get; set; }

            /// <summary>
            /// The name of the partitioned table.
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// The node.
            /// </summary>
            [NameInMap("Task")]
            [Validation(Required=false)]
            public int? Task { get; set; }

        }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
