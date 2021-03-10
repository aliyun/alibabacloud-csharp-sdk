// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetThingModelTslPublishedResponse : TeaModel {
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
        public GetThingModelTslPublishedResponseData Data { get; set; }
        public class GetThingModelTslPublishedResponseData : TeaModel {
            [NameInMap("TslStr")]
            [Validation(Required=true)]
            public string TslStr { get; set; }
            [NameInMap("TslUri")]
            [Validation(Required=true)]
            public string TslUri { get; set; }
        };

    }

}
