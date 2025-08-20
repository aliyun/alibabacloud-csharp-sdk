// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateApprovalProcessResponseBody : TeaModel {
        [NameInMap("Process")]
        [Validation(Required=false)]
        public UpdateApprovalProcessResponseBodyProcess Process { get; set; }
        public class UpdateApprovalProcessResponseBodyProcess : TeaModel {
            [NameInMap("AppUninstallPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessAppUninstallPolicies AppUninstallPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessAppUninstallPolicies : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessResponseBodyProcessAppUninstallPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessAppUninstallPoliciesFieldMap : TeaModel {
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("ApprovalType")]
            [Validation(Required=false)]
            public int? ApprovalType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-11 15:31:39</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DeviceRegistrationPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessDeviceRegistrationPolicies DeviceRegistrationPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessDeviceRegistrationPolicies : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessResponseBodyProcessDeviceRegistrationPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessDeviceRegistrationPoliciesFieldMap : TeaModel {
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("DlpSendPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessDlpSendPolicies DlpSendPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessDlpSendPolicies : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessResponseBodyProcessDlpSendPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessDlpSendPoliciesFieldMap : TeaModel {
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("DomainBlacklistPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessDomainBlacklistPolicies DomainBlacklistPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessDomainBlacklistPolicies : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessResponseBodyProcessDomainBlacklistPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessDomainBlacklistPoliciesFieldMap : TeaModel {
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("DomainWhitelistPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessDomainWhitelistPolicies DomainWhitelistPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessDomainWhitelistPolicies : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessResponseBodyProcessDomainWhitelistPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessDomainWhitelistPoliciesFieldMap : TeaModel {
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("EndpointHardeningPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessEndpointHardeningPolicies EndpointHardeningPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessEndpointHardeningPolicies : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessResponseBodyProcessEndpointHardeningPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessEndpointHardeningPoliciesFieldMap : TeaModel {
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("EventLabel")]
            [Validation(Required=false)]
            public string EventLabel { get; set; }

            [NameInMap("ExternalConfig")]
            [Validation(Required=false)]
            public string ExternalConfig { get; set; }

            [NameInMap("PeripheraBlockPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessPeripheraBlockPolicies PeripheraBlockPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessPeripheraBlockPolicies : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessResponseBodyProcessPeripheraBlockPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessPeripheraBlockPoliciesFieldMap : TeaModel {
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>approval-process-2677fcf063f5****</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            [NameInMap("ProcessNodes")]
            [Validation(Required=false)]
            public List<List<UpdateApprovalProcessResponseBodyProcessProcessNodes>> ProcessNodes { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessProcessNodes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
                /// </summary>
                [NameInMap("SaseUserId")]
                [Validation(Required=false)]
                public string SaseUserId { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("SoftwareBlockPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessSoftwareBlockPolicies SoftwareBlockPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessSoftwareBlockPolicies : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessResponseBodyProcessSoftwareBlockPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessSoftwareBlockPoliciesFieldMap : TeaModel {
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("SoftwareHardeningPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessSoftwareHardeningPolicies SoftwareHardeningPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessSoftwareHardeningPolicies : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessResponseBodyProcessSoftwareHardeningPoliciesFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessResponseBodyProcessSoftwareHardeningPoliciesFieldMap : TeaModel {
                    [NameInMap("DisplayField")]
                    [Validation(Required=false)]
                    public string DisplayField { get; set; }

                    [NameInMap("DisplayFieldValue")]
                    [Validation(Required=false)]
                    public string DisplayFieldValue { get; set; }

                    [NameInMap("SystemField")]
                    [Validation(Required=false)]
                    public string SystemField { get; set; }

                }

                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7E9D7ACD-53D5-56EF-A913-79D148D06299</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
