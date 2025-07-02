// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class GetDeviceOtaInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDeviceOtaInfoResponseBodyData Data { get; set; }
        public class GetDeviceOtaInfoResponseBodyData : TeaModel {
            [NameInMap("Version")]
            [Validation(Required=false)]
            public GetDeviceOtaInfoResponseBodyDataVersion Version { get; set; }
            public class GetDeviceOtaInfoResponseBodyDataVersion : TeaModel {
                [NameInMap("AndroidHorizontalMultiCnImageDownloadUrl")]
                [Validation(Required=false)]
                public string AndroidHorizontalMultiCnImageDownloadUrl { get; set; }

                [NameInMap("AndroidHorizontalMultiEnImageDownloadUrl")]
                [Validation(Required=false)]
                public string AndroidHorizontalMultiEnImageDownloadUrl { get; set; }

                [NameInMap("AndroidVerticalMultiCnImageDownloadUrl")]
                [Validation(Required=false)]
                public string AndroidVerticalMultiCnImageDownloadUrl { get; set; }

                [NameInMap("AndroidVerticalMultiEnImageDownloadUrl")]
                [Validation(Required=false)]
                public string AndroidVerticalMultiEnImageDownloadUrl { get; set; }

                [NameInMap("CnImageDownloadUrl")]
                [Validation(Required=false)]
                public string CnImageDownloadUrl { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("CustomForceUpgrade")]
                [Validation(Required=false)]
                public bool? CustomForceUpgrade { get; set; }

                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                [NameInMap("EnImageDownloadUrl")]
                [Validation(Required=false)]
                public string EnImageDownloadUrl { get; set; }

                [NameInMap("ForceUpgrade")]
                [Validation(Required=false)]
                public int? ForceUpgrade { get; set; }

                [NameInMap("IsAppDownloadUrl")]
                [Validation(Required=false)]
                public bool? IsAppDownloadUrl { get; set; }

                [NameInMap("LocalDownloadUrl")]
                [Validation(Required=false)]
                public string LocalDownloadUrl { get; set; }

                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                [NameInMap("MultiCnImageDownloadUrl")]
                [Validation(Required=false)]
                public string MultiCnImageDownloadUrl { get; set; }

                [NameInMap("MultiEnImageDownloadUrl")]
                [Validation(Required=false)]
                public string MultiEnImageDownloadUrl { get; set; }

                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }

                [NameInMap("ReleaseNoteEn")]
                [Validation(Required=false)]
                public string ReleaseNoteEn { get; set; }

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

                [NameInMap("WyForceUpgrade")]
                [Validation(Required=false)]
                public bool? WyForceUpgrade { get; set; }

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
