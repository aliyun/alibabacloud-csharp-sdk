// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalProcessesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of approval processes.</para>
        /// </summary>
        [NameInMap("Processes")]
        [Validation(Required=false)]
        public List<ListApprovalProcessesResponseBodyProcesses> Processes { get; set; }
        public class ListApprovalProcessesResponseBodyProcesses : TeaModel {
            /// <summary>
            /// <para>The list of policies associated with agent uninstallation.</para>
            /// </summary>
            [NameInMap("AppUninstallPolicies")]
            [Validation(Required=false)]
            public ListApprovalProcessesResponseBodyProcessesAppUninstallPolicies AppUninstallPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesAppUninstallPolicies : TeaModel {
                /// <summary>
                /// <para>The list of agent uninstallation policy IDs.</para>
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

            [NameInMap("ApprovalType")]
            [Validation(Required=false)]
            public int? ApprovalType { get; set; }

            /// <summary>
            /// <para>The time when the approval process was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-27 14:04:27</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一个审批流程</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of policies associated with device registration.</para>
            /// </summary>
            [NameInMap("DeviceRegistrationPolicies")]
            [Validation(Required=false)]
            public ListApprovalProcessesResponseBodyProcessesDeviceRegistrationPolicies DeviceRegistrationPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesDeviceRegistrationPolicies : TeaModel {
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
            /// <para>The list of policies associated with file outgoing.</para>
            /// </summary>
            [NameInMap("DlpSendPolicies")]
            [Validation(Required=false)]
            public ListApprovalProcessesResponseBodyProcessesDlpSendPolicies DlpSendPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesDlpSendPolicies : TeaModel {
                /// <summary>
                /// <para>The list of file outgoing policy IDs.</para>
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
            public ListApprovalProcessesResponseBodyProcessesDomainBlacklistPolicies DomainBlacklistPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesDomainBlacklistPolicies : TeaModel {
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
            public ListApprovalProcessesResponseBodyProcessesDomainWhitelistPolicies DomainWhitelistPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesDomainWhitelistPolicies : TeaModel {
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
            public ListApprovalProcessesResponseBodyProcessesEndpointHardeningPolicies EndpointHardeningPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesEndpointHardeningPolicies : TeaModel {
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
            public ListApprovalProcessesResponseBodyProcessesPeripheralBlockPolicies PeripheralBlockPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesPeripheralBlockPolicies : TeaModel {
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
            public ListApprovalProcessesResponseBodyProcessesPrivateAccessBlockPolicies PrivateAccessBlockPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesPrivateAccessBlockPolicies : TeaModel {
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public List<string> PolicyIds { get; set; }

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            /// <summary>
            /// <para>The approval process ID.</para>
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
            /// <para>测试</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>The list of approval nodes.</para>
            /// </summary>
            [NameInMap("ProcessNodes")]
            [Validation(Required=false)]
            public List<List<ListApprovalProcessesResponseBodyProcessesProcessNodes>> ProcessNodes { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesProcessNodes : TeaModel {
                /// <summary>
                /// <para>审批人ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
                /// </summary>
                [NameInMap("SaseUserId")]
                [Validation(Required=false)]
                public string SaseUserId { get; set; }

                /// <summary>
                /// <para>审批人用户名。</para>
                /// 
                /// <b>Example:</b>
                /// <para>王先生</para>
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
            public ListApprovalProcessesResponseBodyProcessesSoftwareBlockPolicies SoftwareBlockPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesSoftwareBlockPolicies : TeaModel {
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
            public ListApprovalProcessesResponseBodyProcessesSoftwareHardeningPolicies SoftwareHardeningPolicies { get; set; }
            public class ListApprovalProcessesResponseBodyProcessesSoftwareHardeningPolicies : TeaModel {
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
        /// <para>7E39C33B-F565-55C6-ACC2-953FCE7DA7D6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of approval processes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public string TotalNum { get; set; }

    }

}
