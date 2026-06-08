// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class FindBestMatchSecurityStrategyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public FindBestMatchSecurityStrategyResponseBodyData Data { get; set; }
        public class FindBestMatchSecurityStrategyResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public string Edition { get; set; }

            [NameInMap("EditionDisplayName")]
            [Validation(Required=false)]
            public string EditionDisplayName { get; set; }

            [NameInMap("SecurityStrategy")]
            [Validation(Required=false)]
            public FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategy SecurityStrategy { get; set; }
            public class FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategy : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategyContent Content { get; set; }
                public class FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategyContent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Tenant</para>
                    /// </summary>
                    [NameInMap("ControlDwScope")]
                    [Validation(Required=false)]
                    public string ControlDwScope { get; set; }

                    /// <summary>
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

                    [NameInMap("Controllers")]
                    [Validation(Required=false)]
                    public List<FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategyContentControllers> Controllers { get; set; }
                    public class FindBestMatchSecurityStrategyResponseBodyDataSecurityStrategyContentControllers : TeaModel {
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
                        /// <para>10000</para>
                        /// </summary>
                        [NameInMap("StandardEditionDefaultValue")]
                        [Validation(Required=false)]
                        public object StandardEditionDefaultValue { get; set; }

                        [NameInMap("StandardEditionIntervalValue")]
                        [Validation(Required=false)]
                        public List<int?> StandardEditionIntervalValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>20</para>
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
                    /// <para>Data Query</para>
                    /// </summary>
                    [NameInMap("DisplayNameEn")]
                    [Validation(Required=false)]
                    public string DisplayNameEn { get; set; }

                    /// <summary>
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
                /// <b>Example:</b>
                /// <para>Tenant</para>
                /// </summary>
                [NameInMap("ControlDwScope")]
                [Validation(Required=false)]
                public string ControlDwScope { get; set; }

                /// <summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-05-25T20:46:19</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>203322746501002787</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("OriginPolicyId")]
                [Validation(Required=false)]
                public long? OriginPolicyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DataQuerySecurityStrategySchema</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-05-25T20:46:19</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>207947397706614297</para>
                /// </summary>
                [NameInMap("Updater")]
                [Validation(Required=false)]
                public string Updater { get; set; }

                [NameInMap("Workspaces")]
                [Validation(Required=false)]
                public List<long?> Workspaces { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc5df3a17***903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
