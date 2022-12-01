// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateResourceGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public CreateResourceGroupResponseBodyResourceGroup ResourceGroup { get; set; }
        public class CreateResourceGroupResponseBodyResourceGroup : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RegionStatuses")]
            [Validation(Required=false)]
            public CreateResourceGroupResponseBodyResourceGroupRegionStatuses RegionStatuses { get; set; }
            public class CreateResourceGroupResponseBodyResourceGroupRegionStatuses : TeaModel {
                [NameInMap("RegionStatus")]
                [Validation(Required=false)]
                public List<CreateResourceGroupResponseBodyResourceGroupRegionStatusesRegionStatus> RegionStatus { get; set; }
                public class CreateResourceGroupResponseBodyResourceGroupRegionStatusesRegionStatus : TeaModel {
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
