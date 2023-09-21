// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerScanConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeContainerScanConfigResponseBodyData Data { get; set; }
        public class DescribeContainerScanConfigResponseBodyData : TeaModel {
            [NameInMap("AllCount")]
            [Validation(Required=false)]
            public int? AllCount { get; set; }

            [NameInMap("AppNames")]
            [Validation(Required=false)]
            public string AppNames { get; set; }

            [NameInMap("ChooseCount")]
            [Validation(Required=false)]
            public int? ChooseCount { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
