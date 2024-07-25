// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAvatarsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAvatarsResponseBodyData Data { get; set; }
        public class ListAvatarsResponseBodyData : TeaModel {
            [NameInMap("AvatarList")]
            [Validation(Required=false)]
            public List<ListAvatarsResponseBodyDataAvatarList> AvatarList { get; set; }
            public class ListAvatarsResponseBodyDataAvatarList : TeaModel {
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

                [NameInMap("Portrait")]
                [Validation(Required=false)]
                public string Portrait { get; set; }

                [NameInMap("Thumbnail")]
                [Validation(Required=false)]
                public string Thumbnail { get; set; }

                [NameInMap("Transparent")]
                [Validation(Required=false)]
                public bool? Transparent { get; set; }

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
