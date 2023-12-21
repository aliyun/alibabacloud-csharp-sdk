// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class PopQueryLatestAvatarProjectDetailByUserResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PopQueryLatestAvatarProjectDetailByUserResponseBodyData Data { get; set; }
        public class PopQueryLatestAvatarProjectDetailByUserResponseBodyData : TeaModel {
            [NameInMap("BizUsage")]
            [Validation(Required=false)]
            public string BizUsage { get; set; }

            [NameInMap("BuildDetail")]
            [Validation(Required=false)]
            public PopQueryLatestAvatarProjectDetailByUserResponseBodyDataBuildDetail BuildDetail { get; set; }
            public class PopQueryLatestAvatarProjectDetailByUserResponseBodyDataBuildDetail : TeaModel {
                [NameInMap("RunningTime")]
                [Validation(Required=false)]
                public string RunningTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Dataset")]
            [Validation(Required=false)]
            public PopQueryLatestAvatarProjectDetailByUserResponseBodyDataDataset Dataset { get; set; }
            public class PopQueryLatestAvatarProjectDetailByUserResponseBodyDataDataset : TeaModel {
                [NameInMap("BuildResultUrl")]
                [Validation(Required=false)]
                public Dictionary<string, object> BuildResultUrl { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

            [NameInMap("Ext")]
            [Validation(Required=false)]
            public string Ext { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Intro")]
            [Validation(Required=false)]
            public string Intro { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
