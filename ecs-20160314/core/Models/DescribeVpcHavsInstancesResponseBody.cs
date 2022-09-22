// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeVpcHavsInstancesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VpcHavsInstances")]
        [Validation(Required=false)]
        public DescribeVpcHavsInstancesResponseBodyVpcHavsInstances VpcHavsInstances { get; set; }
        public class DescribeVpcHavsInstancesResponseBodyVpcHavsInstances : TeaModel {
            [NameInMap("VpcHavsInstance")]
            [Validation(Required=false)]
            public List<DescribeVpcHavsInstancesResponseBodyVpcHavsInstancesVpcHavsInstance> VpcHavsInstance { get; set; }
            public class DescribeVpcHavsInstancesResponseBodyVpcHavsInstancesVpcHavsInstance : TeaModel {
                [NameInMap("HavsInstances")]
                [Validation(Required=false)]
                public DescribeVpcHavsInstancesResponseBodyVpcHavsInstancesVpcHavsInstanceHavsInstances HavsInstances { get; set; }
                public class DescribeVpcHavsInstancesResponseBodyVpcHavsInstancesVpcHavsInstanceHavsInstances : TeaModel {
                    [NameInMap("HavsInstance")]
                    [Validation(Required=false)]
                    public List<DescribeVpcHavsInstancesResponseBodyVpcHavsInstancesVpcHavsInstanceHavsInstancesHavsInstance> HavsInstance { get; set; }
                    public class DescribeVpcHavsInstancesResponseBodyVpcHavsInstancesVpcHavsInstanceHavsInstancesHavsInstance : TeaModel {
                        [NameInMap("EcsInstanceId")]
                        [Validation(Required=false)]
                        public string EcsInstanceId { get; set; }

                        [NameInMap("Reason")]
                        [Validation(Required=false)]
                        public string Reason { get; set; }

                    }

                }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

    }

}
