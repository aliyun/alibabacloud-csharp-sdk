// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class GetDeviceOtaInfoTestResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDeviceOtaInfoTestResponseBodyData Data { get; set; }
        public class GetDeviceOtaInfoTestResponseBodyData : TeaModel {
            [NameInMap("Version")]
            [Validation(Required=false)]
            public GetDeviceOtaInfoTestResponseBodyDataVersion Version { get; set; }
            public class GetDeviceOtaInfoTestResponseBodyDataVersion : TeaModel {
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                [NameInMap("ForceUpgrade")]
                [Validation(Required=false)]
                public int? ForceUpgrade { get; set; }

                [NameInMap("LocalDownloadUrl")]
                [Validation(Required=false)]
                public string LocalDownloadUrl { get; set; }

                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

                [NameInMap("VersionType")]
                [Validation(Required=false)]
                public string VersionType { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
