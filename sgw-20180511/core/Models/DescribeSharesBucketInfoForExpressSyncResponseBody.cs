// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeSharesBucketInfoForExpressSyncResponseBody : TeaModel {
        [NameInMap("BucketInfos")]
        [Validation(Required=false)]
        public DescribeSharesBucketInfoForExpressSyncResponseBodyBucketInfos BucketInfos { get; set; }
        public class DescribeSharesBucketInfoForExpressSyncResponseBodyBucketInfos : TeaModel {
            [NameInMap("BucketInfo")]
            [Validation(Required=false)]
            public List<DescribeSharesBucketInfoForExpressSyncResponseBodyBucketInfosBucketInfo> BucketInfo { get; set; }
            public class DescribeSharesBucketInfoForExpressSyncResponseBodyBucketInfosBucketInfo : TeaModel {
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                [NameInMap("BucketPrefix")]
                [Validation(Required=false)]
                public string BucketPrefix { get; set; }

                [NameInMap("BucketRegion")]
                [Validation(Required=false)]
                public string BucketRegion { get; set; }

            }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
