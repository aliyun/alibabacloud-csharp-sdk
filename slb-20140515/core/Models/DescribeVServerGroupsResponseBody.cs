// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeVServerGroupsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of backend servers.
        /// </summary>
        [NameInMap("VServerGroups")]
        [Validation(Required=false)]
        public DescribeVServerGroupsResponseBodyVServerGroups VServerGroups { get; set; }
        public class DescribeVServerGroupsResponseBodyVServerGroups : TeaModel {
            [NameInMap("VServerGroup")]
            [Validation(Required=false)]
            public List<DescribeVServerGroupsResponseBodyVServerGroupsVServerGroup> VServerGroup { get; set; }
            public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroup : TeaModel {
                /// <summary>
                /// The items associated with the server groups.
                /// </summary>
                [NameInMap("AssociatedObjects")]
                [Validation(Required=false)]
                public DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjects AssociatedObjects { get; set; }
                public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjects : TeaModel {
                    /// <summary>
                    /// The list of listeners.
                    /// </summary>
                    [NameInMap("Listeners")]
                    [Validation(Required=false)]
                    public DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsListeners Listeners { get; set; }
                    public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsListeners : TeaModel {
                        [NameInMap("Listener")]
                        [Validation(Required=false)]
                        public List<DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsListenersListener> Listener { get; set; }
                        public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsListenersListener : TeaModel {
                            /// <summary>
                            /// The listening port.
                            /// </summary>
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public int? Port { get; set; }

                            /// <summary>
                            /// The listening protocol. Valid values: **tcp**, **udp**, **http**, and **https**.
                            /// </summary>
                            [NameInMap("Protocol")]
                            [Validation(Required=false)]
                            public string Protocol { get; set; }

                        }

                    }

                    /// <summary>
                    /// The list of forwarding rules.
                    /// </summary>
                    [NameInMap("Rules")]
                    [Validation(Required=false)]
                    public DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsRules Rules { get; set; }
                    public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsRules : TeaModel {
                        [NameInMap("Rule")]
                        [Validation(Required=false)]
                        public List<DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsRulesRule> Rule { get; set; }
                        public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsRulesRule : TeaModel {
                            /// <summary>
                            /// The requested domain name.
                            /// </summary>
                            [NameInMap("Domain")]
                            [Validation(Required=false)]
                            public string Domain { get; set; }

                            /// <summary>
                            /// The ID of the forwarding rule.
                            /// </summary>
                            [NameInMap("RuleId")]
                            [Validation(Required=false)]
                            public string RuleId { get; set; }

                            /// <summary>
                            /// The name of the forwarding rule.
                            /// </summary>
                            [NameInMap("RuleName")]
                            [Validation(Required=false)]
                            public string RuleName { get; set; }

                            /// <summary>
                            /// The request path.
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                }

                /// <summary>
                /// The time when the CLB instance was created. The time follows the `YYYY-MM-DDThh:mm:ssZ` format.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The number of servers. 
                /// 
                /// >  The feature corresponding to this parameter is not available by default. If you want to use this feature, [submit a ticket](https://ticket-intl.console.aliyun.com/#/ticket/createIndex).
                /// </summary>
                [NameInMap("ServerCount")]
                [Validation(Required=false)]
                public long? ServerCount { get; set; }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupTags Tags { get; set; }
                public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupTagsTag> Tag { get; set; }
                    public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupTagsTag : TeaModel {
                        /// <summary>
                        /// The tag keys of the resource.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the server group.
                /// </summary>
                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

                /// <summary>
                /// The name of the server group.
                /// </summary>
                [NameInMap("VServerGroupName")]
                [Validation(Required=false)]
                public string VServerGroupName { get; set; }

            }

        }

    }

}
