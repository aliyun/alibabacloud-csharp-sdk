// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of entries returned.
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The workspaces.
        /// </summary>
        [NameInMap("workspaces")]
        [Validation(Required=false)]
        public List<ListWorkspacesResponseBodyWorkspaces> Workspaces { get; set; }
        public class ListWorkspacesResponseBodyWorkspaces : TeaModel {
            /// <summary>
            /// Indicates whether auto-renewal is enabled. This parameter is required only if the paymentType parameter is set to Subscription.
            /// </summary>
            [NameInMap("autoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// The auto-renewal duration. This parameter is required only if the paymentType parameter is set to Subscription.
            /// </summary>
            [NameInMap("autoRenewPeriod")]
            [Validation(Required=false)]
            public int? AutoRenewPeriod { get; set; }

            /// <summary>
            /// The unit of the auto-renewal duration. This parameter is required only if the paymentType parameter is set to Subscription.
            /// </summary>
            [NameInMap("autoRenewPeriodUnit")]
            [Validation(Required=false)]
            public string AutoRenewPeriodUnit { get; set; }

            /// <summary>
            /// The time when the workspace was created.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The information of the Data Lake Formation (DLF) catalog.
            /// </summary>
            [NameInMap("dlfCatalogId")]
            [Validation(Required=false)]
            public string DlfCatalogId { get; set; }

            [NameInMap("dlfType")]
            [Validation(Required=false)]
            public string DlfType { get; set; }

            /// <summary>
            /// The subscription period. This parameter is required only if the paymentType parameter is set to Subscription.
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// The time when the workspace was released.
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The reason for the failure.
            /// </summary>
            [NameInMap("failReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            /// <summary>
            /// The unit of the subscription duration. This parameter is required only if the paymentType parameter is set to Subscription.
            /// </summary>
            [NameInMap("paymentDurationUnit")]
            [Validation(Required=false)]
            public string PaymentDurationUnit { get; set; }

            /// <summary>
            /// The status of the payment.
            /// </summary>
            [NameInMap("paymentStatus")]
            [Validation(Required=false)]
            public string PaymentStatus { get; set; }

            /// <summary>
            /// The payment type.
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The reason why the workspace is released.
            /// </summary>
            [NameInMap("releaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// The resource specifications.
            /// </summary>
            [NameInMap("resourceSpec")]
            [Validation(Required=false)]
            public string ResourceSpec { get; set; }

            /// <summary>
            /// The information about the workspace status change.
            /// </summary>
            [NameInMap("stateChangeReason")]
            [Validation(Required=false)]
            public ListWorkspacesResponseBodyWorkspacesStateChangeReason StateChangeReason { get; set; }
            public class ListWorkspacesResponseBodyWorkspacesStateChangeReason : TeaModel {
                /// <summary>
                /// The error code.
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// The Object Storage Service (OSS) path.
            /// </summary>
            [NameInMap("storage")]
            [Validation(Required=false)]
            public string Storage { get; set; }

            /// <summary>
            /// The workspace ID.
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// The name of the workspace.
            /// </summary>
            [NameInMap("workspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

            /// <summary>
            /// The workspace status.
            /// </summary>
            [NameInMap("workspaceStatus")]
            [Validation(Required=false)]
            public string WorkspaceStatus { get; set; }

        }

    }

}
