// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeClusterResourceDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeClusterResourceDetailResponseBodyData Data { get; set; }
        public class DescribeClusterResourceDetailResponseBodyData : TeaModel {
            [NameInMap("ComputeResource")]
            [Validation(Required=false)]
            public string ComputeResource { get; set; }

            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            [NameInMap("FreeComputeResource")]
            [Validation(Required=false)]
            public string FreeComputeResource { get; set; }

            [NameInMap("ResourceGroupList")]
            [Validation(Required=false)]
            public List<DescribeClusterResourceDetailResponseBodyDataResourceGroupList> ResourceGroupList { get; set; }
            public class DescribeClusterResourceDetailResponseBodyDataResourceGroupList : TeaModel {
                [NameInMap("ClusterMode")]
                [Validation(Required=false)]
                public string ClusterMode { get; set; }

                [NameInMap("ClusterSizeResource")]
                [Validation(Required=false)]
                public string ClusterSizeResource { get; set; }

                [NameInMap("MaxClusterCount")]
                [Validation(Required=false)]
                public int? MaxClusterCount { get; set; }

                [NameInMap("MaxComputeResource")]
                [Validation(Required=false)]
                public string MaxComputeResource { get; set; }

                [NameInMap("MinClusterCount")]
                [Validation(Required=false)]
                public int? MinClusterCount { get; set; }

                [NameInMap("MinComputeResource")]
                [Validation(Required=false)]
                public string MinComputeResource { get; set; }

                [NameInMap("PoolId")]
                [Validation(Required=false)]
                public long? PoolId { get; set; }

                [NameInMap("PoolName")]
                [Validation(Required=false)]
                public string PoolName { get; set; }

                [NameInMap("PoolType")]
                [Validation(Required=false)]
                public string PoolType { get; set; }

                [NameInMap("PoolUsers")]
                [Validation(Required=false)]
                public string PoolUsers { get; set; }

                [NameInMap("RunningClusterCount")]
                [Validation(Required=false)]
                public int? RunningClusterCount { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("StorageResource")]
            [Validation(Required=false)]
            public string StorageResource { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
