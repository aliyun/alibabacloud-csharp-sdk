// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAIVideoPornRecogJobResponseBody : TeaModel {
        [NameInMap("AIVideoPornRecogJobList")]
        [Validation(Required=false)]
        public ListAIVideoPornRecogJobResponseBodyAIVideoPornRecogJobList AIVideoPornRecogJobList { get; set; }
        public class ListAIVideoPornRecogJobResponseBodyAIVideoPornRecogJobList : TeaModel {
            [NameInMap("AIVideoPornRecogJob")]
            [Validation(Required=false)]
            public List<ListAIVideoPornRecogJobResponseBodyAIVideoPornRecogJobListAIVideoPornRecogJob> AIVideoPornRecogJob { get; set; }
            public class ListAIVideoPornRecogJobResponseBodyAIVideoPornRecogJobListAIVideoPornRecogJob : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

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

        [NameInMap("NonExistPornRecogJobIds")]
        [Validation(Required=false)]
        public ListAIVideoPornRecogJobResponseBodyNonExistPornRecogJobIds NonExistPornRecogJobIds { get; set; }
        public class ListAIVideoPornRecogJobResponseBodyNonExistPornRecogJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
