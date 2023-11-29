// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableSpecResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAvailableSpecResponseBodyData Data { get; set; }
        public class DescribeAvailableSpecResponseBodyData : TeaModel {
            [NameInMap("AvailableSpecifications")]
            [Validation(Required=false)]
            public List<DescribeAvailableSpecResponseBodyDataAvailableSpecifications> AvailableSpecifications { get; set; }
            public class DescribeAvailableSpecResponseBodyDataAvailableSpecifications : TeaModel {
                [NameInMap("DiskSizeRange")]
                [Validation(Required=false)]
                public DescribeAvailableSpecResponseBodyDataAvailableSpecificationsDiskSizeRange DiskSizeRange { get; set; }
                public class DescribeAvailableSpecResponseBodyDataAvailableSpecificationsDiskSizeRange : TeaModel {
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public long? Max { get; set; }

                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public long? Min { get; set; }

                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public long? Step { get; set; }

                }

                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                [NameInMap("LogDiskSizeRange")]
                [Validation(Required=false)]
                public DescribeAvailableSpecResponseBodyDataAvailableSpecificationsLogDiskSizeRange LogDiskSizeRange { get; set; }
                public class DescribeAvailableSpecResponseBodyDataAvailableSpecificationsLogDiskSizeRange : TeaModel {
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public long? Max { get; set; }

                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public long? Min { get; set; }

                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public long? Step { get; set; }

                }

                [NameInMap("NodeNum")]
                [Validation(Required=false)]
                public List<int?> NodeNum { get; set; }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
