// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainTranscodeDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TranscodeDataInfos")]
        [Validation(Required=false)]
        public DescribeLiveDomainTranscodeDataResponseBodyTranscodeDataInfos TranscodeDataInfos { get; set; }
        public class DescribeLiveDomainTranscodeDataResponseBodyTranscodeDataInfos : TeaModel {
            [NameInMap("TranscodeDataInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainTranscodeDataResponseBodyTranscodeDataInfosTranscodeDataInfo> TranscodeDataInfo { get; set; }
            public class DescribeLiveDomainTranscodeDataResponseBodyTranscodeDataInfosTranscodeDataInfo : TeaModel {
                public string Date { get; set; }
                public int? Total { get; set; }
                public string Detail { get; set; }
            }
        };

    }

}
