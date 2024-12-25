// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeMasterSlaveServerGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The primary/secondary server groups.</para>
        /// </summary>
        [NameInMap("MasterSlaveServerGroups")]
        [Validation(Required=false)]
        public DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroups MasterSlaveServerGroups { get; set; }
        public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroups : TeaModel {
            [NameInMap("MasterSlaveServerGroup")]
            [Validation(Required=false)]
            public List<DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroup> MasterSlaveServerGroup { get; set; }
            public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroup : TeaModel {
                /// <summary>
                /// <para>The associated resources.</para>
                /// </summary>
                [NameInMap("AssociatedObjects")]
                [Validation(Required=false)]
                public DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupAssociatedObjects AssociatedObjects { get; set; }
                public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupAssociatedObjects : TeaModel {
                    /// <summary>
                    /// <para>The listeners.</para>
                    /// </summary>
                    [NameInMap("Listeners")]
                    [Validation(Required=false)]
                    public DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupAssociatedObjectsListeners Listeners { get; set; }
                    public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupAssociatedObjectsListeners : TeaModel {
                        [NameInMap("Listener")]
                        [Validation(Required=false)]
                        public List<DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupAssociatedObjectsListenersListener> Listener { get; set; }
                        public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupAssociatedObjectsListenersListener : TeaModel {
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
                            /// <para>The listener protocol.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>tcp</para>
                            /// </summary>
                            [NameInMap("Protocol")]
                            [Validation(Required=false)]
                            public string Protocol { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The time when the CLB instance was created. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-02T02:49:05Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the primary/secondary server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rsp-0bfuc******</para>
                /// </summary>
                [NameInMap("MasterSlaveServerGroupId")]
                [Validation(Required=false)]
                public string MasterSlaveServerGroupId { get; set; }

                /// <summary>
                /// <para>The name of the primary/secondary server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Group3</para>
                /// </summary>
                [NameInMap("MasterSlaveServerGroupName")]
                [Validation(Required=false)]
                public string MasterSlaveServerGroupName { get; set; }

                /// <summary>
                /// <para>The tags to add to the resource.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupTags Tags { get; set; }
                public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupTagsTag> Tag { get; set; }
                    public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test_slb_yaochi_tag_key-0</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>000098dab00323fb</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DEC9C28-AB05-4DDF-9A78-6B08EC9CE18C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
