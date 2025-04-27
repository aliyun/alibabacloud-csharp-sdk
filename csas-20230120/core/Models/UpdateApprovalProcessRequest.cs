// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateApprovalProcessRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("MatchSchemas")]
        [Validation(Required=false)]
        public UpdateApprovalProcessRequestMatchSchemas MatchSchemas { get; set; }
        public class UpdateApprovalProcessRequestMatchSchemas : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("AppUninstallSchemaId")]
            [Validation(Required=false)]
            public string AppUninstallSchemaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("DeviceRegistrationSchemaId")]
            [Validation(Required=false)]
            public string DeviceRegistrationSchemaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("DlpSendSchemaId")]
            [Validation(Required=false)]
            public string DlpSendSchemaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("DomainBlacklistSchemaId")]
            [Validation(Required=false)]
            public string DomainBlacklistSchemaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("DomainWhitelistSchemaId")]
            [Validation(Required=false)]
            public string DomainWhitelistSchemaId { get; set; }

            [NameInMap("EndpointHardeningSchemaId")]
            [Validation(Required=false)]
            public string EndpointHardeningSchemaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("PeripheralBlockSchemaId")]
            [Validation(Required=false)]
            public string PeripheralBlockSchemaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("SoftwareBlockSchemaId")]
            [Validation(Required=false)]
            public string SoftwareBlockSchemaId { get; set; }

            [NameInMap("SoftwareHardeningSchemaId")]
            [Validation(Required=false)]
            public string SoftwareHardeningSchemaId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-process-f16bf74b2b29****</para>
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        [NameInMap("ProcessNodes")]
        [Validation(Required=false)]
        public List<List<string>> ProcessNodes { get; set; }

    }

}
