// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class PageQuerySpeechBroadcastHourResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PageQuerySpeechBroadcastHourResponseBodyData Data { get; set; }
        public class PageQuerySpeechBroadcastHourResponseBodyData : TeaModel {
            [NameInMap("PageId")]
            [Validation(Required=false)]
            public int? PageId { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("PageToken")]
            [Validation(Required=false)]
            public string PageToken { get; set; }

            [NameInMap("ResultData")]
            [Validation(Required=false)]
            public PageQuerySpeechBroadcastHourResponseBodyDataResultData ResultData { get; set; }
            public class PageQuerySpeechBroadcastHourResponseBodyDataResultData : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<PageQuerySpeechBroadcastHourResponseBodyDataResultDataData> Data { get; set; }
                public class PageQuerySpeechBroadcastHourResponseBodyDataResultDataData : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    [NameInMap("Msg")]
                    [Validation(Required=false)]
                    public string Msg { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                    [NameInMap("ShareTaskCode")]
                    [Validation(Required=false)]
                    public string ShareTaskCode { get; set; }

                    [NameInMap("SpeechId")]
                    [Validation(Required=false)]
                    public string SpeechId { get; set; }

                    [NameInMap("Speechs")]
                    [Validation(Required=false)]
                    public string Speechs { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
