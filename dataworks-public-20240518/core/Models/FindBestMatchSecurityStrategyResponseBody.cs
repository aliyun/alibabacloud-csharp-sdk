// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class FindBestMatchSecurityStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>Data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public FindBestMatchSecurityStrategyResponseBodyData Data { get; set; }
        public class FindBestMatchSecurityStrategyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Purchased DataWorks edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public string Edition { get; set; }

            /// <summary>
            /// <para>Purchased DataWorks edition name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>标准版</para>
            /// </summary>
            [NameInMap("EditionDisplayName")]
            [Validation(Required=false)]
            public string EditionDisplayName { get; set; }

            /// <summary>
            /// <para>Security policy.</para>
            /// </summary>
            [NameInMap("SecurityStrategy")]
            [Validation(Required=false)]
            public FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategy SecurityStrategy { get; set; }
            public class FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategy : TeaModel {
                /// <summary>
                /// <para><b>Policy content</b>. Refer to the StrategyContent definition.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategyContent Content { get; set; }
                public class FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategyContent : TeaModel {
                    /// <summary>
                    /// <para><b>Control scope</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Tenant</para>
                    /// </summary>
                    [NameInMap("ControlDwScope")]
                    [Validation(Required=false)]
                    public string ControlDwScope { get; set; }

                    /// <summary>
                    /// <para><b>Control module</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DataQuery</para>
                    /// </summary>
                    [NameInMap("ControlModule")]
                    [Validation(Required=false)]
                    public string ControlModule { get; set; }

                    /// <summary>
                    /// <para><b>Control sub-module</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MyCatalog</para>
                    /// </summary>
                    [NameInMap("ControlSubModule")]
                    [Validation(Required=false)]
                    public string ControlSubModule { get; set; }

                    /// <summary>
                    /// <para>Controller list.</para>
                    /// <para>Note: Valid controllers depend on the selected Schema. Refer to the Controller definition and the controller list of each Schema.</para>
                    /// </summary>
                    [NameInMap("Controllers")]
                    [Validation(Required=false)]
                    public List<FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategyContentControllers> Controllers { get; set; }
                    public class FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategyContentControllers : TeaModel {
                        /// <summary>
                        /// <para><b>Basic Edition default value</b></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("BasicEditionDefaultValue")]
                        [Validation(Required=false)]
                        public object BasicEditionDefaultValue { get; set; }

                        /// <summary>
                        /// <para>Basic Edition valid value range [min, max].</para>
                        /// </summary>
                        [NameInMap("BasicEditionIntervalValue")]
                        [Validation(Required=false)]
                        public List<int?> BasicEditionIntervalValue { get; set; }

                        /// <summary>
                        /// <para>Controller identifier. For values, see the controller list of each Schema.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>viewCount</para>
                        /// </summary>
                        [NameInMap("Controller")]
                        [Validation(Required=false)]
                        public string Controller { get; set; }

                        /// <summary>
                        /// <para><b>Value type (Boolean/Integer/Long/String)</b></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Integer</para>
                        /// </summary>
                        [NameInMap("ControllerValueType")]
                        [Validation(Required=false)]
                        public string ControllerValueType { get; set; }

                        /// <summary>
                        /// <para>Display name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>查询结果-单次展示记录值上限</para>
                        /// </summary>
                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        /// <summary>
                        /// <para><b>English display name</b></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Query Results - Single Display Record Limit</para>
                        /// </summary>
                        [NameInMap("DisplayNameEn")]
                        [Validation(Required=false)]
                        public string DisplayNameEn { get; set; }

                        /// <summary>
                        /// <para><b>Whether this controller is enabled</b></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Enable")]
                        [Validation(Required=false)]
                        public bool? Enable { get; set; }

                        /// <summary>
                        /// <para>Enterprise Edition default value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>500000</para>
                        /// </summary>
                        [NameInMap("EnterpriseEditionDefaultValue")]
                        [Validation(Required=false)]
                        public object EnterpriseEditionDefaultValue { get; set; }

                        /// <summary>
                        /// <para>Enterprise Edition valid value range [min, max].</para>
                        /// </summary>
                        [NameInMap("EnterpriseEditionIntervalValue")]
                        [Validation(Required=false)]
                        public List<int?> EnterpriseEditionIntervalValue { get; set; }

                        /// <summary>
                        /// <para>Professional Edition default value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>200000</para>
                        /// </summary>
                        [NameInMap("ProfessionalEditionDefaultValue")]
                        [Validation(Required=false)]
                        public object ProfessionalEditionDefaultValue { get; set; }

                        /// <summary>
                        /// <para>Professional Edition valid value range [min, max].</para>
                        /// </summary>
                        [NameInMap("ProfessionalEditionIntervalValue")]
                        [Validation(Required=false)]
                        public List<int?> ProfessionalEditionIntervalValue { get; set; }

                        /// <summary>
                        /// <para><b>Standard Edition default value</b></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10000</para>
                        /// </summary>
                        [NameInMap("StandardEditionDefaultValue")]
                        [Validation(Required=false)]
                        public object StandardEditionDefaultValue { get; set; }

                        /// <summary>
                        /// <para>Standard Edition valid value range [min, max].</para>
                        /// </summary>
                        [NameInMap("StandardEditionIntervalValue")]
                        [Validation(Required=false)]
                        public List<int?> StandardEditionIntervalValue { get; set; }

                        /// <summary>
                        /// <para><b>User-configured value. The type depends on ControllerValueType.</b></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("UserConfigValue")]
                        [Validation(Required=false)]
                        public object UserConfigValue { get; set; }

                    }

                    /// <summary>
                    /// <para><b>Display name</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>数据分析</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para><b>English display name</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Data Query</para>
                    /// </summary>
                    [NameInMap("DisplayNameEn")]
                    [Validation(Required=false)]
                    public string DisplayNameEn { get; set; }

                    /// <summary>
                    /// <para><b>Schema name</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DataQuerySecurityStrategySchema</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>System policy display name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Default system generate data query policy</para>
                    /// </summary>
                    [NameInMap("SystemPolicyDisplayName")]
                    [Validation(Required=false)]
                    public string SystemPolicyDisplayName { get; set; }

                    /// <summary>
                    /// <para>System policy name (when not empty, the system automatically creates a default policy).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SYSTEM_GENERATE_DEFAULT_DATA_QUERY</para>
                    /// </summary>
                    [NameInMap("SystemPolicyName")]
                    [Validation(Required=false)]
                    public string SystemPolicyName { get; set; }

                }

                /// <summary>
                /// <para><b>Control scope</b> (Workspace/Tenant).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tenant</para>
                /// </summary>
                [NameInMap("ControlDwScope")]
                [Validation(Required=false)]
                public string ControlDwScope { get; set; }

                /// <summary>
                /// <para><b>Control module</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>DataQuery</para>
                /// </summary>
                [NameInMap("ControlModule")]
                [Validation(Required=false)]
                public string ControlModule { get; set; }

                /// <summary>
                /// <para><b>Control sub-module</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>MyCatalog</para>
                /// </summary>
                [NameInMap("ControlSubModule")]
                [Validation(Required=false)]
                public string ControlSubModule { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-05-25T20:46:19</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Creator user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>203322746501002787</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para><b>Policy description</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>控制数据分析模块的查询结果安全行为</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para><b>Whether enabled</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para><b>Policy ID</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para><b>Policy name</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>默认数据分析策略</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>System default policy source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("OriginPolicyId")]
                [Validation(Required=false)]
                public long? OriginPolicyId { get; set; }

                /// <summary>
                /// <para><b>Schema template name</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>DataQuerySecurityStrategySchema</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>Update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-05-25T20:46:19</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>Last updater user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>207947397706614297</para>
                /// </summary>
                [NameInMap("Updater")]
                [Validation(Required=false)]
                public string Updater { get; set; }

                /// <summary>
                /// <para><b>Associated workspace ID list</b></para>
                /// </summary>
                [NameInMap("Workspaces")]
                [Validation(Required=false)]
                public List<long?> Workspaces { get; set; }

            }

        }

        /// <summary>
        /// <para><b>API request ID</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17***903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
