// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeMasterSlaveServerGroupsResponseBody : TeaModel {
        [NameInMap("MasterSlaveServerGroups")]
        [Validation(Required=false)]
        public DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroups MasterSlaveServerGroups { get; set; }
        public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroups : TeaModel {
            [NameInMap("MasterSlaveServerGroup")]
            [Validation(Required=false)]
            public List<DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroup> MasterSlaveServerGroup { get; set; }
            public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroup : TeaModel {
                [NameInMap("AssociatedObjects")]
                [Validation(Required=false)]
                public DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupAssociatedObjects AssociatedObjects { get; set; }
                public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupAssociatedObjects : TeaModel {
                    [NameInMap("Listeners")]
                    [Validation(Required=false)]
                    public DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupAssociatedObjectsListeners Listeners { get; set; }
                    public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupAssociatedObjectsListeners : TeaModel {
                        [NameInMap("Listener")]
                        [Validation(Required=false)]
                        public List<DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupAssociatedObjectsListenersListener> Listener { get; set; }
                        public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupAssociatedObjectsListenersListener : TeaModel {
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public int? Port { get; set; }

                            [NameInMap("Protocol")]
                            [Validation(Required=false)]
                            public string Protocol { get; set; }

                        }

                    }

                }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("MasterSlaveServerGroupId")]
                [Validation(Required=false)]
                public string MasterSlaveServerGroupId { get; set; }

                [NameInMap("MasterSlaveServerGroupName")]
                [Validation(Required=false)]
                public string MasterSlaveServerGroupName { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupTags Tags { get; set; }
                public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupTagsTag> Tag { get; set; }
                    public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

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
