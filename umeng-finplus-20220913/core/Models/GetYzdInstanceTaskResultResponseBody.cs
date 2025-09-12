// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20220913.Models
{
    public class GetYzdInstanceTaskResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public bool? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetYzdInstanceTaskResultResponseBodyData> Data { get; set; }
        public class GetYzdInstanceTaskResultResponseBodyData : TeaModel {
            [NameInMap("appid")]
            [Validation(Required=false)]
            public string Appid { get; set; }

            [NameInMap("bcid")]
            [Validation(Required=false)]
            public string Bcid { get; set; }

            [NameInMap("datasetIds")]
            [Validation(Required=false)]
            public string DatasetIds { get; set; }

            [NameInMap("downloadUrls")]
            [Validation(Required=false)]
            public List<GetYzdInstanceTaskResultResponseBodyDataDownloadUrls> DownloadUrls { get; set; }
            public class GetYzdInstanceTaskResultResponseBodyDataDownloadUrls : TeaModel {
                [NameInMap("pwd")]
                [Validation(Required=false)]
                public string Pwd { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("resultCnt")]
            [Validation(Required=false)]
            public string ResultCnt { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("timeDuration")]
            [Validation(Required=false)]
            public string TimeDuration { get; set; }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
