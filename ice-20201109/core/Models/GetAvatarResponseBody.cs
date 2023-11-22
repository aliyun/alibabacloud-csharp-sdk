// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetAvatarResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAvatarResponseBodyData Data { get; set; }
        public class GetAvatarResponseBodyData : TeaModel {
            [NameInMap("Avatar")]
            [Validation(Required=false)]
            public GetAvatarResponseBodyDataAvatar Avatar { get; set; }
            public class GetAvatarResponseBodyDataAvatar : TeaModel {
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

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Portrait")]
                [Validation(Required=false)]
                public string Portrait { get; set; }

                [NameInMap("Thumbnail")]
                [Validation(Required=false)]
                public string Thumbnail { get; set; }

                [NameInMap("Transparent")]
                [Validation(Required=false)]
                public bool? Transparent { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

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
