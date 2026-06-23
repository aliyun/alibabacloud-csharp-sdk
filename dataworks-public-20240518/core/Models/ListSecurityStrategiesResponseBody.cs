// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListSecurityStrategiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination result.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListSecurityStrategiesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListSecurityStrategiesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of security policies.</para>
            /// </summary>
            [NameInMap("SecurityStrategies")]
            [Validation(Required=false)]
            public List<ListSecurityStrategiesResponseBodyPagingInfoSecurityStrategies> SecurityStrategies { get; set; }
            public class ListSecurityStrategiesResponseBodyPagingInfoSecurityStrategies : TeaModel {
                /// <summary>
                /// <para>The policy content. The content is constrained by <c>SecurityStrategySchema</c>.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public ListSecurityStrategiesResponseBodyPagingInfoSecurityStrategiesContent Content { get; set; }
                public class ListSecurityStrategiesResponseBodyPagingInfoSecurityStrategiesContent : TeaModel {
                    /// <summary>
                    /// <para>The control scope.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Tenant</para>
                    /// </summary>
                    [NameInMap("ControlDwScope")]
                    [Validation(Required=false)]
                    public string ControlDwScope { get; set; }

                    /// <summary>
                    /// <para>The control module. This value is from the <c>controlModule</c> property of the associated <c>SecurityStrategySchema</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DataQuery</para>
                    /// </summary>
                    [NameInMap("ControlModule")]
                    [Validation(Required=false)]
                    public string ControlModule { get; set; }

                    /// <summary>
                    /// <para>The control submodule. This value is from the <c>controlSubModule</c> property of the associated <c>SecurityStrategySchema</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MyCatalog</para>
                    /// </summary>
                    [NameInMap("ControlSubModule")]
                    [Validation(Required=false)]
                    public string ControlSubModule { get; set; }

                    /// <summary>
                    /// <para>A list of control items. The available items depend on the schema. For details, see the <c>Controller</c> definition and the list of control items for each schema.</para>
                    /// </summary>
                    [NameInMap("Controllers")]
                    [Validation(Required=false)]
                    public List<ListSecurityStrategiesResponseBodyPagingInfoSecurityStrategiesContentControllers> Controllers { get; set; }
                    public class ListSecurityStrategiesResponseBodyPagingInfoSecurityStrategiesContentControllers : TeaModel {
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
                        /// <para>The valid value range for Basic Edition, specified as [min, max].</para>
                        /// </summary>
                        [NameInMap("BasicEditionIntervalValue")]
                        [Validation(Required=false)]
                        public List<int?> BasicEditionIntervalValue { get; set; }

                        /// <summary>
                        /// <para>The identifier of the control item. For valid values, see the list of control items for each schema.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>viewCount</para>
                        /// </summary>
                        [NameInMap("Controller")]
                        [Validation(Required=false)]
                        public string Controller { get; set; }

                        /// <summary>
                        /// <para>The data type of the value. Valid values: <c>Boolean</c>, <c>Integer</c>, <c>Long</c>, and <c>String</c>.</para>
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
                        /// <para>Whether the control item is enabled.</para>
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
                        /// <para>The valid value range for Enterprise Edition, specified as [min, max].</para>
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
                        /// <para>The valid value range for Professional Edition, specified as [min, max].</para>
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
                        /// <para>The valid value range for Standard Edition, specified as [min, max].</para>
                        /// </summary>
                        [NameInMap("StandardEditionIntervalValue")]
                        [Validation(Required=false)]
                        public List<int?> StandardEditionIntervalValue { get; set; }

                        /// <summary>
                        /// <para>The value set for the control item. The data type of this value is specified by <c>ControllerValueType</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("UserConfigValue")]
                        [Validation(Required=false)]
                        public object UserConfigValue { get; set; }

                    }

                    /// <summary>
                    /// <para>The <c>displayName</c> of the associated <c>SecurityStrategySchema</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>数据分析</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The <c>displayNameEn</c> of the associated <c>SecurityStrategySchema</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Data Query</para>
                    /// </summary>
                    [NameInMap("DisplayNameEn")]
                    [Validation(Required=false)]
                    public string DisplayNameEn { get; set; }

                    /// <summary>
                    /// <para>The <c>name</c> of the associated <c>SecurityStrategySchema</c>.</para>
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
                    /// <para>The name of the system policy. If this property is not empty, the system automatically creates a default policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SYSTEM_GENERATE_DEFAULT_DATA_QUERY</para>
                    /// </summary>
                    [NameInMap("SystemPolicyName")]
                    [Validation(Required=false)]
                    public string SystemPolicyName { get; set; }

                }

                /// <summary>
                /// <para>The control scope. Valid values: <c>Workspace</c> and <c>Tenant</c>.</para>
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
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-05-25T20:46:19</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The user ID of the creator.</para>
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
                /// <para>Whether the policy is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

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
                /// <para>The source ID of the system default policy.</para>
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
                /// <para>The time of the last update.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-05-25T20:46:19</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The ID of the user who last updated the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>203322746501002787</para>
                /// </summary>
                [NameInMap("Updater")]
                [Validation(Required=false)]
                public string Updater { get; set; }

                /// <summary>
                /// <para>The associated workspace IDs.</para>
                /// </summary>
                [NameInMap("Workspaces")]
                [Validation(Required=false)]
                public List<long?> Workspaces { get; set; }

            }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17****903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
