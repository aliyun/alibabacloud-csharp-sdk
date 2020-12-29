// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateShortParamResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateShortParamResponseBodyData Data { get; set; }
        public class CreateShortParamResponseBodyData : TeaModel {
            [NameInMap("PhoneNumbers")]
            [Validation(Required=false)]
            public string PhoneNumbers { get; set; }
            [NameInMap("ShortParam")]
            [Validation(Required=false)]
            public string ShortParam { get; set; }
            [NameInMap("ParamDetail")]
            [Validation(Required=false)]
            public string ParamDetail { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
