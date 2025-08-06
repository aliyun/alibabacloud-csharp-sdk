// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetUploadProgressResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UploadProgress")]
        [Validation(Required=false)]
        public GetUploadProgressResponseBodyUploadProgress UploadProgress { get; set; }
        public class GetUploadProgressResponseBodyUploadProgress : TeaModel {
            [NameInMap("UploadProgressList")]
            [Validation(Required=false)]
            public List<GetUploadProgressResponseBodyUploadProgressUploadProgressList> UploadProgressList { get; set; }
            public class GetUploadProgressResponseBodyUploadProgressUploadProgressList : TeaModel {
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                [NameInMap("AuthInfo")]
                [Validation(Required=false)]
                public string AuthInfo { get; set; }

                [NameInMap("AuthTimestamp")]
                [Validation(Required=false)]
                public string AuthTimestamp { get; set; }

                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                [NameInMap("DeviceModel")]
                [Validation(Required=false)]
                public string DeviceModel { get; set; }

                [NameInMap("DonePartsCount")]
                [Validation(Required=false)]
                public int? DonePartsCount { get; set; }

                [NameInMap("FileCreateTime")]
                [Validation(Required=false)]
                public string FileCreateTime { get; set; }

                [NameInMap("FileHash")]
                [Validation(Required=false)]
                public string FileHash { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                [NameInMap("PartSize")]
                [Validation(Required=false)]
                public long? PartSize { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("TerminalType")]
                [Validation(Required=false)]
                public string TerminalType { get; set; }

                [NameInMap("TotalPart")]
                [Validation(Required=false)]
                public string TotalPart { get; set; }

                [NameInMap("UploadAddress")]
                [Validation(Required=false)]
                public string UploadAddress { get; set; }

                [NameInMap("UploadId")]
                [Validation(Required=false)]
                public string UploadId { get; set; }

                [NameInMap("UploadPoint")]
                [Validation(Required=false)]
                public string UploadPoint { get; set; }

                [NameInMap("UploadRatio")]
                [Validation(Required=false)]
                public float? UploadRatio { get; set; }

                [NameInMap("UploadSpeed")]
                [Validation(Required=false)]
                public float? UploadSpeed { get; set; }

                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

            }

        }

    }

}
