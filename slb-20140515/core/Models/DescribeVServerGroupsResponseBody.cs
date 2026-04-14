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

        [NameInMap("VServerGroups")]
        [Validation(Required=false)]
        public DescribeVServerGroupsResponseBodyVServerGroups VServerGroups { get; set; }
        public class DescribeVServerGroupsResponseBodyVServerGroups : TeaModel {
            [NameInMap("VServerGroup")]
            [Validation(Required=false)]
            public List<DescribeVServerGroupsResponseBodyVServerGroupsVServerGroup> VServerGroup { get; set; }
            public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroup : TeaModel {
                [NameInMap("AssociatedObjects")]
                [Validation(Required=false)]
                public DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjects AssociatedObjects { get; set; }
                public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjects : TeaModel {
                    [NameInMap("Listeners")]
                    [Validation(Required=false)]
                    public DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsListeners Listeners { get; set; }
                    public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsListeners : TeaModel {
                        [NameInMap("Listener")]
                        [Validation(Required=false)]
                        public List<DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsListenersListener> Listener { get; set; }
                        public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsListenersListener : TeaModel {
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public int? Port { get; set; }

                            [NameInMap("Protocol")]
                            [Validation(Required=false)]
                            public string Protocol { get; set; }

                        }

                    }

                    [NameInMap("Rules")]
                    [Validation(Required=false)]
                    public DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsRules Rules { get; set; }
                    public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsRules : TeaModel {
                        [NameInMap("Rule")]
                        [Validation(Required=false)]
                        public List<DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsRulesRule> Rule { get; set; }
                        public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupAssociatedObjectsRulesRule : TeaModel {
                            [NameInMap("Domain")]
                            [Validation(Required=false)]
                            public string Domain { get; set; }

                            [NameInMap("RuleId")]
                            [Validation(Required=false)]
                            public string RuleId { get; set; }

                            [NameInMap("RuleName")]
                            [Validation(Required=false)]
                            public string RuleName { get; set; }

                            [NameInMap("Url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("ServerCount")]
                [Validation(Required=false)]
                public long? ServerCount { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupTags Tags { get; set; }
                public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupTagsTag> Tag { get; set; }
                    public class DescribeVServerGroupsResponseBodyVServerGroupsVServerGroupTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

                [NameInMap("VServerGroupName")]
                [Validation(Required=false)]
                public string VServerGroupName { get; set; }

            }

        }

    }

}
