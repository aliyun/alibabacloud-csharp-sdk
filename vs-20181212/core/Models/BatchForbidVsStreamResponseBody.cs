// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchForbidVsStreamResponseBody : TeaModel {
        [NameInMap("ForbidResult")]
        [Validation(Required=false)]
        public BatchForbidVsStreamResponseBodyForbidResult ForbidResult { get; set; }
        public class BatchForbidVsStreamResponseBodyForbidResult : TeaModel {
            [NameInMap("ForbidResultInfo")]
            [Validation(Required=false)]
            public List<BatchForbidVsStreamResponseBodyForbidResultForbidResultInfo> ForbidResultInfo { get; set; }
            public class BatchForbidVsStreamResponseBodyForbidResultForbidResultInfo : TeaModel {
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public BatchForbidVsStreamResponseBodyForbidResultForbidResultInfoChannels Channels { get; set; }
                public class BatchForbidVsStreamResponseBodyForbidResultForbidResultInfoChannels : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
