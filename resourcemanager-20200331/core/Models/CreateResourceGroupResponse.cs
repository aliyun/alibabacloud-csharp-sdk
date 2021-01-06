// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateResourceGroupResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroup")]
        [Validation(Required=true)]
        public CreateResourceGroupResponseResourceGroup ResourceGroup { get; set; }
        public class CreateResourceGroupResponseResourceGroup : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("AccountId")]
            [Validation(Required=true)]
            public string AccountId { get; set; }
            [NameInMap("DisplayName")]
            [Validation(Required=true)]
            public string DisplayName { get; set; }
            [NameInMap("Id")]
            [Validation(Required=true)]
            public string Id { get; set; }
            [NameInMap("CreateDate")]
            [Validation(Required=true)]
            public string CreateDate { get; set; }
            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }
            [NameInMap("RegionStatuses")]
            [Validation(Required=true)]
            public CreateResourceGroupResponseResourceGroupRegionStatuses RegionStatuses { get; set; }
            public class CreateResourceGroupResponseResourceGroupRegionStatuses : TeaModel {
                [NameInMap("RegionStatus")]
                [Validation(Required=true)]
                public List<CreateResourceGroupResponseResourceGroupRegionStatusesRegionStatus> RegionStatus { get; set; }
                public class CreateResourceGroupResponseResourceGroupRegionStatusesRegionStatus : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=true)]
                    public string Status { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=true)]
                    public string RegionId { get; set; }

                }

            }
        };

    }

}
