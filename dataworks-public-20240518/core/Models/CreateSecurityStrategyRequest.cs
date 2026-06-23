// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateSecurityStrategyRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token that ensures request idempotency, preventing duplicate operations if you retry the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABFUOEUOTRTRJKE</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The content of the strategy. This value is constrained by the <c>SecurityStrategySchema</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public CreateSecurityStrategyRequestContent Content { get; set; }
        public class CreateSecurityStrategyRequestContent : TeaModel {
            /// <summary>
            /// <para>The control scope. This corresponds to the <c>controlDwScope</c> property of the <c>SecurityStrategySchema</c> associated with the current strategy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tenant</para>
            /// </summary>
            [NameInMap("ControlDwScope")]
            [Validation(Required=false)]
            public string ControlDwScope { get; set; }

            /// <summary>
            /// <para>The control module. This corresponds to the <c>controlModule</c> property of the <c>SecurityStrategySchema</c> associated with the current strategy.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataStudio</para>
            /// </summary>
            [NameInMap("ControlModule")]
            [Validation(Required=false)]
            public string ControlModule { get; set; }

            /// <summary>
            /// <para>The control submodule. This corresponds to the <c>controlSubModule</c> property of the <c>SecurityStrategySchema</c> associated with the current strategy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyCatalog</para>
            /// </summary>
            [NameInMap("ControlSubModule")]
            [Validation(Required=false)]
            public string ControlSubModule { get; set; }

            /// <summary>
            /// <para>A list of controllers.</para>
            /// <para><b>Note:</b> Valid controllers depend on the selected schema. For more information, see the controller definitions and the list of controllers for each schema.</para>
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
                /// <para>The valid value interval for Basic Edition, in the format <c>[min, max]</c>.</para>
                /// </summary>
                [NameInMap("BasicEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> BasicEditionIntervalValue { get; set; }

                /// <summary>
                /// <para>The controller identifier. For valid values, see the list of controllers for each schema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>viewCount</para>
                /// </summary>
                [NameInMap("Controller")]
                [Validation(Required=false)]
                public string Controller { get; set; }

                /// <summary>
                /// <para>The value type. Valid values: <c>Boolean</c>, <c>Integer</c>, <c>Long</c>, and <c>String</c>.</para>
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
                /// <para>查询结果-单次展示记录值上限</para>
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
                /// <para>Specifies whether to enable this controller.</para>
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
                /// <para>The valid value interval for Enterprise Edition, in the format <c>[min, max]</c>.</para>
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
                /// <para>The valid value interval for Professional Edition, in the format <c>[min, max]</c>.</para>
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
                /// <para>The valid value interval for Standard Edition, in the format <c>[min, max]</c>.</para>
                /// </summary>
                [NameInMap("StandardEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> StandardEditionIntervalValue { get; set; }

                /// <summary>
                /// <para>The user-configured value. The type of this value depends on the <c>ControllerValueType</c> parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("UserConfigValue")]
                [Validation(Required=false)]
                public object UserConfigValue { get; set; }

            }

            /// <summary>
            /// <para>The <c>displayName</c> property of the <c>SecurityStrategySchema</c> associated with the current strategy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>数据分析</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The <c>displayNameEn</c> property of the <c>SecurityStrategySchema</c> associated with the current strategy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data Analysis</para>
            /// </summary>
            [NameInMap("DisplayNameEn")]
            [Validation(Required=false)]
            public string DisplayNameEn { get; set; }

            /// <summary>
            /// <para>The <c>name</c> property of the <c>SecurityStrategySchema</c> associated with the current strategy.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataQuerySecurityStrategySchema</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The <c>systemPolicyDisplayName</c> property of the <c>SecurityStrategySchema</c> associated with the current strategy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default system generate data query policy</para>
            /// </summary>
            [NameInMap("SystemPolicyDisplayName")]
            [Validation(Required=false)]
            public string SystemPolicyDisplayName { get; set; }

            /// <summary>
            /// <para>The <c>systemPolicyName</c> property of the <c>SecurityStrategySchema</c> associated with the current strategy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM_GENERATE_DEFAULT_DATA_QUERY</para>
            /// </summary>
            [NameInMap("SystemPolicyName")]
            [Validation(Required=false)]
            public string SystemPolicyName { get; set; }

        }

        /// <summary>
        /// <para><b>The control scope. Valid values: Workspace and Tenant.</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tenant</para>
        /// </summary>
        [NameInMap("ControlDwScope")]
        [Validation(Required=false)]
        public string ControlDwScope { get; set; }

        /// <summary>
        /// <para><b>Control module</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataQuery</para>
        /// </summary>
        [NameInMap("ControlModule")]
        [Validation(Required=false)]
        public string ControlModule { get; set; }

        /// <summary>
        /// <para><b>Control submodule</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCatalog</para>
        /// </summary>
        [NameInMap("ControlSubModule")]
        [Validation(Required=false)]
        public string ControlSubModule { get; set; }

        /// <summary>
        /// <para><b>Strategy description</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>控制数据分析模块的查询结果安全行为</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para><b>Strategy name</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>默认数据分析策略</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para><b>Schema template name</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataQuerySecurityStrategySchema</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>A list of associated workspace IDs.</para>
        /// </summary>
        [NameInMap("Workspaces")]
        [Validation(Required=false)]
        public List<long?> Workspaces { get; set; }

    }

}
