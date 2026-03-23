// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeGadInstancesResponseBody : TeaModel {
        [NameInMap("GadInstances")]
        [Validation(Required=false)]
        public List<DescribeGadInstancesResponseBodyGadInstances> GadInstances { get; set; }
        public class DescribeGadInstancesResponseBodyGadInstances : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GadInstanceMembers")]
            [Validation(Required=false)]
            public List<DescribeGadInstancesResponseBodyGadInstancesGadInstanceMembers> GadInstanceMembers { get; set; }
            public class DescribeGadInstancesResponseBodyGadInstancesGadInstanceMembers : TeaModel {
                [NameInMap("DBInstanceID")]
                [Validation(Required=false)]
                public string DBInstanceID { get; set; }

                [NameInMap("DtsInstance")]
                [Validation(Required=false)]
                public string DtsInstance { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("GadInstanceName")]
            [Validation(Required=false)]
            public string GadInstanceName { get; set; }

            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
