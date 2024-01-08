// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryRecordDownloadJobListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryRecordDownloadJobListResponseBodyData Data { get; set; }
        public class QueryRecordDownloadJobListResponseBodyData : TeaModel {
            [NameInMap("JobList")]
            [Validation(Required=false)]
            public List<QueryRecordDownloadJobListResponseBodyDataJobList> JobList { get; set; }
            public class QueryRecordDownloadJobListResponseBodyDataJobList : TeaModel {
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public int? BeginTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public int? EndTime { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

                [NameInMap("JobErrorCode")]
                [Validation(Required=false)]
                public int? JobErrorCode { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("RecordType")]
                [Validation(Required=false)]
                public int? RecordType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public int? StreamType { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
