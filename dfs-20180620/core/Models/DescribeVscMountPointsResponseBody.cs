// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class DescribeVscMountPointsResponseBody : TeaModel {
        [NameInMap("MountPoints")]
        [Validation(Required=false)]
        public List<DescribeVscMountPointsResponseBodyMountPoints> MountPoints { get; set; }
        public class DescribeVscMountPointsResponseBodyMountPoints : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("InstanceTotalCount")]
            [Validation(Required=false)]
            public int? InstanceTotalCount { get; set; }

            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<DescribeVscMountPointsResponseBodyMountPointsInstances> Instances { get; set; }
            public class DescribeVscMountPointsResponseBodyMountPointsInstances : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Vscs")]
                [Validation(Required=false)]
                public List<DescribeVscMountPointsResponseBodyMountPointsInstancesVscs> Vscs { get; set; }
                public class DescribeVscMountPointsResponseBodyMountPointsInstancesVscs : TeaModel {
                    [NameInMap("VscId")]
                    [Validation(Required=false)]
                    public string VscId { get; set; }

                    [NameInMap("VscStatus")]
                    [Validation(Required=false)]
                    public string VscStatus { get; set; }

                    [NameInMap("VscType")]
                    [Validation(Required=false)]
                    public string VscType { get; set; }

                }

            }

            [NameInMap("MountPointAlias")]
            [Validation(Required=false)]
            public string MountPointAlias { get; set; }

            [NameInMap("MountPointId")]
            [Validation(Required=false)]
            public string MountPointId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
