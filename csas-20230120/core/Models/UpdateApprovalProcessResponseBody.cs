// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateApprovalProcessResponseBody : TeaModel {
        /// <summary>
        /// <para>The approval process.</para>
        /// </summary>
        [NameInMap("Process")]
        [Validation(Required=false)]
        public UpdateApprovalProcessResponseBodyProcess Process { get; set; }
        public class UpdateApprovalProcessResponseBodyProcess : TeaModel {
            /// <summary>
            /// <para>The list of policies associated with endpoint uninstallation.</para>
            /// </summary>
            [NameInMap("AppUninstallPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessAppUninstallPolicies AppUninstallPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessAppUninstallPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk) or 3 (Lark), the process code from the external approval platform is returned. For other approval types, an empty value is returned.</para>
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
                public List<UpdateApprovalProcessResponseBodyProcessAppUninstallPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessAppUninstallPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Reason for reporting</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the control in the external approval form. The value is in the Type%%%Control ID format.</para>
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
                /// <para>The list of endpoint uninstallation policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The ID of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The approval type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Built-in approval.</description></item>
            /// <item><description>1: DingTalk approval.</description></item>
            /// <item><description>2: WeCom approval.</description></item>
            /// <item><description>3: Lark approval.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ApprovalType")]
            [Validation(Required=false)]
            public int? ApprovalType { get; set; }

            /// <summary>
            /// <para>The time when the approval process was created. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-11 15:31:39</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office endpoint software installation and uninstallation approval process</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of policies associated with device registration.</para>
            /// </summary>
            [NameInMap("DeviceRegistrationPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessDeviceRegistrationPolicies DeviceRegistrationPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessDeviceRegistrationPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk) or 3 (Lark), the process code from the external approval platform is returned. For other approval types, an empty value is returned.</para>
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
                public List<UpdateApprovalProcessResponseBodyProcessDeviceRegistrationPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessDeviceRegistrationPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Report domain name</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the control in the external approval form. The value is in the Type%%%Control ID format.</para>
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
                /// <para>The list of device registration policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The ID of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The list of policies associated with outbound file transfer.</para>
            /// </summary>
            [NameInMap("DlpSendPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessDlpSendPolicies DlpSendPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessDlpSendPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk) or 3 (Lark), the process code from the external approval platform is returned. For other approval types, an empty value is returned.</para>
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
                public List<UpdateApprovalProcessResponseBodyProcessDlpSendPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessDlpSendPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>File name</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the control in the external approval form. The value is in the Type%%%Control ID format.</para>
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
                /// <para>The list of outbound file transfer policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The ID of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The list of policies associated with the domain name blacklist.</para>
            /// </summary>
            [NameInMap("DomainBlacklistPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessDomainBlacklistPolicies DomainBlacklistPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessDomainBlacklistPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk) or 3 (Lark), the process code from the external approval platform is returned. For other approval types, an empty value is returned.</para>
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
                public List<UpdateApprovalProcessResponseBodyProcessDomainBlacklistPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessDomainBlacklistPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Report website access</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the control in the external approval form. The value is in the Type%%%Control ID format.</para>
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
                /// <para>The list of domain name blacklist policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The ID of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The list of policies associated with the domain name whitelist.</para>
            /// </summary>
            [NameInMap("DomainWhitelistPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessDomainWhitelistPolicies DomainWhitelistPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessDomainWhitelistPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk) or 3 (Lark), the process code from the external approval platform is returned. For other approval types, an empty value is returned.</para>
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
                public List<UpdateApprovalProcessResponseBodyProcessDomainWhitelistPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessDomainWhitelistPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Report website access</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the control in the external approval form. The value is in the Type%%%Control ID format.</para>
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
                /// <para>The list of domain name whitelist policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The ID of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The list of associated endpoint hardening policies.</para>
            /// </summary>
            [NameInMap("EndpointHardeningPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessEndpointHardeningPolicies EndpointHardeningPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessEndpointHardeningPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk) or 3 (Lark), the process code from the external approval platform is returned. For other approval types, an empty value is returned.</para>
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
                public List<UpdateApprovalProcessResponseBodyProcessEndpointHardeningPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessEndpointHardeningPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Process name</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the control in the external approval form. The value is in the Type%%%Control ID format.</para>
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
                /// <para>The list of endpoint hardening policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The ID of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The event callback URL. This field returns the complete event callback URL of the external platform when the approval type is 1 (DingTalk approval) or 3 (Lark approval). For other approval types, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://callback.example.com/sase/api/v1/approval/dingtalk/callback/9m4e2mr0ui3e8a21">https://callback.example.com/sase/api/v1/approval/dingtalk/callback/9m4e2mr0ui3e8a21</a>****</para>
            /// </summary>
            [NameInMap("EventLabel")]
            [Validation(Required=false)]
            public string EventLabel { get; set; }

            /// <summary>
            /// <para>The external approval configuration. This field contains the integration information for the external approval platform when the approval type is 1 (DingTalk approval) or 3 (Lark approval). For other approval types, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;appKey&quot;:&quot;dingn1a2b3c4d5e6f****&quot;,&quot;appSecret&quot;:&quot;f9c8e7d6a5b4c3d2e1f0a9b8c7d6e5f4a3b2c1d0e9f8a7b6c5d4e3f2a1b0****&quot;,&quot;eventVerifyToken&quot;:&quot;7a8b9c0d1e2f3a4b5c6d7e8f9a0b****&quot;,&quot;eventAesKey&quot;:&quot;1a2b3c4d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t****&quot;}</para>
            /// </summary>
            [NameInMap("ExternalConfig")]
            [Validation(Required=false)]
            public string ExternalConfig { get; set; }

            /// <summary>
            /// <para>The list of policies associated with peripheral control.</para>
            /// </summary>
            [NameInMap("PeripheraBlockPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessPeripheraBlockPolicies PeripheraBlockPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessPeripheraBlockPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk) or 3 (Lark), the process code from the external approval platform is returned. For other approval types, an empty value is returned.</para>
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
                public List<UpdateApprovalProcessResponseBodyProcessPeripheraBlockPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessPeripheraBlockPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Operating system</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the control in the external approval form. The value is in the Type%%%Control ID format.</para>
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
                /// <para>The list of peripheral control policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The ID of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The list of associated internal network access control policies.</para>
            /// </summary>
            [NameInMap("PrivateAccessBlockPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessPrivateAccessBlockPolicies PrivateAccessBlockPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessPrivateAccessBlockPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk) or 3 (Lark), the process code from the external approval platform is returned. For other approval types, an empty value is returned.</para>
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
                public List<UpdateApprovalProcessResponseBodyProcessPrivateAccessBlockPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessPrivateAccessBlockPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Reported application</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the control in the external approval form. The value is in the Type%%%Control ID format.</para>
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
                /// <para>The list of internal network access control policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The ID of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-process-2677fcf063f5****</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            /// <summary>
            /// <para>The name of the approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Endpoint software installation approval process</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>The list of approval nodes.</para>
            /// </summary>
            [NameInMap("ProcessNodes")]
            [Validation(Required=false)]
            public List<List<UpdateApprovalProcessResponseBodyProcessProcessNodes>> ProcessNodes { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessProcessNodes : TeaModel {
                /// <summary>
                /// <para>The ID of the approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
                /// </summary>
                [NameInMap("SaseUserId")]
                [Validation(Required=false)]
                public string SaseUserId { get; set; }

                /// <summary>
                /// <para>The username of the approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mr. Wang</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The list of policies associated with software blocking.</para>
            /// </summary>
            [NameInMap("SoftwareBlockPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessSoftwareBlockPolicies SoftwareBlockPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessSoftwareBlockPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk) or 3 (Lark), the process code from the external approval platform is returned. For other approval types, an empty value is returned.</para>
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
                public List<UpdateApprovalProcessResponseBodyProcessSoftwareBlockPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessSoftwareBlockPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Report software</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the control in the external approval form. The value is in the Type%%%Control ID format.</para>
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
                /// <para>The list of software block policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The ID of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The list of associated software hardening policies.</para>
            /// </summary>
            [NameInMap("SoftwareHardeningPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessSoftwareHardeningPolicies SoftwareHardeningPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessSoftwareHardeningPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk) or 3 (Lark), the process code from the external approval platform is returned. For other approval types, an empty value is returned.</para>
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
                public List<UpdateApprovalProcessResponseBodyProcessSoftwareHardeningPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessSoftwareHardeningPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Process name</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The type and identifier of the control in the external approval form. The value is in the Type%%%Control ID format.</para>
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
                /// <para>The list of software hardening policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The ID of the approval template.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E9D7ACD-53D5-56EF-A913-79D148D06299</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
