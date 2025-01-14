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

            [NameInMap("PeripheraBlockPolicies")]
            [Validation(Required=false)]
            public UpdateApprovalProcessResponseBodyProcessPeripheraBlockPolicies PeripheraBlockPolicies { get; set; }
            public class UpdateApprovalProcessResponseBodyProcessPeripheraBlockPolicies : TeaModel {
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
        /// <para>7E9D7ACD-53D5-56EF-A913-79D148D06299</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
