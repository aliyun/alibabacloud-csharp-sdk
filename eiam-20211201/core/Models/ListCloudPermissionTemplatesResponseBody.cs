// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCloudPermissionTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cloud permission templates.</para>
        /// </summary>
        [NameInMap("CloudPermissionTemplates")]
        [Validation(Required=false)]
        public List<ListCloudPermissionTemplatesResponseBodyCloudPermissionTemplates> CloudPermissionTemplates { get; set; }
        public class ListCloudPermissionTemplatesResponseBodyCloudPermissionTemplates : TeaModel {
            /// <summary>
            /// <para>Specifies whether users are allowed to apply for the permission template.</para>
            /// </summary>
            [NameInMap("AllowRequest")]
            [Validation(Required=false)]
            public bool? AllowRequest { get; set; }

            /// <summary>
            /// <para>The applicable scope of the permission template.</para>
            /// </summary>
            [NameInMap("ApplicableScope")]
            [Validation(Required=false)]
            public ListCloudPermissionTemplatesResponseBodyCloudPermissionTemplatesApplicableScope ApplicableScope { get; set; }
            public class ListCloudPermissionTemplatesResponseBodyCloudPermissionTemplatesApplicableScope : TeaModel {
                /// <summary>
                /// <para>The list of specified group IDs. This parameter has a value only when ScopeType is set to custom.</para>
                /// </summary>
                [NameInMap("GroupIds")]
                [Validation(Required=false)]
                public List<string> GroupIds { get; set; }

                /// <summary>
                /// <para>The list of specified organizational unit IDs. This parameter has a value only when ScopeType is set to custom.</para>
                /// </summary>
                [NameInMap("OrganizationalUnitIds")]
                [Validation(Required=false)]
                public List<string> OrganizationalUnitIds { get; set; }

                /// <summary>
                /// <para>The type of the applicable scope. Valid values: global and custom.</para>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("ScopeType")]
                [Validation(Required=false)]
                public string ScopeType { get; set; }

                /// <summary>
                /// <para>The list of specified user IDs. This parameter has a value only when ScopeType is set to custom.</para>
                /// </summary>
                [NameInMap("UserIds")]
                [Validation(Required=false)]
                public List<string> UserIds { get; set; }

            }

            /// <summary>
            /// <para>The ID of the cloud account to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca_01kmegjc11qa1txxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountId")]
            [Validation(Required=false)]
            public string CloudAccountId { get; set; }

            /// <summary>
            /// <para>The creator information of the permission template.</para>
            /// </summary>
            [NameInMap("CloudPermissionTemplateCreator")]
            [Validation(Required=false)]
            public ListCloudPermissionTemplatesResponseBodyCloudPermissionTemplatesCloudPermissionTemplateCreator CloudPermissionTemplateCreator { get; set; }
            public class ListCloudPermissionTemplatesResponseBodyCloudPermissionTemplatesCloudPermissionTemplateCreator : TeaModel {
                /// <summary>
                /// <para>The identity identifier of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_01kmek49aq4r8gxxxx</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Doe</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>The type of the creator. Valid values: idaas_admin and idaas_user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>idaas_user</para>
                /// </summary>
                [NameInMap("CreatorType")]
                [Validation(Required=false)]
                public string CreatorType { get; set; }

            }

            /// <summary>
            /// <para>The unique identifier of the permission template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpt_01l8dagf2iablhigj75l1n99xxxxx</para>
            /// </summary>
            [NameInMap("CloudPermissionTemplateId")]
            [Validation(Required=false)]
            public string CloudPermissionTemplateId { get; set; }

            /// <summary>
            /// <para>The initialization result. This parameter is returned only when the status is init_failed.</para>
            /// </summary>
            [NameInMap("CloudPermissionTemplateInitResult")]
            [Validation(Required=false)]
            public ListCloudPermissionTemplatesResponseBodyCloudPermissionTemplatesCloudPermissionTemplateInitResult CloudPermissionTemplateInitResult { get; set; }
            public class ListCloudPermissionTemplatesResponseBodyCloudPermissionTemplatesCloudPermissionTemplateInitResult : TeaModel {
                /// <summary>
                /// <para>The error code returned when initialization fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CloudPermissionTemplate.AsyncInitError</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message returned when initialization fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Failed to initialize the permission template. Try again later</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The initialization result. Valid values: success and failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>failed</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

            /// <summary>
            /// <para>The name of the permission template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AdminAccessTemplate</para>
            /// </summary>
            [NameInMap("CloudPermissionTemplateName")]
            [Validation(Required=false)]
            public string CloudPermissionTemplateName { get; set; }

            /// <summary>
            /// <para>The ID of the application to which the exclusive template belongs. This parameter is empty for shared templates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_01kexamplexxxx</para>
            /// </summary>
            [NameInMap("CloudPermissionTemplateOwnerId")]
            [Validation(Required=false)]
            public string CloudPermissionTemplateOwnerId { get; set; }

            /// <summary>
            /// <para>The owner type of the exclusive template. Valid values: application (M2M applications) and user (human users). This parameter is empty for shared templates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("CloudPermissionTemplateOwnerType")]
            [Validation(Required=false)]
            public string CloudPermissionTemplateOwnerType { get; set; }

            /// <summary>
            /// <para>The sharing mode of the permission template. Valid values: shared and exclusive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>shared</para>
            /// </summary>
            [NameInMap("CloudPermissionTemplateSharingMode")]
            [Validation(Required=false)]
            public string CloudPermissionTemplateSharingMode { get; set; }

            /// <summary>
            /// <para>The usage type of the permission template. Valid values: user (privilege escalation for human users) and application (privilege escalation for M2M applications).</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("CloudPermissionTemplateUsageType")]
            [Validation(Required=false)]
            public string CloudPermissionTemplateUsageType { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830225000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the permission template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Administrator permission template for managing cloud accounts</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The external unique identifier of the associated cloud role, which is the role ARN on the cloud provider side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ReadOnlyAccess</para>
            /// </summary>
            [NameInMap("PermissionEntityExternalId")]
            [Validation(Required=false)]
            public string PermissionEntityExternalId { get; set; }

            /// <summary>
            /// <para>The ID of the associated CloudAccountRole.</para>
            /// 
            /// <b>Example:</b>
            /// <para>carole_01kmek49aq4r8gxxxx</para>
            /// </summary>
            [NameInMap("PermissionEntityId")]
            [Validation(Required=false)]
            public string PermissionEntityId { get; set; }

            /// <summary>
            /// <para>The type of the permission entity. Fixed value: cloud_account_role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_account_role</para>
            /// </summary>
            [NameInMap("PermissionEntityType")]
            [Validation(Required=false)]
            public string PermissionEntityType { get; set; }

            /// <summary>
            /// <para>The status of the permission template. Valid values: initializing, init_failed, enabled, and disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The last update time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830227000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries per page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token returned by the current call for subsequent queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
