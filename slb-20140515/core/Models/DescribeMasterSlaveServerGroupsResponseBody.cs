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
        public List<DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroups> MasterSlaveServerGroups { get; set; }
        public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroups : TeaModel {
            [NameInMap("MasterSlaveServerGroupId")]
            [Validation(Required=false)]
            public string MasterSlaveServerGroupId { get; set; }

            [NameInMap("AssociatedObjects")]
            [Validation(Required=false)]
            public DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsAssociatedObjects AssociatedObjects { get; set; }
            public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsAssociatedObjects : TeaModel {
                [NameInMap("Listeners")]
                [Validation(Required=false)]
                public List<DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsAssociatedObjectsListeners> Listeners { get; set; }
                public class DescribeMasterSlaveServerGroupsResponseBodyMasterSlaveServerGroupsAssociatedObjectsListeners : TeaModel {
                    public string Protocol { get; set; }
                    public int? Port { get; set; }
                }
            };

            [NameInMap("MasterSlaveServerGroupName")]
            [Validation(Required=false)]
            public string MasterSlaveServerGroupName { get; set; }

        }

    }

}
