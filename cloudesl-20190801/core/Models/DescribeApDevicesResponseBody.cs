// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class DescribeApDevicesResponseBody : TeaModel {
        [NameInMap("ApDevices")]
        [Validation(Required=false)]
        public DescribeApDevicesResponseBodyApDevices ApDevices { get; set; }
        public class DescribeApDevicesResponseBodyApDevices : TeaModel {
            [NameInMap("ApInfo")]
            [Validation(Required=false)]
            public List<DescribeApDevicesResponseBodyApDevicesApInfo> ApInfo { get; set; }
            public class DescribeApDevicesResponseBodyApDevicesApInfo : TeaModel {
                [NameInMap("IsActivate")]
                [Validation(Required=false)]
                public bool? IsActivate { get; set; }

                [NameInMap("Mac")]
                [Validation(Required=false)]
                public string Mac { get; set; }

                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public bool? Status { get; set; }

            }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
