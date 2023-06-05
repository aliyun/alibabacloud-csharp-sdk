// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetProjectResponseBody : TeaModel {
        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetProjectResponseBodyData Data { get; set; }
        public class GetProjectResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the workspace is a default workspace. Valid values:
            /// 
            /// *   1: The workspace is a default workspace.
            /// *   0: The workspace is not a default workspace.
            /// </summary>
            [NameInMap("Appkey")]
            [Validation(Required=false)]
            public string Appkey { get; set; }

            /// <summary>
            /// The time when the workspace was created. Example: Dec 3, 2019 9:12:20 PM.
            /// </summary>
            [NameInMap("BaseProject")]
            [Validation(Required=false)]
            public bool? BaseProject { get; set; }

            [NameInMap("DefaultDiResourceGroupIdentifier")]
            [Validation(Required=false)]
            public string DefaultDiResourceGroupIdentifier { get; set; }

            /// <summary>
            /// The unique identifier of the workspace.
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
            /// The default maximum number of automatic reruns that are allowed after an error occurs.
            /// </summary>
            [NameInMap("DevelopmentType")]
            [Validation(Required=false)]
            public int? DevelopmentType { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("DisableDevelopment")]
            [Validation(Required=false)]
            public bool? DisableDevelopment { get; set; }

            /// <summary>
            /// The list of tags.
            /// 
            /// The tags are added to resources in the workspace and used for authentication and cost allocation.
            /// </summary>
            [NameInMap("EnvTypes")]
            [Validation(Required=false)]
            public List<string> EnvTypes { get; set; }

            /// <summary>
            /// The environment of the workspace. Valid values: PROD and DEV.
            /// 
            /// *   The value PROD indicates the production environment. Workspaces in basic mode provide only the production environment.
            /// *   The value DEV indicates the development environment. Workspaces in standard mode provide both the development environment and the production environment.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The description of the workspace.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The time when the workspace was last modified. Example: Dec 3, 2019 9:12:20 PM.
            /// </summary>
            [NameInMap("IsAllowDownload")]
            [Validation(Required=false)]
            public int? IsAllowDownload { get; set; }

            /// <summary>
            /// The display name of the workspace.
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public int? IsDefault { get; set; }

            /// <summary>
            /// Indicates whether you are allowed to download the query result from DataStudio. Valid values:
            /// 
            /// *   1: You are allowed to download the query result from DataStudio.
            /// *   0: You are not allowed to download the query result from DataStudio.
            /// </summary>
            [NameInMap("MaxFlowNode")]
            [Validation(Required=false)]
            public int? MaxFlowNode { get; set; }

            /// <summary>
            /// The development type of the workspace. The value is fixed as 4. This parameter is deprecated.
            /// </summary>
            [NameInMap("ProdStorageQuota")]
            [Validation(Required=false)]
            public string ProdStorageQuota { get; set; }

            /// <summary>
            /// Indicates whether the MaxCompute tables in the workspace are visible to the users within a tenant. Valid values:
            /// 
            /// *   0: The MaxCompute tables are invisible to the users within a tenant.
            /// *   1: The MaxCompute tables are visible to the users within a tenant.
            /// </summary>
            [NameInMap("ProjectDescription")]
            [Validation(Required=false)]
            public string ProjectDescription { get; set; }

            /// <summary>
            /// The mode of the workspace. Valid values:
            /// 
            /// *   2: The workspace is in basic mode.
            /// *   3: The workspace is in standard mode.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public int? ProjectId { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account used by the workspace owner.
            /// </summary>
            [NameInMap("ProjectIdentifier")]
            [Validation(Required=false)]
            public string ProjectIdentifier { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("ProjectMode")]
            [Validation(Required=false)]
            public int? ProjectMode { get; set; }

            /// <summary>
            /// Indicates whether the Development role is disabled. Valid values:
            /// 
            /// *   false: The Development role is enabled.
            /// *   true: The Development role is disabled.
            /// 
            /// <!---->
            /// 
            /// *   Default value: false.
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// Indicates whether a proxy account is used to access the MaxCompute compute engine instance associated with the workspace.
            /// </summary>
            [NameInMap("ProjectOwnerBaseId")]
            [Validation(Required=false)]
            public string ProjectOwnerBaseId { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("ProtectedMode")]
            [Validation(Required=false)]
            public int? ProtectedMode { get; set; }

            [NameInMap("ResidentArea")]
            [Validation(Required=false)]
            public string ResidentArea { get; set; }

            /// <summary>
            /// The keys of the tags that are added to resources in the workspace. The tag keys must meet the following conditions:
            /// 
            /// *   The number of tag keys that can be added to resources ranges from 1 to 20.
            /// *   Each tag key can be a maximum of 128 characters in length.
            /// *   The tag keys cannot start with acs: or aliyun:.
            /// *   The tag keys cannot contain http:// or https://.
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// The interval between automatic reruns after an error occurs. Unit: milliseconds. The maximum interval is 30 minutes. You must pay attention to the conversion between units.
            /// </summary>
            [NameInMap("SchedulerMaxRetryTimes")]
            [Validation(Required=false)]
            public int? SchedulerMaxRetryTimes { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("SchedulerRetryInterval")]
            [Validation(Required=false)]
            public int? SchedulerRetryInterval { get; set; }

            /// <summary>
            /// The ID of the workspace.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// Indicates whether the workspace protection feature is enabled. Valid values:
            /// 
            /// *   1: The workspace protection feature is enabled.
            /// *   0: The workspace protection feature is disabled.
            /// </summary>
            [NameInMap("TablePrivacyMode")]
            [Validation(Required=false)]
            public int? TablePrivacyMode { get; set; }

            /// <summary>
            /// The values of the tags that are added to resources in the workspace. The tag values must meet the following conditions:
            /// 
            /// *   The number of tag values that can be added to resources ranges from 1 to 20.
            /// *   Each tag value can be a maximum of 128 characters in length.
            /// *   The tag values cannot start with acs:.
            /// *   The tag values cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetProjectResponseBodyDataTags> Tags { get; set; }
            public class GetProjectResponseBodyDataTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the resource group used in the workspace.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// The ID of the tenant.
            /// </summary>
            [NameInMap("UseProxyOdpsAccount")]
            [Validation(Required=false)]
            public bool? UseProxyOdpsAccount { get; set; }

        }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The description of the workspace.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the workspace. Valid values:
        /// 
        /// *   AVAILABLE(0): The workspace is in a normal state.
        /// *   DELETED(1): The workspace is deleted.
        /// *   INITIALIZING(2): The workspace is being initialized.
        /// *   INIT_FAILED(3): The workspace fails to be initialized.
        /// *   FORBIDDEN(4): The workspace is manually disabled.
        /// *   DELETING(5): The workspace is being deleted.
        /// *   DEL_FAILED(6): The workspace fails to be deleted.
        /// *   FROZEN(7): The workspace is frozen due to overdue payments.
        /// *   UPDATING(8): The workspace is being updated. The workspace enters this state after you associate a new compute engine with the workspace and the compute engine is being initialized.
        /// *   UPDATE_FAILED(9): The workspace fails to be updated.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
