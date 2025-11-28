// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Lto20210707.Models
{
    public class DescribeStatDeviceInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeStatDeviceInfoResponseBodyData Data { get; set; }
        public class DescribeStatDeviceInfoResponseBodyData : TeaModel {
            [NameInMap("BizChainList")]
            [Validation(Required=false)]
            public List<DescribeStatDeviceInfoResponseBodyDataBizChainList> BizChainList { get; set; }
            public class DescribeStatDeviceInfoResponseBodyDataBizChainList : TeaModel {
                [NameInMap("AuthorizedCount")]
                [Validation(Required=false)]
                public int? AuthorizedCount { get; set; }

                [NameInMap("BizChainName")]
                [Validation(Required=false)]
                public string BizChainName { get; set; }

            }

            [NameInMap("DistributableCount")]
            [Validation(Required=false)]
            public int? DistributableCount { get; set; }

            [NameInMap("TotalAuthorizedCount")]
            [Validation(Required=false)]
            public int? TotalAuthorizedCount { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
