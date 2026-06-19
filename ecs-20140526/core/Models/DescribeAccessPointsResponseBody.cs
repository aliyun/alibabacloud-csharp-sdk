// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAccessPointsResponseBody : TeaModel {
        [NameInMap("AccessPointSet")]
        [Validation(Required=false)]
        public DescribeAccessPointsResponseBodyAccessPointSet AccessPointSet { get; set; }
        public class DescribeAccessPointsResponseBodyAccessPointSet : TeaModel {
            [NameInMap("AccessPointType")]
            [Validation(Required=false)]
            public List<DescribeAccessPointsResponseBodyAccessPointSetAccessPointType> AccessPointType { get; set; }
            public class DescribeAccessPointsResponseBodyAccessPointSetAccessPointType : TeaModel {
                [NameInMap("AccessPointId")]
                [Validation(Required=false)]
                public string AccessPointId { get; set; }

                [NameInMap("AttachedRegionNo")]
                [Validation(Required=false)]
                public string AttachedRegionNo { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("HostOperator")]
                [Validation(Required=false)]
                public string HostOperator { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
