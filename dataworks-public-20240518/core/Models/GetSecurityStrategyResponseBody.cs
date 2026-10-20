// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetSecurityStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para><b>The API request ID.</b></para>
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
            /// <para>The policy content. The content is constrained by SecurityStrategySchema.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public GetSecurityStrategyResponseBodySecurityStrategyContent Content { get; set; }
            public class GetSecurityStrategyResponseBodySecurityStrategyContent : TeaModel {
                /// <summary>
                /// <para>The effective scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tenant</para>
                /// </summary>
                [NameInMap("ControlDwScope")]
                [Validation(Required=false)]
                public string ControlDwScope { get; set; }

                /// <summary>
                /// <para>The control module. The SecurityStrategySchema.controlModule associated with the current policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataQuery</para>
                /// </summary>
                [NameInMap("ControlModule")]
                [Validation(Required=false)]
                public string ControlModule { get; set; }

                /// <summary>
                /// <para>The control sub-module. The SecurityStrategySchema.controlSubModule associated with the current policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyCatalog</para>
                /// </summary>
                [NameInMap("ControlSubModule")]
                [Validation(Required=false)]
                public string ControlSubModule { get; set; }

                /// <summary>
                /// <para>The list of control items.</para>
                /// <para>Note: Valid control items depend on the selected schema. Refer to the controller definition and the control item list for each schema.</para>
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
                    /// <para>The valid value interval [min, max] for Basic Edition.</para>
                    /// </summary>
                    [NameInMap("BasicEditionIntervalValue")]
                    [Validation(Required=false)]
                    public List<int?> BasicEditionIntervalValue { get; set; }

                    /// <summary>
                    /// <para><b>The control item identifier.</b> For valid values, see the control item list for each schema.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>viewCount</para>
                    /// </summary>
                    [NameInMap("Controller")]
                    [Validation(Required=false)]
                    public string Controller { get; set; }

                    /// <summary>
                    /// <para><b>The value type</b> (Boolean/Integer/Long/String).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Integer</para>
                    /// </summary>
                    [NameInMap("ControllerValueType")]
                    [Validation(Required=false)]
                    public string ControllerValueType { get; set; }

                    /// <summary>
                    /// <para><b>The display name.</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Query results - Maximum number of records displayed at a time</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para><b>The English display name.</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Query Results - Single Display Record Limit</para>
                    /// </summary>
                    [NameInMap("DisplayNameEn")]
                    [Validation(Required=false)]
                    public string DisplayNameEn { get; set; }

                    /// <summary>
                    /// <para><b>Specifies whether the control item is enabled.</b></para>
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
                    /// <para>The valid value interval [min, max] for Enterprise Edition.</para>
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
                    /// <para>The valid value interval [min, max] for Professional Edition.</para>
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
                    /// <para>The valid value interval [min, max] for Standard Edition.</para>
                    /// </summary>
                    [NameInMap("StandardEditionIntervalValue")]
                    [Validation(Required=false)]
                    public List<int?> StandardEditionIntervalValue { get; set; }

                    /// <summary>
                    /// <para><b>The user-configured value.</b> The type depends on ControllerValueType.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("UserConfigValue")]
                    [Validation(Required=false)]
                    public object UserConfigValue { get; set; }

                }

                /// <summary>
                /// <para>The SecurityStrategySchema.displayName associated with the current policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data Analysis</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The SecurityStrategySchema.displayNameEn associated with the current policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data Query</para>
                /// </summary>
                [NameInMap("DisplayNameEn")]
                [Validation(Required=false)]
                public string DisplayNameEn { get; set; }

                /// <summary>
                /// <para>The SecurityStrategySchema.name associated with the current policy.</para>
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
                /// <para>The system policy name. If this parameter is not empty, the system performs automatic creation of a default policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_GENERATE_DEFAULT_DATA_QUERY</para>
                /// </summary>
                [NameInMap("SystemPolicyName")]
                [Validation(Required=false)]
                public string SystemPolicyName { get; set; }

            }

            /// <summary>
            /// <para>The control scope (Workspace/Tenant).</para>
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
            /// <para>The control sub-module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyCatalog</para>
            /// </summary>
            [NameInMap("ControlSubModule")]
            [Validation(Required=false)]
            public string ControlSubModule { get; set; }

            /// <summary>
            /// <para>The creation time. The format is YYYY-MM-DDTHH:mm:ss. The time zone is not specified in the current document.</para>
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
            /// <para>Controls the security behavior of query results in the Data Analysis module</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether the policy is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para><b>The policy ID.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para><b>The policy name.</b></para>
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
            /// <para>The schema template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataQuerySecurityStrategySchema</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The update time. The format is YYYY-MM-DDTHH:mm:ss. The time zone is not specified in the current document.</para>
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
