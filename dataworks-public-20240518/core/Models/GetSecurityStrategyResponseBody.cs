// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetSecurityStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17****903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security policy.</para>
        /// </summary>
        [NameInMap("SecurityStrategy")]
        [Validation(Required=false)]
        public GetSecurityStrategyResponseBodySecurityStrategy SecurityStrategy { get; set; }
        public class GetSecurityStrategyResponseBodySecurityStrategy : TeaModel {
            /// <summary>
            /// <para>The content of the security policy. Its structure is defined by the <c>SecurityStrategySchema</c>.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public GetSecurityStrategyResponseBodySecurityStrategyContent Content { get; set; }
            public class GetSecurityStrategyResponseBodySecurityStrategyContent : TeaModel {
                /// <summary>
                /// <para>The scope where the policy is effective. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tenant</para>
                /// </summary>
                [NameInMap("ControlDwScope")]
                [Validation(Required=false)]
                public string ControlDwScope { get; set; }

                /// <summary>
                /// <para>The control module. This value corresponds to <c>controlModule</c> in the associated <c>SecurityStrategySchema</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataQuery</para>
                /// </summary>
                [NameInMap("ControlModule")]
                [Validation(Required=false)]
                public string ControlModule { get; set; }

                /// <summary>
                /// <para>The control submodule. This value corresponds to <c>controlSubModule</c> in the associated <c>SecurityStrategySchema</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyCatalog</para>
                /// </summary>
                [NameInMap("ControlSubModule")]
                [Validation(Required=false)]
                public string ControlSubModule { get; set; }

                /// <summary>
                /// <para>A list of controllers.</para>
                /// <para><b>Note:</b> The available controllers depend on the selected schema. See the documentation for your schema for a list of valid controllers.</para>
                /// </summary>
                [NameInMap("Controllers")]
                [Validation(Required=false)]
                public List<GetSecurityStrategyResponseBodySecurityStrategyContentControllers> Controllers { get; set; }
                public class GetSecurityStrategyResponseBodySecurityStrategyContentControllers : TeaModel {
                    /// <summary>
                    /// <para>The default value for Basic Edition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("BasicEditionDefaultValue")]
                    [Validation(Required=false)]
                    public object BasicEditionDefaultValue { get; set; }

                    /// <summary>
                    /// <para>The valid value range for Basic Edition, specified as an array <c>[min, max]</c>.</para>
                    /// </summary>
                    [NameInMap("BasicEditionIntervalValue")]
                    [Validation(Required=false)]
                    public List<int?> BasicEditionIntervalValue { get; set; }

                    /// <summary>
                    /// <para>The identifier for the controller. For valid values, see the documentation for the relevant schema.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>viewCount</para>
                    /// </summary>
                    [NameInMap("Controller")]
                    [Validation(Required=false)]
                    public string Controller { get; set; }

                    /// <summary>
                    /// <para>The value type of the controller. Valid values are <c>Boolean</c>, <c>Integer</c>, <c>Long</c>, and <c>String</c>.</para>
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
                    /// <para>The display name in English.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Query Results - Single Display Record Limit</para>
                    /// </summary>
                    [NameInMap("DisplayNameEn")]
                    [Validation(Required=false)]
                    public string DisplayNameEn { get; set; }

                    /// <summary>
                    /// <para>Whether the controller is enabled.</para>
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
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("EnterpriseEditionDefaultValue")]
                    [Validation(Required=false)]
                    public object EnterpriseEditionDefaultValue { get; set; }

                    /// <summary>
                    /// <para>The valid value range for Enterprise Edition, specified as an array <c>[min, max]</c>.</para>
                    /// </summary>
                    [NameInMap("EnterpriseEditionIntervalValue")]
                    [Validation(Required=false)]
                    public List<int?> EnterpriseEditionIntervalValue { get; set; }

                    /// <summary>
                    /// <para>The default value for Professional Edition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("ProfessionalEditionDefaultValue")]
                    [Validation(Required=false)]
                    public object ProfessionalEditionDefaultValue { get; set; }

                    /// <summary>
                    /// <para>The valid value range for Professional Edition, specified as an array <c>[min, max]</c>.</para>
                    /// </summary>
                    [NameInMap("ProfessionalEditionIntervalValue")]
                    [Validation(Required=false)]
                    public List<int?> ProfessionalEditionIntervalValue { get; set; }

                    /// <summary>
                    /// <para>The default value for Standard Edition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("StandardEditionDefaultValue")]
                    [Validation(Required=false)]
                    public object StandardEditionDefaultValue { get; set; }

                    /// <summary>
                    /// <para>The valid value range for Standard Edition, specified as an array <c>[min, max]</c>.</para>
                    /// </summary>
                    [NameInMap("StandardEditionIntervalValue")]
                    [Validation(Required=false)]
                    public List<int?> StandardEditionIntervalValue { get; set; }

                    /// <summary>
                    /// <para>The value configured by the user. The data type of this value is specified by the <c>ControllerValueType</c> parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("UserConfigValue")]
                    [Validation(Required=false)]
                    public object UserConfigValue { get; set; }

                }

                /// <summary>
                /// <para>The <c>displayName</c> field from the associated <c>SecurityStrategySchema</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>数据分析</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The <c>displayNameEn</c> field from the associated <c>SecurityStrategySchema</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data Query</para>
                /// </summary>
                [NameInMap("DisplayNameEn")]
                [Validation(Required=false)]
                public string DisplayNameEn { get; set; }

                /// <summary>
                /// <para>The <c>name</c> field from the associated <c>SecurityStrategySchema</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataQuerySecurityStrategySchema</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The display name of the system policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default system generate data query policy</para>
                /// </summary>
                [NameInMap("SystemPolicyDisplayName")]
                [Validation(Required=false)]
                public string SystemPolicyDisplayName { get; set; }

                /// <summary>
                /// <para>The name of the system policy. If specified, a default policy is automatically created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_GENERATE_DEFAULT_DATA_QUERY</para>
                /// </summary>
                [NameInMap("SystemPolicyName")]
                [Validation(Required=false)]
                public string SystemPolicyName { get; set; }

            }

            /// <summary>
            /// <para>The scope where the policy is effective. Valid values: <c>Workspace</c> or <c>Tenant</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tenant</para>
            /// </summary>
            [NameInMap("ControlDwScope")]
            [Validation(Required=false)]
            public string ControlDwScope { get; set; }

            /// <summary>
            /// <para>The control module.</para>
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
            /// <para>The time when the security policy was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-25T20:46:19</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203322746501002787</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The policy description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>控制数据分析模块的查询结果安全行为</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Whether the security policy is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>默认数据分析策略</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The source ID of the default system policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("OriginPolicyId")]
            [Validation(Required=false)]
            public long? OriginPolicyId { get; set; }

            /// <summary>
            /// <para>The name of the schema template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataQuerySecurityStrategySchema</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The time when the security policy was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-25T20:46:19</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the last updater.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203322746501002787</para>
            /// </summary>
            [NameInMap("Updater")]
            [Validation(Required=false)]
            public string Updater { get; set; }

            /// <summary>
            /// <para>The list of associated workspace IDs.</para>
            /// </summary>
            [NameInMap("Workspaces")]
            [Validation(Required=false)]
            public List<long?> Workspaces { get; set; }

        }

    }

}
