// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAIVideoCoverJobResponseBody : TeaModel {
        [NameInMap("AIVideoCoverJobList")]
        [Validation(Required=false)]
        public ListAIVideoCoverJobResponseBodyAIVideoCoverJobList AIVideoCoverJobList { get; set; }
        public class ListAIVideoCoverJobResponseBodyAIVideoCoverJobList : TeaModel {
            [NameInMap("AIVideoCoverJob")]
            [Validation(Required=false)]
            public List<ListAIVideoCoverJobResponseBodyAIVideoCoverJobListAIVideoCoverJob> AIVideoCoverJob { get; set; }
            public class ListAIVideoCoverJobResponseBodyAIVideoCoverJobListAIVideoCoverJob : TeaModel {
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

        [NameInMap("NonExistAIVideoCoverJobIds")]
        [Validation(Required=false)]
        public ListAIVideoCoverJobResponseBodyNonExistAIVideoCoverJobIds NonExistAIVideoCoverJobIds { get; set; }
        public class ListAIVideoCoverJobResponseBodyNonExistAIVideoCoverJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
