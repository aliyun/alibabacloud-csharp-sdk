// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodStatisResponseBody : TeaModel {
        [NameInMap("CdnData")]
        [Validation(Required=false)]
        public DescribeVodStatisResponseBodyCdnData CdnData { get; set; }
        public class DescribeVodStatisResponseBodyCdnData : TeaModel {
            [NameInMap("Bps")]
            [Validation(Required=false)]
            public float? Bps { get; set; }

            [NameInMap("Traffic")]
            [Validation(Required=false)]
            public long? Traffic { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StorageData")]
        [Validation(Required=false)]
        public DescribeVodStatisResponseBodyStorageData StorageData { get; set; }
        public class DescribeVodStatisResponseBodyStorageData : TeaModel {
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Traffic")]
            [Validation(Required=false)]
            public long? Traffic { get; set; }

        }

        [NameInMap("TranscodeData")]
        [Validation(Required=false)]
        public DescribeVodStatisResponseBodyTranscodeData TranscodeData { get; set; }
        public class DescribeVodStatisResponseBodyTranscodeData : TeaModel {
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

        }

    }

}
