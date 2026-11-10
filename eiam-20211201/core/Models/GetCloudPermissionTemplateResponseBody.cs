// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetCloudPermissionTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The permission template.</para>
        /// </summary>
        [NameInMap("CloudPermissionTemplate")]
        [Validation(Required=false)]
        public GetCloudPermissionTemplateResponseBodyCloudPermissionTemplate CloudPermissionTemplate { get; set; }
        public class GetCloudPermissionTemplateResponseBodyCloudPermissionTemplate : TeaModel {
            /// <summary>
            /// <para>Specifies whether users are allowed to apply for the permission template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowRequest")]
            [Validation(Required=false)]
            public bool? AllowRequest { get; set; }

            /// <summary>
            /// <para>The applicable scope for applying for the permission template.</para>
            /// </summary>
            [NameInMap("ApplicableScope")]
            [Validation(Required=false)]
            public GetCloudPermissionTemplateResponseBodyCloudPermissionTemplateApplicableScope ApplicableScope { get; set; }
            public class GetCloudPermissionTemplateResponseBodyCloudPermissionTemplateApplicableScope : TeaModel {
                /// <summary>
                /// <para>The list of specified group IDs. This field is returned only when ScopeType is set to custom.</para>
                /// </summary>
                [NameInMap("GroupIds")]
                [Validation(Required=false)]
                public List<string> GroupIds { get; set; }

                /// <summary>
                /// <para>The list of specified organizational unit IDs. This field is returned only when ScopeType is set to custom.</para>
                /// </summary>
                [NameInMap("OrganizationalUnitIds")]
                [Validation(Required=false)]
                public List<string> OrganizationalUnitIds { get; set; }

                /// <summary>
                /// <para>The type of the applicable scope. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>global: Global.</description></item>
                /// <item><description>custom: Custom.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>global</para>
                /// </summary>
                [NameInMap("ScopeType")]
                [Validation(Required=false)]
                public string ScopeType { get; set; }

                /// <summary>
                /// <para>The list of specified user IDs. This field is returned only when ScopeType is set to custom.</para>
                /// </summary>
                [NameInMap("UserIds")]
                [Validation(Required=false)]
                public List<string> UserIds { get; set; }

            }

            /// <summary>
            /// <para>The ID of the cloud account to which the permission template belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca_01kq1us6frlbo3rr8m216vj3bkak2</para>
            /// </summary>
            [NameInMap("CloudAccountId")]
            [Validation(Required=false)]
            public string CloudAccountId { get; set; }

            /// <summary>
            /// <para>The information about the creator of the permission template.</para>
            /// </summary>
            [NameInMap("CloudPermissionTemplateCreator")]
            [Validation(Required=false)]
            public GetCloudPermissionTemplateResponseBodyCloudPermissionTemplateCloudPermissionTemplateCreator CloudPermissionTemplateCreator { get; set; }
            public class GetCloudPermissionTemplateResponseBodyCloudPermissionTemplateCloudPermissionTemplateCreator : TeaModel {
                /// <summary>
                /// <para>The identity identifier of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8645321</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>The type of the creator. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>idaas_admin: IDaaS administrator.</description></item>
                /// <item><description>idaas_user: IDaaS user.</description></item>
                /// </list>
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
            /// <para>The initialization result. This field is returned only when the status is init_failed.</para>
            /// </summary>
            [NameInMap("CloudPermissionTemplateInitResult")]
            [Validation(Required=false)]
            public GetCloudPermissionTemplateResponseBodyCloudPermissionTemplateCloudPermissionTemplateInitResult CloudPermissionTemplateInitResult { get; set; }
            public class GetCloudPermissionTemplateResponseBodyCloudPermissionTemplateCloudPermissionTemplateInitResult : TeaModel {
                /// <summary>
                /// <para>The error code returned when the initialization fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CloudPermissionTemplate.AsyncInitError</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message returned when the initialization fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>server error</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The initialization result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>success: The initialization succeeded.</description></item>
                /// <item><description>failed: The initialization failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

            /// <summary>
            /// <para>The name of the permission template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("CloudPermissionTemplateName")]
            [Validation(Required=false)]
            public string CloudPermissionTemplateName { get; set; }

            /// <summary>
            /// <para>The ID of the application that owns the exclusive template. This field is empty for shared templates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_01kexamplexxxx</para>
            /// </summary>
            [NameInMap("CloudPermissionTemplateOwnerId")]
            [Validation(Required=false)]
            public string CloudPermissionTemplateOwnerId { get; set; }

            /// <summary>
            /// <para>The owner type of the exclusive template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>application: M2M application.</description></item>
            /// <item><description>user: Human user.
            /// This field is empty for shared templates.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("CloudPermissionTemplateOwnerType")]
            [Validation(Required=false)]
            public string CloudPermissionTemplateOwnerType { get; set; }

            /// <summary>
            /// <para>The sharing mode of the permission template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>shared: Shared.</description></item>
            /// <item><description>exclusive: Exclusive.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>shared</para>
            /// </summary>
            [NameInMap("CloudPermissionTemplateSharingMode")]
            [Validation(Required=false)]
            public string CloudPermissionTemplateSharingMode { get; set; }

            /// <summary>
            /// <para>The usage type of the permission template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>user: Privilege escalation for human users.</description></item>
            /// <item><description>application: Privilege escalation for machine-to-machine (M2M) applications.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("CloudPermissionTemplateUsageType")]
            [Validation(Required=false)]
            public string CloudPermissionTemplateUsageType { get; set; }

            /// <summary>
            /// <para>The time when the permission template was created. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1776239357000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the permission template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is a test.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ki6hd7ihir4ybawogqk6kqsfjm</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The external unique identifier of the associated cloud role, which is the ARN of the role on the cloud provider side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::123456:role/idaas-test</para>
            /// </summary>
            [NameInMap("PermissionEntityExternalId")]
            [Validation(Required=false)]
            public string PermissionEntityExternalId { get; set; }

            /// <summary>
            /// <para>The ID of the associated CloudAccountRole.</para>
            /// 
            /// <b>Example:</b>
            /// <para>carole_01kmek49aqxxxx</para>
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
            /// <para>The status of the permission template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>initializing: The template is being initialized.</description></item>
            /// <item><description>init_failed: The template initialization failed.</description></item>
            /// <item><description>enabled: The template is enabled.</description></item>
            /// <item><description>disabled: The template is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the permission template was last updated. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1776239357000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
