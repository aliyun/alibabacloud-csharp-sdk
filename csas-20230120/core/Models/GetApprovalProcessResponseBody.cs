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
            /// <para>The list of policies associated with endpoint uninstallation.</para>
            /// </summary>
            [NameInMap("AppUninstallPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessAppUninstallPolicies AppUninstallPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessAppUninstallPolicies : TeaModel {
                /// <summary>
                /// <para>The external process ID.</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The field mapping table.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessAppUninstallPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessAppUninstallPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The display field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Name</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Name</para>
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
            /// <para>The approval type.</para>
            /// </summary>
            [NameInMap("ApprovalType")]
            [Validation(Required=false)]
            public int? ApprovalType { get; set; }

            /// <summary>
            /// <para>The creation time of the approval process.</para>
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
            /// <para>This is an approval process</para>
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
                /// <para>The external process ID.</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The field mapping table.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessDeviceRegistrationPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessDeviceRegistrationPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The display field.</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field.</para>
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
            /// <para>The list of associated policies for file outgoing.</para>
            /// </summary>
            [NameInMap("DlpSendPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessDlpSendPolicies DlpSendPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessDlpSendPolicies : TeaModel {
                /// <summary>
                /// <para>The external process ID.</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The field mapping table.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessDlpSendPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessDlpSendPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The display field.</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field.</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The list of file outgoing policy IDs.</para>
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
            /// <para>The list of policies associated with the domain blacklist.</para>
            /// </summary>
            [NameInMap("DomainBlacklistPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessDomainBlacklistPolicies DomainBlacklistPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessDomainBlacklistPolicies : TeaModel {
                /// <summary>
                /// <para>The external process ID.</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The field mapping table.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessDomainBlacklistPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessDomainBlacklistPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The display field.</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field.</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The list of domain blacklist policy IDs.</para>
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
            /// <para>The list of policies associated with the domain whitelist.</para>
            /// </summary>
            [NameInMap("DomainWhitelistPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessDomainWhitelistPolicies DomainWhitelistPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessDomainWhitelistPolicies : TeaModel {
                /// <summary>
                /// <para>The external process ID.</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The field mapping table.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessDomainWhitelistPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessDomainWhitelistPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The display field.</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field.</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The list of domain whitelist policy IDs.</para>
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
            /// <para>The endpoint protection policy.</para>
            /// </summary>
            [NameInMap("EndpointHardeningPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessEndpointHardeningPolicies EndpointHardeningPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessEndpointHardeningPolicies : TeaModel {
                /// <summary>
                /// <para>The external process ID.</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The field mapping table.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessEndpointHardeningPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessEndpointHardeningPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The display field.</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field.</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The policy ID.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The template ID.</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The label.</para>
            /// </summary>
            [NameInMap("EventLabel")]
            [Validation(Required=false)]
            public string EventLabel { get; set; }

            /// <summary>
            /// <para>The external configuration.</para>
            /// </summary>
            [NameInMap("ExternalConfig")]
            [Validation(Required=false)]
            public string ExternalConfig { get; set; }

            /// <summary>
            /// <para>The list of associated policies for peripheral control.</para>
            /// </summary>
            [NameInMap("PeripheralBlockPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessPeripheralBlockPolicies PeripheralBlockPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessPeripheralBlockPolicies : TeaModel {
                /// <summary>
                /// <para>The external process ID.</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The field mapping table.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessPeripheralBlockPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessPeripheralBlockPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The display field.</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field.</para>
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
            /// <para>The software hardening policy.</para>
            /// </summary>
            [NameInMap("PrivateAccessBlockPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessPrivateAccessBlockPolicies PrivateAccessBlockPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessPrivateAccessBlockPolicies : TeaModel {
                /// <summary>
                /// <para>The external process ID.</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The field mapping table.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessPrivateAccessBlockPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessPrivateAccessBlockPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The display field.</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field.</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The policy ID.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The template ID.</para>
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
            /// <para>Test</para>
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
                /// <para>The approver ID.</para>
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
                /// <para>John</para>
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
                /// <para>The external process ID.</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The field mapping table.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessSoftwareBlockPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessSoftwareBlockPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The display field.</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field.</para>
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
            /// <para>The software hardening policy.</para>
            /// </summary>
            [NameInMap("SoftwareHardeningPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessSoftwareHardeningPolicies SoftwareHardeningPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessSoftwareHardeningPolicies : TeaModel {
                /// <summary>
                /// <para>The external process ID.</para>
                /// </summary>
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                /// <summary>
                /// <para>The field mapping table.</para>
                /// </summary>
                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<GetApprovalProcessResponseBodyProcessSoftwareHardeningPoliciesFieldMap> FieldMap { get; set; }
                public class GetApprovalProcessResponseBodyProcessSoftwareHardeningPoliciesFieldMap : TeaModel {
                    /// <summary>
                    /// <para>The display field.</para>
                    /// </summary>
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    /// <summary>
                    /// <para>The system field.</para>
                    /// </summary>
                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                /// <summary>
                /// <para>The policy ID.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The template ID.</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C81E0B4B-AAEB-5FDD-B27E-3F5AF7EBD7EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
