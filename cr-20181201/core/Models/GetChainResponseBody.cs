// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetChainResponseBody : TeaModel {
        [NameInMap("ChainConfig")]
        [Validation(Required=false)]
        public GetChainResponseBodyChainConfig ChainConfig { get; set; }
        public class GetChainResponseBodyChainConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cci-lz3ycgo69ukt****</para>
            /// </summary>
            [NameInMap("ChainConfigId")]
            [Validation(Required=false)]
            public string ChainConfigId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetChainResponseBodyChainConfigNodes> Nodes { get; set; }
            public class GetChainResponseBodyChainConfigNodes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("NodeConfig")]
                [Validation(Required=false)]
                public GetChainResponseBodyChainConfigNodesNodeConfig NodeConfig { get; set; }
                public class GetChainResponseBodyChainConfigNodesNodeConfig : TeaModel {
                    [NameInMap("DenyPolicy")]
                    [Validation(Required=false)]
                    public GetChainResponseBodyChainConfigNodesNodeConfigDenyPolicy DenyPolicy { get; set; }
                    public class GetChainResponseBodyChainConfigNodesNodeConfigDenyPolicy : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>BLOCK</para>
                        /// </summary>
                        [NameInMap("Action")]
                        [Validation(Required=false)]
                        public string Action { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>identification,hc_image_exploit</para>
                        /// </summary>
                        [NameInMap("BaselineList")]
                        [Validation(Required=false)]
                        public string BaselineList { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("IssueCount")]
                        [Validation(Required=false)]
                        public string IssueCount { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>HIGH</para>
                        /// </summary>
                        [NameInMap("IssueLevel")]
                        [Validation(Required=false)]
                        public string IssueLevel { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CVE-2020-8286,CVE-2020-8285</para>
                        /// </summary>
                        [NameInMap("IssueList")]
                        [Validation(Required=false)]
                        public string IssueList { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>AND</para>
                        /// </summary>
                        [NameInMap("Logic")]
                        [Validation(Required=false)]
                        public string Logic { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>mutate_cockhorse,abnormal_program</para>
                        /// </summary>
                        [NameInMap("MaliciousList")]
                        [Validation(Required=false)]
                        public string MaliciousList { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Retry")]
                    [Validation(Required=false)]
                    public int? Retry { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ACR_SCAN_SERVICE</para>
                    /// </summary>
                    [NameInMap("ScanEngine")]
                    [Validation(Required=false)]
                    public string ScanEngine { get; set; }

                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public long? Timeout { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VULNERABILITY_SCANNING</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

            }

            [NameInMap("Routers")]
            [Validation(Required=false)]
            public List<GetChainResponseBodyChainConfigRouters> Routers { get; set; }
            public class GetChainResponseBodyChainConfigRouters : TeaModel {
                [NameInMap("From")]
                [Validation(Required=false)]
                public GetChainResponseBodyChainConfigRoutersFrom From { get; set; }
                public class GetChainResponseBodyChainConfigRoutersFrom : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DOCKER_IMAGE_BUILD</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                }

                [NameInMap("To")]
                [Validation(Required=false)]
                public GetChainResponseBodyChainConfigRoutersTo To { get; set; }
                public class GetChainResponseBodyChainConfigRoutersTo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DOCKER_IMAGE_PUSH</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>chi-0ops0gsmw5x2****</para>
        /// </summary>
        [NameInMap("ChainId")]
        [Validation(Required=false)]
        public string ChainId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1638255427000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cri-4cdrlqmhn4gm****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1638259914000</para>
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C87993B5-7D61-5CAC-8D64-1AC732DD69FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScopeExclude")]
        [Validation(Required=false)]
        public List<string> ScopeExclude { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>crr-nyrh2oko32xb****</para>
        /// </summary>
        [NameInMap("ScopeId")]
        [Validation(Required=false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>REPOSITORY</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
