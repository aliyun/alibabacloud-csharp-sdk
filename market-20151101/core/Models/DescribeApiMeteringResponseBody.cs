// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeApiMeteringResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// fatal
        /// </summary>
        [NameInMap("Fatal")]
        [Validation(Required=false)]
        public bool? Fatal { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeApiMeteringResponseBodyResult> Result { get; set; }
        public class DescribeApiMeteringResponseBodyResult : TeaModel {
            [NameInMap("AliyunPk")]
            [Validation(Required=false)]
            public long? AliyunPk { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public long? TotalQuota { get; set; }

            [NameInMap("TotalUsage")]
            [Validation(Required=false)]
            public long? TotalUsage { get; set; }

            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
