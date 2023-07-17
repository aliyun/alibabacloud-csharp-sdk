// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class GetHotelSceneItemDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetHotelSceneItemDetailResponseBodyResult Result { get; set; }
        public class GetHotelSceneItemDetailResponseBodyResult : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("DialogueList")]
            [Validation(Required=false)]
            public List<GetHotelSceneItemDetailResponseBodyResultDialogueList> DialogueList { get; set; }
            public class GetHotelSceneItemDetailResponseBodyResultDialogueList : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DialogueId")]
                [Validation(Required=false)]
                public string DialogueId { get; set; }

                [NameInMap("NoAnswer")]
                [Validation(Required=false)]
                public string NoAnswer { get; set; }

                [NameInMap("NoAnswerTemplate")]
                [Validation(Required=false)]
                public string NoAnswerTemplate { get; set; }

                [NameInMap("Process")]
                [Validation(Required=false)]
                public int? Process { get; set; }

                [NameInMap("Question")]
                [Validation(Required=false)]
                public string Question { get; set; }

                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("YesAnswer")]
                [Validation(Required=false)]
                public string YesAnswer { get; set; }

                [NameInMap("YesAnswerTemplate")]
                [Validation(Required=false)]
                public string YesAnswerTemplate { get; set; }

            }

            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
