// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileDetectReportResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileDetectReportResponseBodyData Data { get; set; }
        public class GetFileDetectReportResponseBodyData : TeaModel {
            [NameInMap("Basic")]
            [Validation(Required=false)]
            public string Basic { get; set; }

            [NameInMap("FileHash")]
            [Validation(Required=false)]
            public string FileHash { get; set; }

            [NameInMap("Filename")]
            [Validation(Required=false)]
            public string Filename { get; set; }

            [NameInMap("HasData")]
            [Validation(Required=false)]
            public bool? HasData { get; set; }

            [NameInMap("Intelligences")]
            [Validation(Required=false)]
            public string Intelligences { get; set; }

            [NameInMap("Sandbox")]
            [Validation(Required=false)]
            public string Sandbox { get; set; }

            [NameInMap("ShowTab")]
            [Validation(Required=false)]
            public bool? ShowTab { get; set; }

            [NameInMap("ThreatLevel")]
            [Validation(Required=false)]
            public long? ThreatLevel { get; set; }

            [NameInMap("ThreatTypes")]
            [Validation(Required=false)]
            public string ThreatTypes { get; set; }

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
