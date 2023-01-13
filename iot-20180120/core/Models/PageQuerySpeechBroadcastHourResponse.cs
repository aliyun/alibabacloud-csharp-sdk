// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class PageQuerySpeechBroadcastHourResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public PageQuerySpeechBroadcastHourResponseData Data { get; set; }
        public class PageQuerySpeechBroadcastHourResponseData : TeaModel {
            [NameInMap("PageId")]
            [Validation(Required=true)]
            public int? PageId { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("PageToken")]
            [Validation(Required=true)]
            public string PageToken { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

            [NameInMap("ResultData")]
            [Validation(Required=true)]
            public PageQuerySpeechBroadcastHourResponseDataResultData ResultData { get; set; }
            public class PageQuerySpeechBroadcastHourResponseDataResultData : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=true)]
                public List<PageQuerySpeechBroadcastHourResponseDataResultDataData> Data { get; set; }
                public class PageQuerySpeechBroadcastHourResponseDataResultDataData : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=true)]
                    public int? Code { get; set; }

                    [NameInMap("DeviceName")]
                    [Validation(Required=true)]
                    public string DeviceName { get; set; }

                    [NameInMap("Msg")]
                    [Validation(Required=true)]
                    public string Msg { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=true)]
                    public string ProductKey { get; set; }

                    [NameInMap("ShareTaskCode")]
                    [Validation(Required=true)]
                    public string ShareTaskCode { get; set; }

                    [NameInMap("SpeechId")]
                    [Validation(Required=true)]
                    public string SpeechId { get; set; }

                    [NameInMap("Speechs")]
                    [Validation(Required=true)]
                    public string Speechs { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=true)]
                    public long? StartTime { get; set; }

                }

            }

        }

    }

}
