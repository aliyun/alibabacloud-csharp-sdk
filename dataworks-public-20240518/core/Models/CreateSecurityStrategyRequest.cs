// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateSecurityStrategyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ABFUOEUOTRTRJKE</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public CreateSecurityStrategyRequestContent Content { get; set; }
        public class CreateSecurityStrategyRequestContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Tenant</para>
            /// </summary>
            [NameInMap("ControlDwScope")]
            [Validation(Required=false)]
            public string ControlDwScope { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataStudio</para>
            /// </summary>
            [NameInMap("ControlModule")]
            [Validation(Required=false)]
            public string ControlModule { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MyCatalog</para>
            /// </summary>
            [NameInMap("ControlSubModule")]
            [Validation(Required=false)]
            public string ControlSubModule { get; set; }

            [NameInMap("Controllers")]
            [Validation(Required=false)]
            public List<CreateSecurityStrategyRequestContentControllers> Controllers { get; set; }
            public class CreateSecurityStrategyRequestContentControllers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BasicEditionDefaultValue")]
                [Validation(Required=false)]
                public object BasicEditionDefaultValue { get; set; }

                [NameInMap("BasicEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> BasicEditionIntervalValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>viewCount</para>
                /// </summary>
                [NameInMap("Controller")]
                [Validation(Required=false)]
                public string Controller { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Integer</para>
                /// </summary>
                [NameInMap("ControllerValueType")]
                [Validation(Required=false)]
                public string ControllerValueType { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Query Results - Single Display Record Limit</para>
                /// </summary>
                [NameInMap("DisplayNameEn")]
                [Validation(Required=false)]
                public string DisplayNameEn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500000</para>
                /// </summary>
                [NameInMap("EnterpriseEditionDefaultValue")]
                [Validation(Required=false)]
                public object EnterpriseEditionDefaultValue { get; set; }

                [NameInMap("EnterpriseEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> EnterpriseEditionIntervalValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200000</para>
                /// </summary>
                [NameInMap("ProfessionalEditionDefaultValue")]
                [Validation(Required=false)]
                public object ProfessionalEditionDefaultValue { get; set; }

                [NameInMap("ProfessionalEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> ProfessionalEditionIntervalValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("StandardEditionDefaultValue")]
                [Validation(Required=false)]
                public object StandardEditionDefaultValue { get; set; }

                [NameInMap("StandardEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> StandardEditionIntervalValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("UserConfigValue")]
                [Validation(Required=false)]
                public object UserConfigValue { get; set; }

            }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Data Analysis</para>
            /// </summary>
            [NameInMap("DisplayNameEn")]
            [Validation(Required=false)]
            public string DisplayNameEn { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataQuerySecurityStrategySchema</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Default system generate data query policy</para>
            /// </summary>
            [NameInMap("SystemPolicyDisplayName")]
            [Validation(Required=false)]
            public string SystemPolicyDisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SYSTEM_GENERATE_DEFAULT_DATA_QUERY</para>
            /// </summary>
            [NameInMap("SystemPolicyName")]
            [Validation(Required=false)]
            public string SystemPolicyName { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tenant</para>
        /// </summary>
        [NameInMap("ControlDwScope")]
        [Validation(Required=false)]
        public string ControlDwScope { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataQuery</para>
        /// </summary>
        [NameInMap("ControlModule")]
        [Validation(Required=false)]
        public string ControlModule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MyCatalog</para>
        /// </summary>
        [NameInMap("ControlSubModule")]
        [Validation(Required=false)]
        public string ControlSubModule { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataQuerySecurityStrategySchema</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        [NameInMap("Workspaces")]
        [Validation(Required=false)]
        public List<long?> Workspaces { get; set; }

    }

}
