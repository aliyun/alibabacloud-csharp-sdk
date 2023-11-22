// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAvatarTrainingJobsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAvatarTrainingJobsResponseBodyData Data { get; set; }
        public class ListAvatarTrainingJobsResponseBodyData : TeaModel {
            [NameInMap("AvatarTrainingJobList")]
            [Validation(Required=false)]
            public List<ListAvatarTrainingJobsResponseBodyDataAvatarTrainingJobList> AvatarTrainingJobList { get; set; }
            public class ListAvatarTrainingJobsResponseBodyDataAvatarTrainingJobList : TeaModel {
                [NameInMap("AvatarDescription")]
                [Validation(Required=false)]
                public string AvatarDescription { get; set; }

                [NameInMap("AvatarId")]
                [Validation(Required=false)]
                public string AvatarId { get; set; }

                [NameInMap("AvatarName")]
                [Validation(Required=false)]
                public string AvatarName { get; set; }

                [NameInMap("AvatarType")]
                [Validation(Required=false)]
                public string AvatarType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("FirstTrainingTime")]
                [Validation(Required=false)]
                public string FirstTrainingTime { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("LastTrainingTime")]
                [Validation(Required=false)]
                public string LastTrainingTime { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Portrait")]
                [Validation(Required=false)]
                public string Portrait { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
