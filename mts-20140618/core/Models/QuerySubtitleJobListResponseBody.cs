// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QuerySubtitleJobListResponseBody : TeaModel {
        [NameInMap("NonExistJobIds")]
        [Validation(Required=false)]
        public QuerySubtitleJobListResponseBodyNonExistJobIds NonExistJobIds { get; set; }
        public class QuerySubtitleJobListResponseBodyNonExistJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("JobList")]
        [Validation(Required=false)]
        public QuerySubtitleJobListResponseBodyJobList JobList { get; set; }
        public class QuerySubtitleJobListResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<QuerySubtitleJobListResponseBodyJobListJob> Job { get; set; }
            public class QuerySubtitleJobListResponseBodyJobListJob : TeaModel {
                public string OutputConfig { get; set; }
                public string State { get; set; }
                public string JobId { get; set; }
                public string UserData { get; set; }
                public string InputConfig { get; set; }
                public QuerySubtitleJobListResponseBodyJobListJobMNSMessageResult MNSMessageResult { get; set; }
                public class QuerySubtitleJobListResponseBodyJobListJobMNSMessageResult : TeaModel {
                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                }
            }
        };

    }

}
