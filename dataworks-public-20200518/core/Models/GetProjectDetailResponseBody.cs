// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetProjectDetailResponseBody : TeaModel {
        /// <summary>
        /// The information about the workspace.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetProjectDetailResponseBodyData Data { get; set; }
        public class GetProjectDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The identifier of the shared resource group for Data Integration on which nodes are run.
            /// </summary>
            [NameInMap("DefaultDiResourceGroupIdentifier")]
            [Validation(Required=false)]
            public string DefaultDiResourceGroupIdentifier { get; set; }

            /// <summary>
            /// The development type of the workspace. The value is fixed to 4.
            /// </summary>
            [NameInMap("DevelopmentType")]
            [Validation(Required=false)]
            public int? DevelopmentType { get; set; }

            /// <summary>
            /// Indicates whether the Develop role is disabled. Valid values:
            /// 
            /// *   **false** (default)
            /// *   **true**
            /// </summary>
            [NameInMap("DisableDevelopment")]
            [Validation(Required=false)]
            public bool? DisableDevelopment { get; set; }

            /// <summary>
            /// The environments of workspaces in different modes. Workspaces in basic mode provide only the production environment. Workspaces in standard mode provide both the development environment and the production environment.
            /// </summary>
            [NameInMap("EnvTypes")]
            [Validation(Required=false)]
            public List<string> EnvTypes { get; set; }

            /// <summary>
            /// The time when the workspace was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the workspace was last modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// Indicates whether the download operation is allowed.
            /// </summary>
            [NameInMap("IsAllowDownload")]
            [Validation(Required=false)]
            public int? IsAllowDownload { get; set; }

            /// <summary>
            /// Indicates whether the workspace is a default workspace. Valid values:
            /// 
            /// *   1: The workspace is a default workspace.
            /// *   0: The workspace is not a default workspace.
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public int? IsDefault { get; set; }

            /// <summary>
            /// The description of the workspace.
            /// </summary>
            [NameInMap("ProjectDescription")]
            [Validation(Required=false)]
            public string ProjectDescription { get; set; }

            /// <summary>
            /// The workspace ID.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public int? ProjectId { get; set; }

            /// <summary>
            /// The unique identifier of the workspace.
            /// </summary>
            [NameInMap("ProjectIdentifier")]
            [Validation(Required=false)]
            public string ProjectIdentifier { get; set; }

            /// <summary>
            /// The mode of the workspace. The value 2 indicates that the workspace is in basic mode. The value 3 indicates that the workspace is in standard mode.
            /// </summary>
            [NameInMap("ProjectMode")]
            [Validation(Required=false)]
            public int? ProjectMode { get; set; }

            /// <summary>
            /// The display name of the workspace.
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account used by the workspace owner.
            /// </summary>
            [NameInMap("ProjectOwnerBaseId")]
            [Validation(Required=false)]
            public string ProjectOwnerBaseId { get; set; }

            /// <summary>
            /// Indicates whether the workspace protection feature is enabled.
            /// </summary>
            [NameInMap("ProtectedMode")]
            [Validation(Required=false)]
            public int? ProtectedMode { get; set; }

            /// <summary>
            /// The type of the workspace. Valid values: private and swap.
            /// </summary>
            [NameInMap("ResidentArea")]
            [Validation(Required=false)]
            public string ResidentArea { get; set; }

            /// <summary>
            /// The resource group ID.
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// The default maximum number of automatic reruns that are allowed after an error occurs.
            /// </summary>
            [NameInMap("SchedulerMaxRetryTimes")]
            [Validation(Required=false)]
            public int? SchedulerMaxRetryTimes { get; set; }

            /// <summary>
            /// The interval between automatic reruns after an error occurs.
            /// </summary>
            [NameInMap("SchedulerRetryInterval")]
            [Validation(Required=false)]
            public int? SchedulerRetryInterval { get; set; }

            /// <summary>
            /// The status of the workspace.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// Indicates whether the MaxCompute tables in the workspace are visible to the users within a tenant. Valid values:
            /// 
            /// *   0: The MaxCompute tables in the workspace are not visible to the users within a tenant.
            /// *   1: The MaxCompute tables in the workspace are visible to the users within a tenant.
            /// </summary>
            [NameInMap("TablePrivacyMode")]
            [Validation(Required=false)]
            public int? TablePrivacyMode { get; set; }

            /// <summary>
            /// The tag information.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetProjectDetailResponseBodyDataTags> Tags { get; set; }
            public class GetProjectDetailResponseBodyDataTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The tenant ID.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// Indicates whether a proxy account is used to access the MaxCompute compute engine.
            /// </summary>
            [NameInMap("UseProxyOdpsAccount")]
            [Validation(Required=false)]
            public bool? UseProxyOdpsAccount { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
