// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class GetSecretAsrInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSecretAsrInfoResponseBodyData> Data { get; set; }
        public class GetSecretAsrInfoResponseBodyData : TeaModel {
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
