// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetAvatarTrainingJobResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAvatarTrainingJobResponseBodyData Data { get; set; }
        public class GetAvatarTrainingJobResponseBodyData : TeaModel {
            [NameInMap("AvatarTrainingJob")]
            [Validation(Required=false)]
            public GetAvatarTrainingJobResponseBodyDataAvatarTrainingJob AvatarTrainingJob { get; set; }
            public class GetAvatarTrainingJobResponseBodyDataAvatarTrainingJob : TeaModel {
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

                [NameInMap("Thumbnail")]
                [Validation(Required=false)]
                public string Thumbnail { get; set; }

                [NameInMap("Transparent")]
                [Validation(Required=false)]
                public bool? Transparent { get; set; }

                [NameInMap("Video")]
                [Validation(Required=false)]
                public string Video { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
