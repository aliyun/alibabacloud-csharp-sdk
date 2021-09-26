// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetConnectionMetaResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetConnectionMetaResponseBodyData Data { get; set; }
        public class GetConnectionMetaResponseBodyData : TeaModel {
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }
        };

    }

}
