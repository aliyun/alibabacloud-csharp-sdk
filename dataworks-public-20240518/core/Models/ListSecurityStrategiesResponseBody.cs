// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListSecurityStrategiesResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListSecurityStrategiesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListSecurityStrategiesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("SecurityStrategies")]
            [Validation(Required=false)]
            public List<ListSecurityStrategiesResponseBodyPagingInfoSecurityStrategies> SecurityStrategies { get; set; }
            public class ListSecurityStrategiesResponseBodyPagingInfoSecurityStrategies : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public ListSecurityStrategiesResponseBodyPagingInfoSecurityStrategiesContent Content { get; set; }
                public class ListSecurityStrategiesResponseBodyPagingInfoSecurityStrategiesContent : TeaModel {
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
                    public List<ListSecurityStrategiesResponseBodyPagingInfoSecurityStrategiesContentControllers> Controllers { get; set; }
                    public class ListSecurityStrategiesResponseBodyPagingInfoSecurityStrategiesContentControllers : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10000</para>
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

                        [NameInMap("Enable")]
                        [Validation(Required=false)]
                        public bool? Enable { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10000</para>
                        /// </summary>
                        [NameInMap("EnterpriseEditionDefaultValue")]
                        [Validation(Required=false)]
                        public object EnterpriseEditionDefaultValue { get; set; }

                        [NameInMap("EnterpriseEditionIntervalValue")]
                        [Validation(Required=false)]
                        public List<int?> EnterpriseEditionIntervalValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10000</para>
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
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

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
                /// <para>203322746501002787</para>
                /// </summary>
                [NameInMap("Updater")]
                [Validation(Required=false)]
                public string Updater { get; set; }

                [NameInMap("Workspaces")]
                [Validation(Required=false)]
                public List<long?> Workspaces { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc5df3a17****903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
