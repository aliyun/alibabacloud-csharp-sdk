// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeAppGroupDataReportResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeAppGroupDataReportResponseBodyResult Result { get; set; }
        public class DescribeAppGroupDataReportResponseBodyResult : TeaModel {
            [NameInMap("receivedCount")]
            [Validation(Required=false)]
            public int? ReceivedCount { get; set; }
            [NameInMap("receivedSample")]
            [Validation(Required=false)]
            public List<DescribeAppGroupDataReportResponseBodyResultReceivedSample> ReceivedSample { get; set; }
            public class DescribeAppGroupDataReportResponseBodyResultReceivedSample : TeaModel {
                public DescribeAppGroupDataReportResponseBodyResultReceivedSampleMessage Message { get; set; }
                public class DescribeAppGroupDataReportResponseBodyResultReceivedSampleMessage : TeaModel {
                    [NameInMap("arg1")]
                    [Validation(Required=false)]
                    public string Arg1 { get; set; }

                    [NameInMap("arg3")]
                    [Validation(Required=false)]
                    public string Arg3 { get; set; }

                    [NameInMap("args")]
                    [Validation(Required=false)]
                    public string Args { get; set; }

                    [NameInMap("clientIp")]
                    [Validation(Required=false)]
                    public string ClientIp { get; set; }

                    [NameInMap("eventId")]
                    [Validation(Required=false)]
                    public int? EventId { get; set; }

                    [NameInMap("page")]
                    [Validation(Required=false)]
                    public string Page { get; set; }

                    [NameInMap("sdkType")]
                    [Validation(Required=false)]
                    public string SdkType { get; set; }

                    [NameInMap("sdkVersion")]
                    [Validation(Required=false)]
                    public string SdkVersion { get; set; }

                    [NameInMap("sessionId")]
                    [Validation(Required=false)]
                    public string SessionId { get; set; }

                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }
                public long? ReceivedTimeMs { get; set; }
            }
        };

    }

}
