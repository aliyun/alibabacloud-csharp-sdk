// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetProjectResponseBody : TeaModel {
        /// <summary>
        /// The information about the workspace.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetProjectResponseBodyData Data { get; set; }
        public class GetProjectResponseBodyData : TeaModel {
            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("Appkey")]
            [Validation(Required=false)]
            public string Appkey { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("BaseProject")]
            [Validation(Required=false)]
            public bool? BaseProject { get; set; }

            /// <summary>
            /// The ID of the resource group that was allocated by default when you purchased an exclusive resource group for MaxCompute.
            /// </summary>
            [NameInMap("DefaultDiResourceGroupIdentifier")]
            [Validation(Required=false)]
            public string DefaultDiResourceGroupIdentifier { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("Destination")]
            [Validation(Required=false)]
            public int? Destination { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("DevStorageQuota")]
            [Validation(Required=false)]
            public string DevStorageQuota { get; set; }

            /// <summary>
            /// This parameter is deprecated.
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
            /// The environment information of the workspace.
            /// </summary>
            [NameInMap("EnvTypes")]
            [Validation(Required=false)]
            public List<string> EnvTypes { get; set; }

            /// <summary>
            /// The time when the workspace was created. Example: `Dec 3, 2019 9:12:20 PM`.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the workspace was last modified. Example: `Dec 3, 2019 9:12:20 PM`.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// Indicates whether you are allowed to download the query result from DataStudio. Valid values:
            /// 
            /// *   **1**: You are allowed to download the query result from DataStudio.
            /// *   **0**: You are not allowed to download the query result from DataStudio.
            /// </summary>
            [NameInMap("IsAllowDownload")]
            [Validation(Required=false)]
            public int? IsAllowDownload { get; set; }

            /// <summary>
            /// Indicates whether the workspace is a default workspace. Valid values:
            /// 
            /// *   **1**: The workspace is a default workspace.
            /// *   **0**: The workspace is not a default workspace.
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public int? IsDefault { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("MaxFlowNode")]
            [Validation(Required=false)]
            public int? MaxFlowNode { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("ProdStorageQuota")]
            [Validation(Required=false)]
            public string ProdStorageQuota { get; set; }

            /// <summary>
            /// The description of the workspace.
            /// </summary>
            [NameInMap("ProjectDescription")]
            [Validation(Required=false)]
            public string ProjectDescription { get; set; }

            /// <summary>
            /// The ID of the workspace.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public int? ProjectId { get; set; }

            /// <summary>
            /// The name of the workspace.
            /// </summary>
            [NameInMap("ProjectIdentifier")]
            [Validation(Required=false)]
            public string ProjectIdentifier { get; set; }

            /// <summary>
            /// The mode of the workspace. Valid values:
            /// 
            /// *   **2**: The workspace is in basic mode.
            /// *   **3**: The workspace is in standard mode.
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
            /// Indicates whether the workspace protection feature is enabled. Valid values:
            /// 
            /// *   **1**: enabled
            /// *   **0**: disabled
            /// </summary>
            [NameInMap("ProtectedMode")]
            [Validation(Required=false)]
            public int? ProtectedMode { get; set; }

            /// <summary>
            /// The type of the workspace. Valid values:
            /// 
            /// *   **private**
            /// *   **swap**
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
            /// The default interval between automatic reruns after an error occurs. Unit: milliseconds. The maximum interval is 30 minutes. You must pay attention to the conversion between units.
            /// </summary>
            [NameInMap("SchedulerRetryInterval")]
            [Validation(Required=false)]
            public int? SchedulerRetryInterval { get; set; }

            /// <summary>
            /// The status of the workspace. Valid values:
            /// 
            /// *   **0**: AVAILABLE, which indicates that the workspace runs as expected.
            /// *   **1**: DELETED, which indicates that the workspace is deleted.
            /// *   **2**: INITIALIZING, which indicates that the workspace is being initialized.
            /// *   **3**: INIT_FAILED, which indicates that the workspace fails to be initialized.
            /// *   **4**: FORBIDDEN, which indicates that the workspace is manually disabled.
            /// *   **5**: DELETING, which indicates that the workspace is being deleted.
            /// *   **6**: DEL_FAILED, which indicates that the workspace fails to be deleted.
            /// *   **7**: FROZEN, which indicates that the workspace is frozen due to overdue payments.
            /// *   **8**: UPDATING, which indicates that the workspace is being updated. The workspace enters this state after you associate a new compute engine with the workspace and the compute engine is initialized.
            /// *   **9**: UPDATE_FAILED, which indicates that the workspace fails to be updated.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// Indicates whether the MaxCompute tables in the workspace are visible to the users within a tenant. Valid values:
            /// 
            /// *   **0**: invisible
            /// *   **1**: visible
            /// </summary>
            [NameInMap("TablePrivacyMode")]
            [Validation(Required=false)]
            public int? TablePrivacyMode { get; set; }

            /// <summary>
            /// The tags added to the workspace.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetProjectResponseBodyDataTags> Tags { get; set; }
            public class GetProjectResponseBodyDataTags : TeaModel {
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
            /// Indicates whether a proxy account is used to access the MaxCompute compute engine associated with the workspace.
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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
