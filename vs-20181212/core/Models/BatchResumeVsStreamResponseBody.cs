// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchResumeVsStreamResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResumeResult")]
        [Validation(Required=false)]
        public BatchResumeVsStreamResponseBodyResumeResult ResumeResult { get; set; }
        public class BatchResumeVsStreamResponseBodyResumeResult : TeaModel {
            [NameInMap("ResumeResultInfo")]
            [Validation(Required=false)]
            public List<BatchResumeVsStreamResponseBodyResumeResultResumeResultInfo> ResumeResultInfo { get; set; }
            public class BatchResumeVsStreamResponseBodyResumeResultResumeResultInfo : TeaModel {
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public BatchResumeVsStreamResponseBodyResumeResultResumeResultInfoChannels Channels { get; set; }
                public class BatchResumeVsStreamResponseBodyResumeResultResumeResultInfoChannels : TeaModel {
                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public List<string> Channel { get; set; }

                }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

        }

    }

}
