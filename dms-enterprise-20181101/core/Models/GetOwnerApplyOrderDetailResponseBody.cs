// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetOwnerApplyOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The details of the ticket.
        /// </summary>
        [NameInMap("OwnerApplyOrderDetail")]
        [Validation(Required=false)]
        public GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetail OwnerApplyOrderDetail { get; set; }
        public class GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetail : TeaModel {
            /// <summary>
            /// The type of the submitted ticket. Valid values:
            /// 
            /// *   **INSTANCE**: the ticket that applies for the permissions to be an instance owner
            /// *   **DB**: the ticket that applies for the permissions to be a database owner
            /// *   **TABLE**: the ticket that applies for the permissions to be a table owner
            /// </summary>
            [NameInMap("ApplyType")]
            [Validation(Required=false)]
            public string ApplyType { get; set; }

            /// <summary>
            /// The details of the requested resource.
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetailResources> Resources { get; set; }
            public class GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetailResources : TeaModel {
                /// <summary>
                /// Indicates whether the database is a logical database. Valid values:
                /// 
                /// *   **true**: The instance is a logical database.
                /// *   **false**: The instance is not a logical database.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The details of the resource.
                /// </summary>
                [NameInMap("ResourceDetail")]
                [Validation(Required=false)]
                public GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetailResourcesResourceDetail ResourceDetail { get; set; }
                public class GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetailResourcesResourceDetail : TeaModel {
                    /// <summary>
                    /// The type of the database engine.
                    /// </summary>
                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    /// <summary>
                    /// The type of the environment to which the instance belongs. For more information, see [Change the environment type of an instance](https://help.aliyun.com/document_detail/163309.html).
                    /// </summary>
                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// The IDs of the original owners.
                    /// </summary>
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<long?> OwnerIds { get; set; }

                    /// <summary>
                    /// The nicknames of the owners.
                    /// </summary>
                    [NameInMap("OwnerNickNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNickNames { get; set; }

                    /// <summary>
                    /// The search name of the resource.
                    /// </summary>
                    [NameInMap("SearchName")]
                    [Validation(Required=false)]
                    public string SearchName { get; set; }

                    /// <summary>
                    /// The name of the table.
                    /// 
                    /// > : This parameter is returned when you submit a Database-OWNER ticket.
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                /// <summary>
                /// The ID of the resource.
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public string TargetId { get; set; }

            }

        }

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
