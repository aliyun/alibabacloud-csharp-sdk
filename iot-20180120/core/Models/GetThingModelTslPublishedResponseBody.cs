// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetThingModelTslPublishedResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetThingModelTslPublishedResponseBodyData Data { get; set; }
        public class GetThingModelTslPublishedResponseBodyData : TeaModel {
            [NameInMap("TslStr")]
            [Validation(Required=false)]
            public string TslStr { get; set; }
            [NameInMap("TslUri")]
            [Validation(Required=false)]
            public string TslUri { get; set; }
        };

    }

}
