// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateShortParamResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public CreateShortParamResponseData Data { get; set; }
        public class CreateShortParamResponseData : TeaModel {
            [NameInMap("ParamDetail")]
            [Validation(Required=true)]
            public string ParamDetail { get; set; }
            [NameInMap("PhoneNumbers")]
            [Validation(Required=true)]
            public string PhoneNumbers { get; set; }
            [NameInMap("ShortParam")]
            [Validation(Required=true)]
            public string ShortParam { get; set; }
        };

    }

}
