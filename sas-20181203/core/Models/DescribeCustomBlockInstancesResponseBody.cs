// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomBlockInstancesResponseBody : TeaModel {
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<DescribeCustomBlockInstancesResponseBodyInstanceList> InstanceList { get; set; }
        public class DescribeCustomBlockInstancesResponseBodyInstanceList : TeaModel {
            [NameInMap("AliNetOnline")]
            [Validation(Required=false)]
            public bool? AliNetOnline { get; set; }

            [NameInMap("BlockType")]
            [Validation(Required=false)]
            public string BlockType { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SuccessInfo")]
            [Validation(Required=false)]
            public string SuccessInfo { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeCustomBlockInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeCustomBlockInstancesResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
