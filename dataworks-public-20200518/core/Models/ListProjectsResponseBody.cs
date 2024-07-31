// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectsResponseBody : TeaModel {
        /// <summary>
        /// The results that are returned.
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListProjectsResponseBodyPageResult PageResult { get; set; }
        public class ListProjectsResponseBodyPageResult : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page. Default value: 10. Maximum value: 100.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The DataWorks workspaces.
            /// </summary>
            [NameInMap("ProjectList")]
            [Validation(Required=false)]
            public List<ListProjectsResponseBodyPageResultProjectList> ProjectList { get; set; }
            public class ListProjectsResponseBodyPageResultProjectList : TeaModel {
                /// <summary>
                /// Indicates whether the Development role is disabled. Valid values:
                /// 
                /// *   **false**: enabled
                /// *   **true**: disabled
                /// </summary>
                [NameInMap("DisableDevelopment")]
                [Validation(Required=false)]
                public bool? DisableDevelopment { get; set; }

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
                public long? ProjectId { get; set; }

                /// <summary>
                /// The name of the workspace.
                /// </summary>
                [NameInMap("ProjectIdentifier")]
                [Validation(Required=false)]
                public string ProjectIdentifier { get; set; }

                /// <summary>
                /// The display name of the workspace.
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// The ID of the user used by the workspace owner.
                /// </summary>
                [NameInMap("ProjectOwnerBaseId")]
                [Validation(Required=false)]
                public string ProjectOwnerBaseId { get; set; }

                /// <summary>
                /// The status of the workspace. Valid values:
                /// 
                /// *   0: AVAILABLE, which indicates that the workspace is running as expected.
                /// *   1: DELETED, which indicates that the workspace is deleted.
                /// *   2: INITIALIZING, which indicates that the workspace is being initialized.
                /// *   3: INIT_FAILED, which indicates that the workspace fails to be initialized.
                /// *   4: FORBIDDEN, which indicates that the workspace is manually disabled.
                /// *   5: DELETING, which indicates that the workspace is being deleted.
                /// *   6: DEL_FAILED, which indicates that the workspace fails to be deleted.
                /// *   7: FROZEN, which indicates that the workspace is frozen due to overdue payments.
                /// *   8: UPDATING, which indicates that the workspace is being updated. After you associate a compute engine with the workspace, the system initializes the compute engine and updates the workspace.
                /// *   9: UPDATE_FAILED, which indicates that the workspace fails to be updated.
                /// </summary>
                [NameInMap("ProjectStatus")]
                [Validation(Required=false)]
                public int? ProjectStatus { get; set; }

                /// <summary>
                /// The status code of the workspace. Valid values:
                /// 
                /// *   AVAILABLE: 0, which indicates that the workspace is running as expected.
                /// *   DELETED: 1, which indicates that the workspace is deleted.
                /// *   INITIALIZING: 2, which indicates that the workspace is being initialized.
                /// *   INIT_FAILED: 3, which indicates that the workspace fails to be initialized.
                /// *   FORBIDDEN: 4, which indicates that the workspace is manually disabled.
                /// *   DELETING: 5, which indicates that the workspace is being deleted.
                /// *   DEL_FAILED: 6, which indicates that the workspace fails to be deleted.
                /// *   FROZEN: 7, which indicates that the workspace is frozen due to overdue payments.
                /// *   UPDATING: 8, which indicates that the workspace is being updated. After you associate a compute engine with the workspace, the system initializes the compute engine and updates the workspace.
                /// *   UPDATE_FAILED: 9, which indicates that the workspace fails to be updated.
                /// </summary>
                [NameInMap("ProjectStatusCode")]
                [Validation(Required=false)]
                public string ProjectStatusCode { get; set; }

                /// <summary>
                /// The resource group ID.
                /// </summary>
                [NameInMap("ResourceManagerResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceManagerResourceGroupId { get; set; }

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
                public List<ListProjectsResponseBodyPageResultProjectListTags> Tags { get; set; }
                public class ListProjectsResponseBodyPageResultProjectListTags : TeaModel {
                    /// <summary>
                    /// The key of tag N added to the workspace.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of tag N added to the workspace.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// Indicates whether a proxy account is used to access the MaxCompute compute engine associated with the workspace. Valid values:
                /// 
                /// *   **false**
                /// *   **true**
                /// </summary>
                [NameInMap("UseProxyOdpsAccount")]
                [Validation(Required=false)]
                public bool? UseProxyOdpsAccount { get; set; }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
