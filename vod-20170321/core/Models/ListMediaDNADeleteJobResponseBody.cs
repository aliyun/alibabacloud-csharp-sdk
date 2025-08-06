// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListMediaDNADeleteJobResponseBody : TeaModel {
        [NameInMap("AIJobList")]
        [Validation(Required=false)]
        public ListMediaDNADeleteJobResponseBodyAIJobList AIJobList { get; set; }
        public class ListMediaDNADeleteJobResponseBodyAIJobList : TeaModel {
            [NameInMap("AIJob")]
            [Validation(Required=false)]
            public List<ListMediaDNADeleteJobResponseBodyAIJobListAIJob> AIJob { get; set; }
            public class ListMediaDNADeleteJobResponseBodyAIJobListAIJob : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("FpDBId")]
                [Validation(Required=false)]
                public string FpDBId { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("NonExistAIJobIds")]
        [Validation(Required=false)]
        public ListMediaDNADeleteJobResponseBodyNonExistAIJobIds NonExistAIJobIds { get; set; }
        public class ListMediaDNADeleteJobResponseBodyNonExistAIJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
