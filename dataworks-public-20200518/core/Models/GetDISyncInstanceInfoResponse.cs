// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDISyncInstanceInfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetDISyncInstanceInfoResponseData Data { get; set; }
        public class GetDISyncInstanceInfoResponseData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }
            [NameInMap("Message")]
            [Validation(Required=true)]
            public string Message { get; set; }
        };

    }

}
