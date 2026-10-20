// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class FindBestMatchSecurityStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public FindBestMatchSecurityStrategyResponseBodyData Data { get; set; }
        public class FindBestMatchSecurityStrategyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The purchased DataWorks edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public string Edition { get; set; }

            /// <summary>
            /// <para>The name of the purchased DataWorks edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Standard Edition</para>
            /// </summary>
            [NameInMap("EditionDisplayName")]
            [Validation(Required=false)]
            public string EditionDisplayName { get; set; }

            /// <summary>
            /// <para>The security policy.</para>
            /// </summary>
            [NameInMap("SecurityStrategy")]
            [Validation(Required=false)]
            public FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategy SecurityStrategy { get; set; }
            public class FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategy : TeaModel {
                /// <summary>
                /// <para>The <b>policy content</b>. For more information, see the StrategyContent definition.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategyContent Content { get; set; }
                public class FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategyContent : TeaModel {
                    /// <summary>
                    /// <para>The <b>control scope</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Tenant</para>
                    /// </summary>
                    [NameInMap("ControlDwScope")]
                    [Validation(Required=false)]
                    public string ControlDwScope { get; set; }

                    /// <summary>
                    /// <para>The <b>control module</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DataQuery</para>
                    /// </summary>
                    [NameInMap("ControlModule")]
                    [Validation(Required=false)]
                    public string ControlModule { get; set; }

                    /// <summary>
                    /// <para>The <b>control submodule</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MyCatalog</para>
                    /// </summary>
                    [NameInMap("ControlSubModule")]
                    [Validation(Required=false)]
                    public string ControlSubModule { get; set; }

                    /// <summary>
                    /// <para>The list of control items.</para>
                    /// <para>Note: Valid control items depend on the selected schema. For more information, see the Controller definition and the control item list for each schema.</para>
                    /// </summary>
                    [NameInMap("Controllers")]
                    [Validation(Required=false)]
                    public List<FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategyContentControllers> Controllers { get; set; }
                    public class FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategyContentControllers : TeaModel {
                        /// <summary>
                        /// <para>The <b>default value for Basic Edition</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("BasicEditionDefaultValue")]
                        [Validation(Required=false)]
                        public object BasicEditionDefaultValue { get; set; }

                        /// <summary>
                        /// <para>The valid value range [min, max] for Basic Edition.</para>
                        /// </summary>
                        [NameInMap("BasicEditionIntervalValue")]
                        [Validation(Required=false)]
                        public List<int?> BasicEditionIntervalValue { get; set; }

                        /// <summary>
                        /// <para>The identifier of the control item. For valid values, see the control item list for each schema.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>viewCount</para>
                        /// </summary>
                        [NameInMap("Controller")]
                        [Validation(Required=false)]
                        public string Controller { get; set; }

                        /// <summary>
                        /// <para>The <b>value type (Boolean/Integer/Long/String)</b>.</para>
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
                        /// <para>Query results - Maximum number of records displayed at a time</para>
                        /// </summary>
                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        /// <summary>
                        /// <para>The <b>English display name</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Query Results - Single Display Record Limit</para>
                        /// </summary>
                        [NameInMap("DisplayNameEn")]
                        [Validation(Required=false)]
                        public string DisplayNameEn { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the control item is <b>enabled</b>.</para>
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
                        /// <para>The valid value range [min, max] for Enterprise Edition.</para>
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
                        /// <para>The valid value range [min, max] for Professional Edition.</para>
                        /// </summary>
                        [NameInMap("ProfessionalEditionIntervalValue")]
                        [Validation(Required=false)]
                        public List<int?> ProfessionalEditionIntervalValue { get; set; }

                        /// <summary>
                        /// <para>The <b>default value for Standard Edition</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10000</para>
                        /// </summary>
                        [NameInMap("StandardEditionDefaultValue")]
                        [Validation(Required=false)]
                        public object StandardEditionDefaultValue { get; set; }

                        /// <summary>
                        /// <para>The valid value range [min, max] for Standard Edition.</para>
                        /// </summary>
                        [NameInMap("StandardEditionIntervalValue")]
                        [Validation(Required=false)]
                        public List<int?> StandardEditionIntervalValue { get; set; }

                        /// <summary>
                        /// <para>The <b>user-configured value. The data type depends on the ControllerValueType</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("UserConfigValue")]
                        [Validation(Required=false)]
                        public object UserConfigValue { get; set; }

                    }

                    /// <summary>
                    /// <para>The <b>display name</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Data Analysis</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The <b>English display name</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Data Query</para>
                    /// </summary>
                    [NameInMap("DisplayNameEn")]
                    [Validation(Required=false)]
                    public string DisplayNameEn { get; set; }

                    /// <summary>
                    /// <para>The <b>schema name</b>.</para>
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
                    /// <para>The system policy name. If this parameter is not empty, automatic creation of a default policy is triggered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SYSTEM_GENERATE_DEFAULT_DATA_QUERY</para>
                    /// </summary>
                    [NameInMap("SystemPolicyName")]
                    [Validation(Required=false)]
                    public string SystemPolicyName { get; set; }

                }

                /// <summary>
                /// <para>The <b>control scope</b> (Workspace/Tenant).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tenant</para>
                /// </summary>
                [NameInMap("ControlDwScope")]
                [Validation(Required=false)]
                public string ControlDwScope { get; set; }

                /// <summary>
                /// <para>The <b>control module</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataQuery</para>
                /// </summary>
                [NameInMap("ControlModule")]
                [Validation(Required=false)]
                public string ControlModule { get; set; }

                /// <summary>
                /// <para>The <b>control submodule</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyCatalog</para>
                /// </summary>
                [NameInMap("ControlSubModule")]
                [Validation(Required=false)]
                public string ControlSubModule { get; set; }

                /// <summary>
                /// <para>The creation time in the YYYY-MM-DDTHH:mm:ss format. The time zone is not specified in the current document.</para>
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
                /// <para>The <b>policy description</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Controls the security behavior of query results in the Data Analysis module</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the policy is <b>enabled</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The <b>policy ID</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The <b>policy name</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default Data Analysis policy</para>
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
                /// <para>The <b>schema template name</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataQuerySecurityStrategySchema</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The update time in the YYYY-MM-DDTHH:mm:ss format. The time zone is not specified in the current document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-05-25T20:46:19</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The user ID of the last updater.</para>
                /// 
                /// <b>Example:</b>
                /// <para>207947397706614297</para>
                /// </summary>
                [NameInMap("Updater")]
                [Validation(Required=false)]
                public string Updater { get; set; }

                /// <summary>
                /// <para>The <b>list of associated workspace IDs</b>.</para>
                /// </summary>
                [NameInMap("Workspaces")]
                [Validation(Required=false)]
                public List<long?> Workspaces { get; set; }

            }

        }

        /// <summary>
        /// <para>The <b>API request ID</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17***903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
