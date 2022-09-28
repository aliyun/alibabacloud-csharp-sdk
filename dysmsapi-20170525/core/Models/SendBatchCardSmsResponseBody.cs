// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendBatchCardSmsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SendBatchCardSmsResponseBodyData Data { get; set; }
        public class SendBatchCardSmsResponseBodyData : TeaModel {
            [NameInMap("BizCardId")]
            [Validation(Required=false)]
            public string BizCardId { get; set; }

            [NameInMap("BizDigitalId")]
            [Validation(Required=false)]
            public string BizDigitalId { get; set; }

            [NameInMap("BizSmsId")]
            [Validation(Required=false)]
            public string BizSmsId { get; set; }

            [NameInMap("CardTmpState")]
            [Validation(Required=false)]
            public int? CardTmpState { get; set; }

            [NameInMap("MediaMobiles")]
            [Validation(Required=false)]
            public string MediaMobiles { get; set; }

            [NameInMap("NotMediaMobiles")]
            [Validation(Required=false)]
            public string NotMediaMobiles { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
