// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateApprovalProcessRequest : TeaModel {
        /// <summary>
        /// <para>The approval type. Valid values: 0 (built-in approval), 1 (DingTalk approval), 2 (WeCom approval), and 3 (Lark approval). Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ApprovalType")]
        [Validation(Required=false)]
        public int? ApprovalType { get; set; }

        /// <summary>
        /// <para>The description of the approval process. The description must be 1 to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office endpoint software installation and uninstallation approval process</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The event callback identifier. When the approval type is 1 (DingTalk approval) or 3 (Lark approval), this parameter is used to generate the event callback URL for the external platform. You can pass a complete callback URL, and the server retains only the part after the callback path prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://callback.example.com/sase/api/v1/approval/dingtalk/callback/9m4e2mr0ui3e8a21">https://callback.example.com/sase/api/v1/approval/dingtalk/callback/9m4e2mr0ui3e8a21</a>****</para>
        /// </summary>
        [NameInMap("EventLabel")]
        [Validation(Required=false)]
        public string EventLabel { get; set; }

        /// <summary>
        /// <para>The integration configuration for the external approval platform. This parameter is required when the approval type is 1 (DingTalk approval) or 3 (Lark approval). It includes integration parameters such as appKey and appSecret, and must be passed as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;appKey&quot;:&quot;dingn1a2b3c4d5e6f****&quot;,&quot;appSecret&quot;:&quot;f9c8e7d6a5b4c3d2e1f0a9b8c7d6e5f4a3b2c1d0e9f8a7b6c5d4e3f2a1b0****&quot;,&quot;eventVerifyToken&quot;:&quot;7a8b9c0d1e2f3a4b5c6d7e8f9a0b****&quot;,&quot;eventAesKey&quot;:&quot;1a2b3c4d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t****&quot;}</para>
        /// </summary>
        [NameInMap("ExternalConfig")]
        [Validation(Required=false)]
        public string ExternalConfig { get; set; }

        /// <summary>
        /// <para>The external approval template configurations. Configure the approval template ID, external approval process ID, and field mappings based on the policy type. This parameter is used only when ApprovalType is set to 1 (DingTalk approval), 2 (WeCom approval), or 3 (Lark approval). If this parameter is not passed, the existing template associations of the approval process are cleared. The approval templates associated with business policies cannot be cleared.</para>
        /// </summary>
        [NameInMap("MatchSchemaConfigs")]
        [Validation(Required=false)]
        public UpdateApprovalProcessRequestMatchSchemaConfigs MatchSchemaConfigs { get; set; }
        public class UpdateApprovalProcessRequestMatchSchemaConfigs : TeaModel {
            /// <summary>
            /// <para>The approval template configuration for the application uninstallation policy.</para>
            /// </summary>
            [NameInMap("AppUninstallSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsAppUninstallSchemaConfig AppUninstallSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsAppUninstallSchemaConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. When the approval type is 1 (DingTalk approval) or 3 (Lark approval), this parameter specifies the process code (processCode) of the external platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The mapping list between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsAppUninstallSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsAppUninstallSchemaConfigFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form. This parameter is used to locate the form control when the approval type is 1 (DingTalk approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Reason for reporting</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the external approval form control, in the format of Type%%%ControlID. This parameter is used to locate the form control when the approval type is 2 (WeCom approval) or 3 (Lark approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Textarea%%%widget-1a2b****</para>
                    /// </summary>
                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The identifier of the system field, such as approvalReason.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>approvalReason</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The ID of the approval template. The ID must be consistent with the template ID of the corresponding policy type in MatchSchemas. If this parameter is left empty, the approval template association is not saved for this policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The approval template configuration for the device registration policy.</para>
            /// </summary>
            [NameInMap("DeviceRegistrationSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsDeviceRegistrationSchemaConfig DeviceRegistrationSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsDeviceRegistrationSchemaConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. When the approval type is 1 (DingTalk approval) or 3 (Lark approval), this parameter specifies the process code (processCode) of the external platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The mapping list between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsDeviceRegistrationSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsDeviceRegistrationSchemaConfigFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form. This parameter is used to locate the form control when the approval type is 1 (DingTalk approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Report domain name</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the external approval form control, in the format of Type%%%ControlID. This parameter is used to locate the form control when the approval type is 2 (WeCom approval) or 3 (Lark approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Textarea%%%widget-1a2b****</para>
                    /// </summary>
                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The identifier of the system field, such as report_domain.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>report_domain</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The ID of the approval template. The ID must be consistent with the template ID of the corresponding policy type in MatchSchemas. If this parameter is left empty, the approval template association is not saved for this policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The approval template configuration for the file outbound sending policy.</para>
            /// </summary>
            [NameInMap("DlpSendSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsDlpSendSchemaConfig DlpSendSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsDlpSendSchemaConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. When the approval type is 1 (DingTalk approval) or 3 (Lark approval), this parameter specifies the process code (processCode) of the external platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The mapping list between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsDlpSendSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsDlpSendSchemaConfigFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form. This parameter is used to locate the form control when the approval type is 1 (DingTalk approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>File name</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the external approval form control, in the format of Type%%%ControlID. This parameter is used to locate the form control when the approval type is 2 (WeCom approval) or 3 (Lark approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Textarea%%%widget-1a2b****</para>
                    /// </summary>
                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The identifier of the system field, such as fileName.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fileName</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The ID of the approval template. The ID must be consistent with the template ID of the corresponding policy type in MatchSchemas. If this parameter is left empty, the approval template association is not saved for this policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The approval template configuration for the domain name blacklist policy.</para>
            /// </summary>
            [NameInMap("DomainBlacklistSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsDomainBlacklistSchemaConfig DomainBlacklistSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsDomainBlacklistSchemaConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. When the approval type is 1 (DingTalk approval) or 3 (Lark approval), this parameter specifies the process code (processCode) of the external platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The mapping list between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsDomainBlacklistSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsDomainBlacklistSchemaConfigFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form. This parameter is used to locate the form control when the approval type is 1 (DingTalk approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Report website access</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the external approval form control, in the format of Type%%%ControlID. This parameter is used to locate the form control when the approval type is 2 (WeCom approval) or 3 (Lark approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Textarea%%%widget-1a2b****</para>
                    /// </summary>
                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The identifier of the system field, such as reportDomain.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>reportDomain</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The ID of the approval template. The ID must be consistent with the template ID of the corresponding policy type in MatchSchemas. If this parameter is left empty, the approval template association is not saved for this policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The approval template configuration for the domain name whitelist policy.</para>
            /// </summary>
            [NameInMap("DomainWhitelistSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsDomainWhitelistSchemaConfig DomainWhitelistSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsDomainWhitelistSchemaConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. When the approval type is 1 (DingTalk approval) or 3 (Lark approval), this parameter specifies the process code (processCode) of the external platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The mapping list between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsDomainWhitelistSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsDomainWhitelistSchemaConfigFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form. This parameter is used to locate the form control when the approval type is 1 (DingTalk approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Report website access</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the external approval form control, in the format of Type%%%ControlID. This parameter is used to locate the form control when the approval type is 2 (WeCom approval) or 3 (Lark approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Textarea%%%widget-1a2b****</para>
                    /// </summary>
                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The identifier of the system field, such as reportDomain.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>reportDomain</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The ID of the approval template. The ID must be consistent with the template ID of the corresponding policy type in MatchSchemas. If this parameter is left empty, the approval template association is not saved for this policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The approval template configuration for the endpoint hardening policy.</para>
            /// </summary>
            [NameInMap("EndpointHardeningSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsEndpointHardeningSchemaConfig EndpointHardeningSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsEndpointHardeningSchemaConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. When the approval type is 1 (DingTalk approval) or 3 (Lark approval), this parameter specifies the process code (processCode) of the external platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The mapping list between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsEndpointHardeningSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsEndpointHardeningSchemaConfigFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form. This parameter is used to locate the form control when the approval type is 1 (DingTalk approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Process name</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the external approval form control, in the format of Type%%%ControlID. This parameter is used to locate the form control when the approval type is 2 (WeCom approval) or 3 (Lark approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Textarea%%%widget-1a2b****</para>
                    /// </summary>
                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field identifier, such as processName.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>processName</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The ID of the approval template. The ID must be consistent with the template ID of the corresponding policy type in MatchSchemas. If this parameter is left empty, the approval template association is not saved for this policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The approval template configuration for the peripheral control policy.</para>
            /// </summary>
            [NameInMap("PeripheralBlockSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsPeripheralBlockSchemaConfig PeripheralBlockSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsPeripheralBlockSchemaConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. When the approval type is 1 (DingTalk approval) or 3 (Lark approval), this parameter specifies the process code (processCode) of the external platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The mapping list between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsPeripheralBlockSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsPeripheralBlockSchemaConfigFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form. This parameter is used to locate the form control when the approval type is 1 (DingTalk approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Operating system</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the external approval form control, in the format of Type%%%ControlID. This parameter is used to locate the form control when the approval type is 2 (WeCom approval) or 3 (Lark approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Textarea%%%widget-1a2b****</para>
                    /// </summary>
                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The identifier of the system field, such as devType.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>devType</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The ID of the approval template. The ID must be consistent with the template ID of the corresponding policy type in MatchSchemas. If this parameter is left empty, the approval template association is not saved for this policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The approval template configuration for the internal network access control policy.</para>
            /// </summary>
            [NameInMap("PrivateAccessBlockSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsPrivateAccessBlockSchemaConfig PrivateAccessBlockSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsPrivateAccessBlockSchemaConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. When the approval type is 1 (DingTalk approval) or 3 (Lark approval), this parameter specifies the process code (processCode) of the external platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The mapping list between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsPrivateAccessBlockSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsPrivateAccessBlockSchemaConfigFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form. This parameter is used to locate the form control when the approval type is 1 (DingTalk approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Reported application</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the external approval form control, in the format of Type%%%ControlID. This parameter is used to locate the form control when the approval type is 2 (WeCom approval) or 3 (Lark approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Textarea%%%widget-1a2b****</para>
                    /// </summary>
                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field identifier, such as applicationId.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>applicationId</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The ID of the approval template. The ID must be consistent with the template ID of the corresponding policy type in MatchSchemas. If this parameter is left empty, the approval template association is not saved for this policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The approval template configuration for the software blocking policy.</para>
            /// </summary>
            [NameInMap("SoftwareBlockSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareBlockSchemaConfig SoftwareBlockSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareBlockSchemaConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. When the approval type is 1 (DingTalk approval) or 3 (Lark approval), this parameter specifies the process code (processCode) of the external platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The mapping list between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareBlockSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareBlockSchemaConfigFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form. This parameter is used to locate the form control when the approval type is 1 (DingTalk approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Report software</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the external approval form control, in the format of Type%%%ControlID. This parameter is used to locate the form control when the approval type is 2 (WeCom approval) or 3 (Lark approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Textarea%%%widget-1a2b****</para>
                    /// </summary>
                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The identifier of the system field, such as softwareName.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>softwareName</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The ID of the approval template. The ID must be consistent with the template ID of the corresponding policy type in MatchSchemas. If this parameter is left empty, the approval template association is not saved for this policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The approval template configuration for the software hardening policy.</para>
            /// </summary>
            [NameInMap("SoftwareHardeningSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareHardeningSchemaConfig SoftwareHardeningSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareHardeningSchemaConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. When the approval type is 1 (DingTalk approval) or 3 (Lark approval), this parameter specifies the process code (processCode) of the external platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The mapping list between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareHardeningSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareHardeningSchemaConfigFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form. This parameter is used to locate the form control when the approval type is 1 (DingTalk approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Process name</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the external approval form control, in the format of Type%%%ControlID. This parameter is used to locate the form control when the approval type is 2 (WeCom approval) or 3 (Lark approval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Textarea%%%widget-1a2b****</para>
                    /// </summary>
                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field identifier, such as processName.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>processName</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The ID of the approval template. The ID must be consistent with the template ID of the corresponding policy type in MatchSchemas. If this parameter is left empty, the approval template association is not saved for this policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

        }

        /// <summary>
        /// <para>The matched approval templates.</para>
        /// </summary>
        [NameInMap("MatchSchemas")]
        [Validation(Required=false)]
        public UpdateApprovalProcessRequestMatchSchemas MatchSchemas { get; set; }
        public class UpdateApprovalProcessRequestMatchSchemas : TeaModel {
            /// <summary>
            /// <para>The ID of the application uninstallation approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("AppUninstallSchemaId")]
            [Validation(Required=false)]
            public string AppUninstallSchemaId { get; set; }

            /// <summary>
            /// <para>The ID of the device registration approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("DeviceRegistrationSchemaId")]
            [Validation(Required=false)]
            public string DeviceRegistrationSchemaId { get; set; }

            /// <summary>
            /// <para>The ID of the file outbound sending approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("DlpSendSchemaId")]
            [Validation(Required=false)]
            public string DlpSendSchemaId { get; set; }

            /// <summary>
            /// <para>The ID of the domain name blacklist approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("DomainBlacklistSchemaId")]
            [Validation(Required=false)]
            public string DomainBlacklistSchemaId { get; set; }

            /// <summary>
            /// <para>The ID of the domain name whitelist approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("DomainWhitelistSchemaId")]
            [Validation(Required=false)]
            public string DomainWhitelistSchemaId { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint hardening approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("EndpointHardeningSchemaId")]
            [Validation(Required=false)]
            public string EndpointHardeningSchemaId { get; set; }

            /// <summary>
            /// <para>The ID of the peripheral control approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("PeripheralBlockSchemaId")]
            [Validation(Required=false)]
            public string PeripheralBlockSchemaId { get; set; }

            /// <summary>
            /// <para>The ID of the internal network access control approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("PrivateAccessBlockSchemaId")]
            [Validation(Required=false)]
            public string PrivateAccessBlockSchemaId { get; set; }

            /// <summary>
            /// <para>The ID of the software blocking approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("SoftwareBlockSchemaId")]
            [Validation(Required=false)]
            public string SoftwareBlockSchemaId { get; set; }

            /// <summary>
            /// <para>The ID of the software hardening approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("SoftwareHardeningSchemaId")]
            [Validation(Required=false)]
            public string SoftwareHardeningSchemaId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the approval process.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-process-f16bf74b2b29****</para>
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// <para>The name of the approval process. The name must be 1 to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Endpoint software installation approval process</para>
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// <para>The list of approval nodes. You can define up to 5 approval nodes.</para>
        /// </summary>
        [NameInMap("ProcessNodes")]
        [Validation(Required=false)]
        public List<List<string>> ProcessNodes { get; set; }

    }

}
