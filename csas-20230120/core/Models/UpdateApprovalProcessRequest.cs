// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateApprovalProcessRequest : TeaModel {
        [NameInMap("ApprovalType")]
        [Validation(Required=false)]
        public int? ApprovalType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EventLabel")]
        [Validation(Required=false)]
        public string EventLabel { get; set; }

        [NameInMap("ExternalConfig")]
        [Validation(Required=false)]
        public string ExternalConfig { get; set; }

        [NameInMap("MatchSchemaConfigs")]
        [Validation(Required=false)]
        public UpdateApprovalProcessRequestMatchSchemaConfigs MatchSchemaConfigs { get; set; }
        public class UpdateApprovalProcessRequestMatchSchemaConfigs : TeaModel {
            [NameInMap("AppUninstallSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsAppUninstallSchemaConfig AppUninstallSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsAppUninstallSchemaConfig : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsAppUninstallSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsAppUninstallSchemaConfigFieldMap : TeaModel {
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

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("DeviceRegistrationSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsDeviceRegistrationSchemaConfig DeviceRegistrationSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsDeviceRegistrationSchemaConfig : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsDeviceRegistrationSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsDeviceRegistrationSchemaConfigFieldMap : TeaModel {
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

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("DlpSendSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsDlpSendSchemaConfig DlpSendSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsDlpSendSchemaConfig : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsDlpSendSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsDlpSendSchemaConfigFieldMap : TeaModel {
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

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("DomainBlacklistSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsDomainBlacklistSchemaConfig DomainBlacklistSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsDomainBlacklistSchemaConfig : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsDomainBlacklistSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsDomainBlacklistSchemaConfigFieldMap : TeaModel {
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

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("DomainWhitelistSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsDomainWhitelistSchemaConfig DomainWhitelistSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsDomainWhitelistSchemaConfig : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsDomainWhitelistSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsDomainWhitelistSchemaConfigFieldMap : TeaModel {
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

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("EndpointHardeningSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsEndpointHardeningSchemaConfig EndpointHardeningSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsEndpointHardeningSchemaConfig : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsEndpointHardeningSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsEndpointHardeningSchemaConfigFieldMap : TeaModel {
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

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("PeripheralBlockSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsPeripheralBlockSchemaConfig PeripheralBlockSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsPeripheralBlockSchemaConfig : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsPeripheralBlockSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsPeripheralBlockSchemaConfigFieldMap : TeaModel {
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

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("SoftwareBlockSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareBlockSchemaConfig SoftwareBlockSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareBlockSchemaConfig : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareBlockSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareBlockSchemaConfigFieldMap : TeaModel {
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

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

            [NameInMap("SoftwareHardeningSchemaConfig")]
            [Validation(Required=false)]
            public UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareHardeningSchemaConfig SoftwareHardeningSchemaConfig { get; set; }
            public class UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareHardeningSchemaConfig : TeaModel {
                [NameInMap("ExternalProcessId")]
                [Validation(Required=false)]
                public string ExternalProcessId { get; set; }

                [NameInMap("FieldMap")]
                [Validation(Required=false)]
                public List<UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareHardeningSchemaConfigFieldMap> FieldMap { get; set; }
                public class UpdateApprovalProcessRequestMatchSchemaConfigsSoftwareHardeningSchemaConfigFieldMap : TeaModel {
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

                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

            }

        }

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
