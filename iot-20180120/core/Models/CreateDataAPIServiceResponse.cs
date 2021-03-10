// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateDataAPIServiceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public CreateDataAPIServiceResponseData Data { get; set; }
        public class CreateDataAPIServiceResponseData : TeaModel {
            [NameInMap("ApiSrn")]
            [Validation(Required=true)]
            public string ApiSrn { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public long? CreateTime { get; set; }
            [NameInMap("LastUpdateTime")]
            [Validation(Required=true)]
            public long? LastUpdateTime { get; set; }
        };

    }

}
