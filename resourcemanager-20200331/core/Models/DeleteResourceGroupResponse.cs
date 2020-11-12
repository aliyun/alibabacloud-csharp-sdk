// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class DeleteResourceGroupResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroup")]
        [Validation(Required=true)]
        public DeleteResourceGroupResponseResourceGroup ResourceGroup { get; set; }
        public class DeleteResourceGroupResponseResourceGroup : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=true)]
            public string Id { get; set; }
            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }
            [NameInMap("DisplayName")]
            [Validation(Required=true)]
            public string DisplayName { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("CreateDate")]
            [Validation(Required=true)]
            public string CreateDate { get; set; }
            [NameInMap("AccountId")]
            [Validation(Required=true)]
            public string AccountId { get; set; }
            [NameInMap("RegionStatuses")]
            [Validation(Required=true)]
            public DeleteResourceGroupResponseResourceGroupRegionStatuses RegionStatuses { get; set; }
            public class DeleteResourceGroupResponseResourceGroupRegionStatuses : TeaModel {
                [NameInMap("RegionStatus")]
                [Validation(Required=true)]
                public List<DeleteResourceGroupResponseResourceGroupRegionStatusesRegionStatus> RegionStatus { get; set; }
                public class DeleteResourceGroupResponseResourceGroupRegionStatusesRegionStatus : TeaModel {
                    [NameInMap("RegionId")]
                    [Validation(Required=true)]
                    public string RegionId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=true)]
                    public string Status { get; set; }

                }

            }
        };

    }

}
