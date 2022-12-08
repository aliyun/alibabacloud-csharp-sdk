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
            [NameInMap("ChainConfigId")]
            [Validation(Required=false)]
            public string ChainConfigId { get; set; }

            [NameInMap("IsActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetChainResponseBodyChainConfigNodes> Nodes { get; set; }
            public class GetChainResponseBodyChainConfigNodes : TeaModel {
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
                        [NameInMap("Action")]
                        [Validation(Required=false)]
                        public string Action { get; set; }

                        [NameInMap("BaselineList")]
                        [Validation(Required=false)]
                        public string BaselineList { get; set; }

                        [NameInMap("IssueCount")]
                        [Validation(Required=false)]
                        public string IssueCount { get; set; }

                        [NameInMap("IssueLevel")]
                        [Validation(Required=false)]
                        public string IssueLevel { get; set; }

                        [NameInMap("IssueList")]
                        [Validation(Required=false)]
                        public string IssueList { get; set; }

                        [NameInMap("Logic")]
                        [Validation(Required=false)]
                        public string Logic { get; set; }

                        [NameInMap("MaliciousList")]
                        [Validation(Required=false)]
                        public string MaliciousList { get; set; }

                    }

                    [NameInMap("Retry")]
                    [Validation(Required=false)]
                    public int? Retry { get; set; }

                    [NameInMap("ScanEngine")]
                    [Validation(Required=false)]
                    public string ScanEngine { get; set; }

                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public long? Timeout { get; set; }

                }

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
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                }

                [NameInMap("To")]
                [Validation(Required=false)]
                public GetChainResponseBodyChainConfigRoutersTo To { get; set; }
                public class GetChainResponseBodyChainConfigRoutersTo : TeaModel {
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                }

            }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("ChainId")]
        [Validation(Required=false)]
        public string ChainId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScopeExclude")]
        [Validation(Required=false)]
        public List<string> ScopeExclude { get; set; }

        [NameInMap("ScopeId")]
        [Validation(Required=false)]
        public string ScopeId { get; set; }

        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
