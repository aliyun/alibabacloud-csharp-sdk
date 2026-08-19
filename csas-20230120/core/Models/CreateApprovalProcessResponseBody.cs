// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateApprovalProcessResponseBody : TeaModel {
        /// <summary>
        /// <para>The approval flow.</para>
        /// </summary>
        [NameInMap("Process")]
        [Validation(Required=false)]
        public CreateApprovalProcessResponseBodyProcess Process { get; set; }
        public class CreateApprovalProcessResponseBodyProcess : TeaModel {
            /// <summary>
            /// <para>The list of policies associated with terminal uninstall.</para>
            /// </summary>
            [NameInMap("AppUninstallPolicies")]
            [Validation(Required=false)]
            public CreateApprovalProcessResponseBodyProcessAppUninstallPolicies AppUninstallPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessAppUninstallPolicies : TeaModel {
                /// <summary>
                /// <para>The list of terminal uninstall policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The approval template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The time when the approval flow was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-25 10:44:09</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the approval flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is an approval flow</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of policies associated with device registration.</para>
            /// </summary>
            [NameInMap("DeviceRegistrationPolicies")]
            [Validation(Required=false)]
            public CreateApprovalProcessResponseBodyProcessDeviceRegistrationPolicies DeviceRegistrationPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessDeviceRegistrationPolicies : TeaModel {
                /// <summary>
                /// <para>The list of device registration policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The approval template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The list of policies associated with file outbound.</para>
            /// </summary>
            [NameInMap("DlpSendPolicies")]
            [Validation(Required=false)]
            public CreateApprovalProcessResponseBodyProcessDlpSendPolicies DlpSendPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessDlpSendPolicies : TeaModel {
                /// <summary>
                /// <para>The list of file outbound policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The approval template ID.</para>
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
            public CreateApprovalProcessResponseBodyProcessDomainBlacklistPolicies DomainBlacklistPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessDomainBlacklistPolicies : TeaModel {
                /// <summary>
                /// <para>The list of domain name blacklist policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The approval template ID.</para>
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
            public CreateApprovalProcessResponseBodyProcessDomainWhitelistPolicies DomainWhitelistPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessDomainWhitelistPolicies : TeaModel {
                /// <summary>
                /// <para>The list of domain name whitelist policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The approval template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("EndpointHardeningPolicies")]
            [Validation(Required=false)]
            public CreateApprovalProcessResponseBodyProcessEndpointHardeningPolicies EndpointHardeningPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessEndpointHardeningPolicies : TeaModel {
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The list of policies associated with peripheral control.</para>
            /// </summary>
            [NameInMap("PeripheralBlockPolicies")]
            [Validation(Required=false)]
            public CreateApprovalProcessResponseBodyProcessPeripheralBlockPolicies PeripheralBlockPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessPeripheralBlockPolicies : TeaModel {
                /// <summary>
                /// <para>The list of peripheral control policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The approval template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("PrivateAccessBlockPolicies")]
            [Validation(Required=false)]
            public CreateApprovalProcessResponseBodyProcessPrivateAccessBlockPolicies PrivateAccessBlockPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessPrivateAccessBlockPolicies : TeaModel {
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The approval flow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-process-dc61e92ba5c5****</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            /// <summary>
            /// <para>The approval flow name.</para>
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
            public List<List<CreateApprovalProcessResponseBodyProcessProcessNodes>> ProcessNodes { get; set; }
            public class CreateApprovalProcessResponseBodyProcessProcessNodes : TeaModel {
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
                /// <para>The approver username.</para>
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
            public CreateApprovalProcessResponseBodyProcessSoftwareBlockPolicies SoftwareBlockPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessSoftwareBlockPolicies : TeaModel {
                /// <summary>
                /// <para>The list of software blocking policy IDs.</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                /// <summary>
                /// <para>The approval template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("SoftwareHardeningPolicies")]
            [Validation(Required=false)]
            public CreateApprovalProcessResponseBodyProcessSoftwareHardeningPolicies SoftwareHardeningPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessSoftwareHardeningPolicies : TeaModel {
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2CABFEBB-0CE7-575E-833A-266F75D46713</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
