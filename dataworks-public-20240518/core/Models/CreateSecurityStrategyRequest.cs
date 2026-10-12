// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateSecurityStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency parameter. This parameter is used to prevent duplicate operations caused by multiple calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABFUOEUOTRTRJKE</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The policy content. The content is constrained by SecurityStrategySchema.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public CreateSecurityStrategyRequestContent Content { get; set; }
        public class CreateSecurityStrategyRequestContent : TeaModel {
            /// <summary>
            /// <para>The control scope. This is the name of the SecurityStrategySchema associated with the current policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tenant</para>
            /// </summary>
            [NameInMap("ControlDwScope")]
            [Validation(Required=false)]
            public string ControlDwScope { get; set; }

            /// <summary>
            /// <para>The control module. This is the controlModule of the SecurityStrategySchema associated with the current policy.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataStudio</para>
            /// </summary>
            [NameInMap("ControlModule")]
            [Validation(Required=false)]
            public string ControlModule { get; set; }

            /// <summary>
            /// <para>The control submodule. This is the controlSubModule of the SecurityStrategySchema associated with the current policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyCatalog</para>
            /// </summary>
            [NameInMap("ControlSubModule")]
            [Validation(Required=false)]
            public string ControlSubModule { get; set; }

            /// <summary>
            /// <para>The list of control items.</para>
            /// <para>Note: Valid control items depend on the selected schema. Refer to the controller definitions and the control item list for each schema.</para>
            /// </summary>
            [NameInMap("Controllers")]
            [Validation(Required=false)]
            public List<CreateSecurityStrategyRequestContentControllers> Controllers { get; set; }
            public class CreateSecurityStrategyRequestContentControllers : TeaModel {
                /// <summary>
                /// <para>The default value for Basic Edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BasicEditionDefaultValue")]
                [Validation(Required=false)]
                public object BasicEditionDefaultValue { get; set; }

                /// <summary>
                /// <para>The valid value range for Basic Edition, in the format of [min, max].</para>
                /// </summary>
                [NameInMap("BasicEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> BasicEditionIntervalValue { get; set; }

                /// <summary>
                /// <para>The identifier of the control item. For valid values, refer to the control item list for each schema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>viewCount</para>
                /// </summary>
                [NameInMap("Controller")]
                [Validation(Required=false)]
                public string Controller { get; set; }

                /// <summary>
                /// <para>The value type. Valid values: Boolean, Integer, Long, and String.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Integer</para>
                /// </summary>
                [NameInMap("ControllerValueType")]
                [Validation(Required=false)]
                public string ControllerValueType { get; set; }

                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Query results - Maximum number of records displayed per query</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The English display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Query Results - Single Display Record Limit</para>
                /// </summary>
                [NameInMap("DisplayNameEn")]
                [Validation(Required=false)]
                public string DisplayNameEn { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the control item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The default value for Enterprise Edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500000</para>
                /// </summary>
                [NameInMap("EnterpriseEditionDefaultValue")]
                [Validation(Required=false)]
                public object EnterpriseEditionDefaultValue { get; set; }

                /// <summary>
                /// <para>The valid value range for Enterprise Edition, in the format of [min, max].</para>
                /// </summary>
                [NameInMap("EnterpriseEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> EnterpriseEditionIntervalValue { get; set; }

                /// <summary>
                /// <para>The default value for Professional Edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200000</para>
                /// </summary>
                [NameInMap("ProfessionalEditionDefaultValue")]
                [Validation(Required=false)]
                public object ProfessionalEditionDefaultValue { get; set; }

                /// <summary>
                /// <para>The valid value range for Professional Edition, in the format of [min, max].</para>
                /// </summary>
                [NameInMap("ProfessionalEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> ProfessionalEditionIntervalValue { get; set; }

                /// <summary>
                /// <para>The default value for Standard Edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("StandardEditionDefaultValue")]
                [Validation(Required=false)]
                public object StandardEditionDefaultValue { get; set; }

                /// <summary>
                /// <para>The valid value range for Standard Edition, in the format of [min, max].</para>
                /// </summary>
                [NameInMap("StandardEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> StandardEditionIntervalValue { get; set; }

                /// <summary>
                /// <para>The user-configured value. The type depends on <c>ControllerValueType</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("UserConfigValue")]
                [Validation(Required=false)]
                public object UserConfigValue { get; set; }

            }

            /// <summary>
            /// <para>The display name of the SecurityStrategySchema associated with the current policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data analysis</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The English display name of the SecurityStrategySchema associated with the current policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data Analysis</para>
            /// </summary>
            [NameInMap("DisplayNameEn")]
            [Validation(Required=false)]
            public string DisplayNameEn { get; set; }

            /// <summary>
            /// <para>The name of the SecurityStrategySchema associated with the current policy.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataQuerySecurityStrategySchema</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the SecurityStrategySchema associated with the current policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default system generate data query policy</para>
            /// </summary>
            [NameInMap("SystemPolicyDisplayName")]
            [Validation(Required=false)]
            public string SystemPolicyDisplayName { get; set; }

            /// <summary>
            /// <para>The name of the SecurityStrategySchema associated with the current policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM_GENERATE_DEFAULT_DATA_QUERY</para>
            /// </summary>
            [NameInMap("SystemPolicyName")]
            [Validation(Required=false)]
            public string SystemPolicyName { get; set; }

        }

        /// <summary>
        /// <para>The control scope.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tenant</para>
        /// </summary>
        [NameInMap("ControlDwScope")]
        [Validation(Required=false)]
        public string ControlDwScope { get; set; }

        /// <summary>
        /// <para>The control module.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataQuery</para>
        /// </summary>
        [NameInMap("ControlModule")]
        [Validation(Required=false)]
        public string ControlModule { get; set; }

        /// <summary>
        /// <para>The control submodule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCatalog</para>
        /// </summary>
        [NameInMap("ControlSubModule")]
        [Validation(Required=false)]
        public string ControlSubModule { get; set; }

        /// <summary>
        /// <para>The description of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Controls the security behavior of query results in the data analysis module</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default data analysis policy</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the schema template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataQuerySecurityStrategySchema</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The list of associated workspace IDs.</para>
        /// </summary>
        [NameInMap("Workspaces")]
        [Validation(Required=false)]
        public List<long?> Workspaces { get; set; }

    }

}
