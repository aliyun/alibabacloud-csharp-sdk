// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class PageQuerySharedSpeechOpenResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PageQuerySharedSpeechOpenResponseBodyData Data { get; set; }
        public class PageQuerySharedSpeechOpenResponseBodyData : TeaModel {
            [NameInMap("PageId")]
            [Validation(Required=false)]
            public int? PageId { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("ResultData")]
            [Validation(Required=false)]
            public PageQuerySharedSpeechOpenResponseBodyDataResultData ResultData { get; set; }
            public class PageQuerySharedSpeechOpenResponseBodyDataResultData : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<PageQuerySharedSpeechOpenResponseBodyDataResultDataData> Data { get; set; }
                public class PageQuerySharedSpeechOpenResponseBodyDataResultDataData : TeaModel {
                    [NameInMap("AudioFormat")]
                    [Validation(Required=false)]
                    public string AudioFormat { get; set; }

                    [NameInMap("BizCode")]
                    [Validation(Required=false)]
                    public string BizCode { get; set; }

                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("SpeechRate")]
                    [Validation(Required=false)]
                    public int? SpeechRate { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("Voice")]
                    [Validation(Required=false)]
                    public string Voice { get; set; }

                    [NameInMap("Volume")]
                    [Validation(Required=false)]
                    public int? Volume { get; set; }

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
