// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataDownloadURLResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDataDownloadURLResponseBodyData Data { get; set; }
        public class DescribeDataDownloadURLResponseBodyData : TeaModel {
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("ServerList")]
            [Validation(Required=false)]
            public List<DescribeDataDownloadURLResponseBodyDataServerList> ServerList { get; set; }
            public class DescribeDataDownloadURLResponseBodyDataServerList : TeaModel {
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
