// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class PlayInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NotFoundCDNDomain")]
        [Validation(Required=false)]
        public PlayInfoResponseBodyNotFoundCDNDomain NotFoundCDNDomain { get; set; }
        public class PlayInfoResponseBodyNotFoundCDNDomain : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("PlayInfoList")]
        [Validation(Required=false)]
        public PlayInfoResponseBodyPlayInfoList PlayInfoList { get; set; }
        public class PlayInfoResponseBodyPlayInfoList : TeaModel {
            [NameInMap("PlayInfo")]
            [Validation(Required=false)]
            public List<PlayInfoResponseBodyPlayInfoListPlayInfo> PlayInfo { get; set; }
            public class PlayInfoResponseBodyPlayInfoListPlayInfo : TeaModel {
                public string DownloadType { get; set; }
                public string Width { get; set; }
                public string Definition { get; set; }
                public string Rand { get; set; }
                public string Url { get; set; }
                public string Complexity { get; set; }
                public string Encryption { get; set; }
                public string Fps { get; set; }
                public string EncryptionType { get; set; }
                public string Height { get; set; }
                public string ActivityName { get; set; }
                public string Size { get; set; }
                public string Bitrate { get; set; }
                public string Plaintext { get; set; }
                public string Duration { get; set; }
                public string Format { get; set; }
            }
        };

    }

}
