// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeMasterSlaveServerGroupsResponseBody : TeaModel {
        /// <summary>
        /// The primary/secondary server groups.
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
                /// The associated resources.
                /// </summary>
                [NameInMap("AssociatedObjects")]
                [Validation(Required=false)]
                public DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupAssociatedObjects AssociatedObjects { get; set; }
                public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroupAssociatedObjects : TeaModel {
                    /// <summary>
                    /// The listeners.
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
                            /// The listener port.
                            /// </summary>
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public int? Port { get; set; }

                            /// <summary>
                            /// The listener protocol.
                            /// </summary>
                            [NameInMap("Protocol")]
                            [Validation(Required=false)]
                            public string Protocol { get; set; }

                        }

                    }

                }

                /// <summary>
                /// The time when the CLB instance was created. Specify the time in the `YYYY-MM-DDThh:mm:ssZ` format.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The ID of the primary/secondary server group.
                /// </summary>
                [NameInMap("MasterSlaveServerGroupId")]
                [Validation(Required=false)]
                public string MasterSlaveServerGroupId { get; set; }

                /// <summary>
                /// The name of the primary/secondary server group.
                /// </summary>
                [NameInMap("MasterSlaveServerGroupName")]
                [Validation(Required=false)]
                public string MasterSlaveServerGroupName { get; set; }

                /// <summary>
                /// The tags to add to the resource.
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
                        /// The tag key.
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

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
