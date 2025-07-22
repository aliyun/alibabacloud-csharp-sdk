// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRouteTableListResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RouteTableList")]
        [Validation(Required=false)]
        public List<DescribeRouteTableListResponseBodyRouteTableList> RouteTableList { get; set; }
        public class DescribeRouteTableListResponseBodyRouteTableList : TeaModel {
            [NameInMap("AssociateType")]
            [Validation(Required=false)]
            public string AssociateType { get; set; }

            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

            [NameInMap("RouteTableType")]
            [Validation(Required=false)]
            public string RouteTableType { get; set; }

            [NameInMap("RouterType")]
            [Validation(Required=false)]
            public string RouterType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
