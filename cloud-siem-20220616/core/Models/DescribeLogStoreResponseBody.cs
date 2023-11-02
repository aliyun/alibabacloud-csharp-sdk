// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeLogStoreResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeLogStoreResponseBodyData Data { get; set; }
        public class DescribeLogStoreResponseBodyData : TeaModel {
            [NameInMap("AppendMeta")]
            [Validation(Required=false)]
            public bool? AppendMeta { get; set; }

            [NameInMap("AutoSplit")]
            [Validation(Required=false)]
            public bool? AutoSplit { get; set; }

            [NameInMap("EnableTracking")]
            [Validation(Required=false)]
            public bool? EnableTracking { get; set; }

            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            [NameInMap("MaxSplitShard")]
            [Validation(Required=false)]
            public int? MaxSplitShard { get; set; }

            [NameInMap("ShardCount")]
            [Validation(Required=false)]
            public int? ShardCount { get; set; }

            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

        }

        [NameInMap("DyCode")]
        [Validation(Required=false)]
        public string DyCode { get; set; }

        [NameInMap("DyMessage")]
        [Validation(Required=false)]
        public string DyMessage { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

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
