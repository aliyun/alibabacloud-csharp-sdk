// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeApsResourceGroupsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApsResourceGroupsResponseBodyData Data { get; set; }
        public class DescribeApsResourceGroupsResponseBodyData : TeaModel {
            [NameInMap("ResourceGroups")]
            [Validation(Required=false)]
            public List<DescribeApsResourceGroupsResponseBodyDataResourceGroups> ResourceGroups { get; set; }
            public class DescribeApsResourceGroupsResponseBodyDataResourceGroups : TeaModel {
                [NameInMap("Available")]
                [Validation(Required=false)]
                public bool? Available { get; set; }

                [NameInMap("CuOptions")]
                [Validation(Required=false)]
                public List<long?> CuOptions { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("LeftComputeResource")]
                [Validation(Required=false)]
                public int? LeftComputeResource { get; set; }

                [NameInMap("MaxComputeResource")]
                [Validation(Required=false)]
                public int? MaxComputeResource { get; set; }

                [NameInMap("MinComputeResource")]
                [Validation(Required=false)]
                public int? MinComputeResource { get; set; }

            }

            [NameInMap("Step")]
            [Validation(Required=false)]
            public long? Step { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
