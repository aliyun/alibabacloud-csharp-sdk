// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetApprovalProcessResponseBody : TeaModel {
        /// <summary>
        /// <para>The approval process.</para>
        /// </summary>
        [NameInMap("Process")]
        [Validation(Required=false)]
        public GetApprovalProcessResponseBodyProcess Process { get; set; }
        public class GetApprovalProcessResponseBodyProcess : TeaModel {
            /// <summary>
            /// <para>The list of associated endpoint uninstall policies.</para>
            /// </summary>
            [NameInMap("AppUninstallPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessAppUninstallPolicies AppUninstallPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessAppUninstallPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk approval), this parameter corresponds to the DingTalk process code. If the approval type is 2 (WeCom approval), this parameter corresponds to the template ID. If the approval type is 3 (Lark approval), this parameter corresponds to the approval definition code. If the approval type is 0 (built-in approval), this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The list of mappings between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessAppUninstallPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessAppUninstallPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Registration reason</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The identifier of the control in the external approval form. DingTalk approval returns the control label. WeCom and Lark approvals return the value in the &quot;Control type%%%Control ID&quot; format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Textarea%%%widget-1a2b****</para>
                    /// </summary>
                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field identifier, such as approvalReason.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>approvalReason</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The list of endpoint uninstall policy IDs.</para>
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
            /// <para>2022-10-25 10:44:09</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Approval flow for office network public domain name whitelist reporting.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of policies associated with device registration.</para>
            /// </summary>
            [NameInMap("DeviceRegistrationPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessDeviceRegistrationPolicies DeviceRegistrationPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessDeviceRegistrationPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk approval), this parameter corresponds to the DingTalk process code. If the approval type is 2 (WeCom approval), this parameter corresponds to the template ID. If the approval type is 3 (Lark approval), this parameter corresponds to the approval definition code. If the approval type is 0 (built-in approval), this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The list of mappings between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessDeviceRegistrationPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessDeviceRegistrationPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Registered domain name</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The identifier of the control in the external approval form. DingTalk approval returns the control label. WeCom and Lark approvals return the value in the &quot;Control type%%%Control ID&quot; format.</para>
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
            /// <para>The list of associated outbound file transfer policies.</para>
            /// </summary>
            [NameInMap("DlpSendPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessDlpSendPolicies DlpSendPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessDlpSendPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk approval), this parameter corresponds to the DingTalk process code. If the approval type is 2 (WeCom approval), this parameter corresponds to the template ID. If the approval type is 3 (Lark approval), this parameter corresponds to the approval definition code. If the approval type is 0 (built-in approval), this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The list of mappings between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessDlpSendPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessDlpSendPoliciesFieldMap : TeaModel {
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
                    /// <para>The identifier of the control in the external approval form. DingTalk approval returns the control label. WeCom and Lark approvals return the value in the &quot;Control type%%%Control ID&quot; format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Textarea%%%widget-1a2b****</para>
                    /// </summary>
                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field identifier, such as fileName.</para>
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
            public GetApprovalProcessResponseBodyProcessDomainBlacklistPolicies DomainBlacklistPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessDomainBlacklistPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk approval), this parameter corresponds to the DingTalk process code. If the approval type is 2 (WeCom approval), this parameter corresponds to the template ID. If the approval type is 3 (Lark approval), this parameter corresponds to the approval definition code. If the approval type is 0 (built-in approval), this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The list of mappings between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessDomainBlacklistPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessDomainBlacklistPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Reported access website</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The identifier of the control in the external approval form. DingTalk approval returns the control label. WeCom and Lark approvals return the value in the &quot;Control type%%%Control ID&quot; format.</para>
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
            public GetApprovalProcessResponseBodyProcessDomainWhitelistPolicies DomainWhitelistPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessDomainWhitelistPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk approval), this parameter corresponds to the DingTalk process code. If the approval type is 2 (WeCom approval), this parameter corresponds to the template ID. If the approval type is 3 (Lark approval), this parameter corresponds to the approval definition code. If the approval type is 0 (built-in approval), this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The list of mappings between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessDomainWhitelistPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessDomainWhitelistPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Reported access website</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The identifier of the control in the external approval form. DingTalk approval returns the control label. WeCom and Lark approvals return the value in the &quot;Control type%%%Control ID&quot; format.</para>
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
            public GetApprovalProcessResponseBodyProcessEndpointHardeningPolicies EndpointHardeningPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessEndpointHardeningPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk approval), this parameter corresponds to the DingTalk process code. If the approval type is 2 (WeCom approval), this parameter corresponds to the template ID. If the approval type is 3 (Lark approval), this parameter corresponds to the approval definition code. If the approval type is 0 (built-in approval), this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The list of mappings between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessEndpointHardeningPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessEndpointHardeningPoliciesFieldMap : TeaModel {
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
                    /// <para>The identifier of the control in the external approval form. DingTalk approval returns the control label. WeCom and Lark approvals return the value in the &quot;Control type%%%Control ID&quot; format.</para>
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
            /// <para>The event callback URL. When the approval type is 1 (DingTalk approval) or 3 (Lark approval), this parameter returns the complete event callback URL of the external platform. For other approval types, this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://callback.example.com/sase/api/v1/approval/dingtalk/callback/approval-event-1a2b">https://callback.example.com/sase/api/v1/approval/dingtalk/callback/approval-event-1a2b</a>****</para>
            /// </summary>
            [NameInMap("EventLabel")]
            [Validation(Required=false)]
            public string EventLabel { get; set; }

            /// <summary>
            /// <para>The external approval configuration. When the approval type is 1 (DingTalk approval) or 3 (Lark approval), this parameter includes the integration configuration for the external approval platform, including appKey, appSecret, eventVerifyToken, and eventAesKey. For other approval types, this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;appKey&quot;:&quot;dingabc1234****&quot;,&quot;appSecret&quot;:&quot;a1b2c3d4****&quot;,&quot;eventVerifyToken&quot;:&quot;e5f6a7b8****&quot;,&quot;eventAesKey&quot;:&quot;c9d0e1f2****&quot;}</para>
            /// </summary>
            [NameInMap("ExternalConfig")]
            [Validation(Required=false)]
            public string ExternalConfig { get; set; }

            /// <summary>
            /// <para>The list of associated peripheral control policies.</para>
            /// </summary>
            [NameInMap("PeripheralBlockPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessPeripheralBlockPolicies PeripheralBlockPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessPeripheralBlockPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk approval), this parameter corresponds to the DingTalk process code. If the approval type is 2 (WeCom approval), this parameter corresponds to the template ID. If the approval type is 3 (Lark approval), this parameter corresponds to the approval definition code. If the approval type is 0 (built-in approval), this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The list of mappings between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessPeripheralBlockPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessPeripheralBlockPoliciesFieldMap : TeaModel {
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
                    /// <para>The identifier of the control in the external approval form. DingTalk approval returns the control label. WeCom and Lark approvals return the value in the &quot;Control type%%%Control ID&quot; format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Textarea%%%widget-1a2b****</para>
                    /// </summary>
                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field identifier, such as devType.</para>
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
            /// <para>The list of policies associated with internal network access control.</para>
            /// </summary>
            [NameInMap("PrivateAccessBlockPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessPrivateAccessBlockPolicies PrivateAccessBlockPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessPrivateAccessBlockPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk approval), this parameter corresponds to the DingTalk process code. If the approval type is 2 (WeCom approval), this parameter corresponds to the template ID. If the approval type is 3 (Lark approval), this parameter corresponds to the approval definition code. If the approval type is 0 (built-in approval), this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The list of mappings between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessPrivateAccessBlockPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessPrivateAccessBlockPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Application ID</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The identifier of the control in the external approval form. DingTalk approval returns the control label. WeCom and Lark approvals return the value in the &quot;Control type%%%Control ID&quot; format.</para>
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
            /// <para>approval-process-35ee09077ee9****</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            /// <summary>
            /// <para>The name of the approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office network public domain name whitelist approval</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>The list of approval nodes.</para>
            /// </summary>
            [NameInMap("ProcessNodes")]
            [Validation(Required=false)]
            public List<List<GetApprovalProcessResponseBodyProcessProcessNodes>> ProcessNodes { get; set; }
            public class GetApprovalProcessResponseBodyProcessProcessNodes : TeaModel {
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
                /// <para>张三</para>
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
            public GetApprovalProcessResponseBodyProcessSoftwareBlockPolicies SoftwareBlockPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessSoftwareBlockPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk approval), this parameter corresponds to the DingTalk process code. If the approval type is 2 (WeCom approval), this parameter corresponds to the template ID. If the approval type is 3 (Lark approval), this parameter corresponds to the approval definition code. If the approval type is 0 (built-in approval), this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The list of mappings between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessSoftwareBlockPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessSoftwareBlockPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The name of the control in the external approval form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Reported software</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    /// <summary>
                    /// <para>The identifier of the control in the external approval form. DingTalk approval returns the control label. WeCom and Lark approvals return the value in the &quot;Control type%%%Control ID&quot; format.</para>
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
                /// <para>The list of software blocking policy IDs.</para>
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
            public GetApprovalProcessResponseBodyProcessSoftwareHardeningPolicies SoftwareHardeningPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessSoftwareHardeningPolicies : TeaModel {
                /// <summary>
                /// <para>The ID of the external approval process. If the approval type is 1 (DingTalk approval), this parameter corresponds to the DingTalk process code. If the approval type is 2 (WeCom approval), this parameter corresponds to the template ID. If the approval type is 3 (Lark approval), this parameter corresponds to the approval definition code. If the approval type is 0 (built-in approval), this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROC-1a2b3c4d5e6f****</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The list of mappings between system fields and external approval form controls.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessSoftwareHardeningPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessSoftwareHardeningPoliciesFieldMap : TeaModel {
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
                    /// <para>The identifier of the control in the external approval form. DingTalk approval returns the control label. WeCom and Lark approvals return the value in the &quot;Control type%%%Control ID&quot; format.</para>
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
        /// <para>C81E0B4B-AAEB-5FDD-B27E-3F5AF7EBD7EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
