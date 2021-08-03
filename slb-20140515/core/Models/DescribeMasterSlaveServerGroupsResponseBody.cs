// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeMasterSlaveServerGroupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MasterSlaveServerGroups")]
        [Validation(Required=false)]
        public DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroups MasterSlaveServerGroups { get; set; }
        public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroups : TeaModel {
            [NameInMap("MasterSlaveServerGroup")]
            [Validation(Required=false)]
            public List<DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroup> MasterSlaveServerGroup { get; set; }
            public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsMasterSlaveServerGroup : TeaModel {
                public string MasterSlaveServerGroupId { get; set; }
                public string MasterSlaveServerGroupName { get; set; }
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
                            public int? Port { get; set; }
                            public string Protocol { get; set; }
                        }
                    };

                }
            }
        };

    }

}
