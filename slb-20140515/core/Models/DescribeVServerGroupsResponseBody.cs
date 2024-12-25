// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeVServerGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DEC9C28-AB05-4DDF-9A78-6B08EC9CE18C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The backend servers.</para>
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
                /// <para>The associated resources.</para>
                /// </summary>
                [NameInMap("AssociatedObjects")]
                [Validation(Required=false)]
                public DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjects AssociatedObjects { get; set; }
                public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjects : TeaModel {
                    /// <summary>
                    /// <para>The listeners.</para>
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
                            /// <para>The listener port.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>80</para>
                            /// </summary>
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public int? Port { get; set; }

                            /// <summary>
                            /// <para>The listener protocol. Valid values: <b>tcp</b>, <b>udp</b>, <b>http</b>, and <b>https</b>.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>tcp</para>
                            /// </summary>
                            [NameInMap("Protocol")]
                            [Validation(Required=false)]
                            public string Protocol { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The forwarding rules.</para>
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
                            /// <para>The requested domain name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="http://www.example.com">www.example.com</a></para>
                            /// </summary>
                            [NameInMap("Domain")]
                            [Validation(Required=false)]
                            public string Domain { get; set; }

                            /// <summary>
                            /// <para>The ID of the forwarding rule.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>rule-a3x3pg1yohq3lq****</para>
                            /// </summary>
                            [NameInMap("RuleId")]
                            [Validation(Required=false)]
                            public string RuleId { get; set; }

                            /// <summary>
                            /// <para>The name of the forwarding rule.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>test</para>
                            /// </summary>
                            [NameInMap("RuleName")]
                            [Validation(Required=false)]
                            public string RuleName { get; set; }

                            /// <summary>
                            /// <para>The request URL.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>/example</para>
                            /// </summary>
                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The time when the CLB instance was created. The time follows the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-31T02:49:05Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The number of servers.</para>
                /// <para>This parameter is unavailable by default. To use this parameter, submit a ticket or contact your account manager.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ServerCount")]
                [Validation(Required=false)]
                public long? ServerCount { get; set; }

                /// <summary>
                /// <para>The tags.</para>
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
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The server group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rsp-0bfuc*****</para>
                /// </summary>
                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

                /// <summary>
                /// <para>The server group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Group3</para>
                /// </summary>
                [NameInMap("VServerGroupName")]
                [Validation(Required=false)]
                public string VServerGroupName { get; set; }

            }

        }

    }

}
