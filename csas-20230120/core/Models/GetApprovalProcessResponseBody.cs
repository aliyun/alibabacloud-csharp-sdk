// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetApprovalProcessResponseBody : TeaModel {
        [NameInMap("Process")]
        [Validation(Required=false)]
        public GetApprovalProcessResponseBodyProcess Process { get; set; }
        public class GetApprovalProcessResponseBodyProcess : TeaModel {
            [NameInMap("AppUninstallPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessAppUninstallPolicies AppUninstallPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessAppUninstallPolicies : TeaModel {
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
            /// <para>2022-10-25 10:44:09</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DeviceRegistrationPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessDeviceRegistrationPolicies DeviceRegistrationPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessDeviceRegistrationPolicies : TeaModel {
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
            public GetApprovalProcessResponseBodyProcessDlpSendPolicies DlpSendPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessDlpSendPolicies : TeaModel {
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
            public GetApprovalProcessResponseBodyProcessDomainBlacklistPolicies DomainBlacklistPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessDomainBlacklistPolicies : TeaModel {
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
            public GetApprovalProcessResponseBodyProcessDomainWhitelistPolicies DomainWhitelistPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessDomainWhitelistPolicies : TeaModel {
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
            public GetApprovalProcessResponseBodyProcessEndpointHardeningPolicies EndpointHardeningPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessEndpointHardeningPolicies : TeaModel {
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("PeripheralBlockPolicies")]
            [Validation(Required=false)]
            public GetApprovalProcessResponseBodyProcessPeripheralBlockPolicies PeripheralBlockPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessPeripheralBlockPolicies : TeaModel {
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
            /// <para>approval-process-35ee09077ee9****</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            [NameInMap("ProcessNodes")]
            [Validation(Required=false)]
            public List<List<GetApprovalProcessResponseBodyProcessProcessNodes>> ProcessNodes { get; set; }
            public class GetApprovalProcessResponseBodyProcessProcessNodes : TeaModel {
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
            public GetApprovalProcessResponseBodyProcessSoftwareBlockPolicies SoftwareBlockPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessSoftwareBlockPolicies : TeaModel {
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
            public GetApprovalProcessResponseBodyProcessSoftwareHardeningPolicies SoftwareHardeningPolicies { get; set; }
            public class GetApprovalProcessResponseBodyProcessSoftwareHardeningPolicies : TeaModel {
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
        /// <para>C81E0B4B-AAEB-5FDD-B27E-3F5AF7EBD7EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
