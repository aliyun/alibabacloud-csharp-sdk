// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateApprovalProcessRequest : TeaModel {
        /// <summary>
        /// <para>The description of the approval flow. The description must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), hyphens (-), and spaces. Chinese characters are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is an approval flow</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The matched approval templates.</para>
        /// </summary>
        [NameInMap("MatchSchemas")]
        [Validation(Required=false)]
        public CreateApprovalProcessRequestMatchSchemas MatchSchemas { get; set; }
        public class CreateApprovalProcessRequestMatchSchemas : TeaModel {
            /// <summary>
            /// <para>The ID of the device uninstall approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("AppUninstallSchemaId")]
            [Validation(Required=false)]
            public string AppUninstallSchemaId { get; set; }

            /// <summary>
            /// <para>The ID of the device registration approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("DeviceRegistrationSchemaId")]
            [Validation(Required=false)]
            public string DeviceRegistrationSchemaId { get; set; }

            /// <summary>
            /// <para>The ID of the file outbound approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("DlpSendSchemaId")]
            [Validation(Required=false)]
            public string DlpSendSchemaId { get; set; }

            /// <summary>
            /// <para>The ID of the domain name blacklist approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("DomainBlacklistSchemaId")]
            [Validation(Required=false)]
            public string DomainBlacklistSchemaId { get; set; }

            /// <summary>
            /// <para>The ID of the domain name whitelist approval template.</para>
            /// 
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
            /// <para>The ID of the peripheral control approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("PeripheralBlockSchemaId")]
            [Validation(Required=false)]
            public string PeripheralBlockSchemaId { get; set; }

            [NameInMap("PrivateAccessBlockSchemaId")]
            [Validation(Required=false)]
            public string PrivateAccessBlockSchemaId { get; set; }

            /// <summary>
            /// <para>The ID of the software blocking approval template.</para>
            /// 
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
        /// <para>The flow name. The name must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). Chinese characters are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_process</para>
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// <para>The list of approval nodes. You can define up to 5 approval nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProcessNodes")]
        [Validation(Required=false)]
        public List<List<string>> ProcessNodes { get; set; }

    }

}
