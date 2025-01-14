// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalProcessesResponseBody : TeaModel {
        [NameInMap("Processes")]
        [Validation(Required=false)]
        public List<ListApprovalProcessesResponseBodyProcesses> Processes { get; set; }
        public class ListApprovalProcessesResponseBodyProcesses : TeaModel {
            [NameInMap("AppUninstallPolicies")]
            [Validation(Required=false)]
            public ListApprovalProcessesResponseBodyProcessesAppUninstallPolicies AppUninstallPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesAppUninstallPolicies : TeaModel {
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
            /// <para>2024-02-27 14:04:27</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DeviceRegistrationPolicies")]
            [Validation(Required=false)]
            public ListApprovalProcessesResponseBodyProcessesDeviceRegistrationPolicies DeviceRegistrationPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesDeviceRegistrationPolicies : TeaModel {
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
            public ListApprovalProcessesResponseBodyProcessesDlpSendPolicies DlpSendPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesDlpSendPolicies : TeaModel {
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
            public ListApprovalProcessesResponseBodyProcessesDomainBlacklistPolicies DomainBlacklistPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesDomainBlacklistPolicies : TeaModel {
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
            public ListApprovalProcessesResponseBodyProcessesDomainWhitelistPolicies DomainWhitelistPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesDomainWhitelistPolicies : TeaModel {
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
            public ListApprovalProcessesResponseBodyProcessesPeripheralBlockPolicies PeripheralBlockPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesPeripheralBlockPolicies : TeaModel {
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
            public List<List<ListApprovalProcessesResponseBodyProcessesProcessNodes>> ProcessNodes { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesProcessNodes : TeaModel {
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
            public ListApprovalProcessesResponseBodyProcessesSoftwareBlockPolicies SoftwareBlockPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesSoftwareBlockPolicies : TeaModel {
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
        /// <para>7E39C33B-F565-55C6-ACC2-953FCE7DA7D6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public string TotalNum { get; set; }

    }

}
