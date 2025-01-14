// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateApprovalProcessResponseBody : TeaModel {
        [NameInMap("Process")]
        [Validation(Required=false)]
        public CreateApprovalProcessResponseBodyProcess Process { get; set; }
        public class CreateApprovalProcessResponseBodyProcess : TeaModel {
            [NameInMap("AppUninstallPolicies")]
            [Validation(Required=false)]
            public CreateApprovalProcessResponseBodyProcessAppUninstallPolicies AppUninstallPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessAppUninstallPolicies : TeaModel {
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
            public CreateApprovalProcessResponseBodyProcessDeviceRegistrationPolicies DeviceRegistrationPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessDeviceRegistrationPolicies : TeaModel {
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
            public CreateApprovalProcessResponseBodyProcessDlpSendPolicies DlpSendPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessDlpSendPolicies : TeaModel {
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
            public CreateApprovalProcessResponseBodyProcessDomainBlacklistPolicies DomainBlacklistPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessDomainBlacklistPolicies : TeaModel {
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
            public CreateApprovalProcessResponseBodyProcessDomainWhitelistPolicies DomainWhitelistPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessDomainWhitelistPolicies : TeaModel {
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

            [NameInMap("PeripheralBlockPolicies")]
            [Validation(Required=false)]
            public CreateApprovalProcessResponseBodyProcessPeripheralBlockPolicies PeripheralBlockPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessPeripheralBlockPolicies : TeaModel {
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
            /// <para>approval-process-dc61e92ba5c5****</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            [NameInMap("ProcessNodes")]
            [Validation(Required=false)]
            public List<List<CreateApprovalProcessResponseBodyProcessProcessNodes>> ProcessNodes { get; set; }
            public class CreateApprovalProcessResponseBodyProcessProcessNodes : TeaModel {
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
            public CreateApprovalProcessResponseBodyProcessSoftwareBlockPolicies SoftwareBlockPolicies { get; set; }
            public class CreateApprovalProcessResponseBodyProcessSoftwareBlockPolicies : TeaModel {
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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2CABFEBB-0CE7-575E-833A-266F75D46713</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
