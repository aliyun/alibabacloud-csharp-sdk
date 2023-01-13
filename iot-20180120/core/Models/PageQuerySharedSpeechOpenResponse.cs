// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class PageQuerySharedSpeechOpenResponse : TeaModel {
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
        public PageQuerySharedSpeechOpenResponseData Data { get; set; }
        public class PageQuerySharedSpeechOpenResponseData : TeaModel {
            [NameInMap("PageId")]
            [Validation(Required=true)]
            public int? PageId { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

            [NameInMap("ResultData")]
            [Validation(Required=true)]
            public PageQuerySharedSpeechOpenResponseDataResultData ResultData { get; set; }
            public class PageQuerySharedSpeechOpenResponseDataResultData : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=true)]
                public List<PageQuerySharedSpeechOpenResponseDataResultDataData> Data { get; set; }
                public class PageQuerySharedSpeechOpenResponseDataResultDataData : TeaModel {
                    [NameInMap("AudioFormat")]
                    [Validation(Required=true)]
                    public string AudioFormat { get; set; }

                    [NameInMap("BizCode")]
                    [Validation(Required=true)]
                    public string BizCode { get; set; }

                    [NameInMap("Code")]
                    [Validation(Required=true)]
                    public string Code { get; set; }

                    [NameInMap("SpeechRate")]
                    [Validation(Required=true)]
                    public int? SpeechRate { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=true)]
                    public int? Status { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=true)]
                    public string Text { get; set; }

                    [NameInMap("Voice")]
                    [Validation(Required=true)]
                    public string Voice { get; set; }

                    [NameInMap("Volume")]
                    [Validation(Required=true)]
                    public int? Volume { get; set; }

                }

            }

        }

    }

}
