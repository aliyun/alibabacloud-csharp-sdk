// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainStreamTranscodeDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TranscodeDataList")]
        [Validation(Required=false)]
        public DescribeLiveDomainStreamTranscodeDataResponseBodyTranscodeDataList TranscodeDataList { get; set; }
        public class DescribeLiveDomainStreamTranscodeDataResponseBodyTranscodeDataList : TeaModel {
            [NameInMap("TranscodeData")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainStreamTranscodeDataResponseBodyTranscodeDataListTranscodeData> TranscodeData { get; set; }
            public class DescribeLiveDomainStreamTranscodeDataResponseBodyTranscodeDataListTranscodeData : TeaModel {
                public string TanscodeType { get; set; }
                public string Domain { get; set; }
                public string Region { get; set; }
                public int? Duration { get; set; }
                public string TimeStamp { get; set; }
                public string Fps { get; set; }
                public string Resolution { get; set; }
            }
        };

    }

}
