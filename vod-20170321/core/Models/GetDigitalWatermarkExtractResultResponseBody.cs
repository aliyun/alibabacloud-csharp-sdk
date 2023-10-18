// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetDigitalWatermarkExtractResultResponseBody : TeaModel {
        [NameInMap("AiExtractResultList")]
        [Validation(Required=false)]
        public List<GetDigitalWatermarkExtractResultResponseBodyAiExtractResultList> AiExtractResultList { get; set; }
        public class GetDigitalWatermarkExtractResultResponseBodyAiExtractResultList : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("WaterMarkText")]
            [Validation(Required=false)]
            public string WaterMarkText { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
