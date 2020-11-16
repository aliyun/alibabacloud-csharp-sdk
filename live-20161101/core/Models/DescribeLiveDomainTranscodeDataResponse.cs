// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainTranscodeDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TranscodeDataInfos")]
        [Validation(Required=true)]
        public DescribeLiveDomainTranscodeDataResponseTranscodeDataInfos TranscodeDataInfos { get; set; }
        public class DescribeLiveDomainTranscodeDataResponseTranscodeDataInfos : TeaModel {
            [NameInMap("TranscodeDataInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveDomainTranscodeDataResponseTranscodeDataInfosTranscodeDataInfo> TranscodeDataInfo { get; set; }
            public class DescribeLiveDomainTranscodeDataResponseTranscodeDataInfosTranscodeDataInfo : TeaModel {
                public string Date { get; set; }
                public int? Total { get; set; }
                public string Detail { get; set; }
            }
        };

    }

}
