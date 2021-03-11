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
                public string Result { get; set; }
                public BatchResumeVsStreamResponseBodyResumeResultResumeResultInfoChannels Channels { get; set; }
                public class BatchResumeVsStreamResponseBodyResumeResultResumeResultInfoChannels : TeaModel {
                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public List<string> Channel { get; set; }

                }
                public int? Count { get; set; }
                public string Detail { get; set; }
            }
        };

    }

}
