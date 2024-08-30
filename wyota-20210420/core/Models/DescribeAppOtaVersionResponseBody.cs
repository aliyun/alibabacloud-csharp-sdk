// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class DescribeAppOtaVersionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAppOtaVersionResponseBodyData Data { get; set; }
        public class DescribeAppOtaVersionResponseBodyData : TeaModel {
            [NameInMap("AppOtaInfoDTOList")]
            [Validation(Required=false)]
            public List<DescribeAppOtaVersionResponseBodyDataAppOtaInfoDTOList> AppOtaInfoDTOList { get; set; }
            public class DescribeAppOtaVersionResponseBodyDataAppOtaInfoDTOList : TeaModel {
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                [NameInMap("FullDownloadUrl")]
                [Validation(Required=false)]
                public string FullDownloadUrl { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                [NameInMap("OsType")]
                [Validation(Required=false)]
                public string OsType { get; set; }

                [NameInMap("OtaType")]
                [Validation(Required=false)]
                public int? OtaType { get; set; }

                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }

                [NameInMap("ReleaseNoteEn")]
                [Validation(Required=false)]
                public string ReleaseNoteEn { get; set; }

                [NameInMap("SessionType")]
                [Validation(Required=false)]
                public string SessionType { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public long? VersionCode { get; set; }

                [NameInMap("VersionType")]
                [Validation(Required=false)]
                public string VersionType { get; set; }

                [NameInMap("VersionUid")]
                [Validation(Required=false)]
                public string VersionUid { get; set; }

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
