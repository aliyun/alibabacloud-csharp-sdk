// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListCustomizedVoiceJobsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCustomizedVoiceJobsResponseBodyData Data { get; set; }
        public class ListCustomizedVoiceJobsResponseBodyData : TeaModel {
            [NameInMap("CustomizedVoiceJobList")]
            [Validation(Required=false)]
            public List<ListCustomizedVoiceJobsResponseBodyDataCustomizedVoiceJobList> CustomizedVoiceJobList { get; set; }
            public class ListCustomizedVoiceJobsResponseBodyDataCustomizedVoiceJobList : TeaModel {
                [NameInMap("Gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Scenario")]
                [Validation(Required=false)]
                public string Scenario { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VoiceDesc")]
                [Validation(Required=false)]
                public string VoiceDesc { get; set; }

                [NameInMap("VoiceId")]
                [Validation(Required=false)]
                public string VoiceId { get; set; }

                [NameInMap("VoiceName")]
                [Validation(Required=false)]
                public string VoiceName { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
