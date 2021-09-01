// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetConnectionMetaResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetConnectionMetaResponseData Data { get; set; }
        public class GetConnectionMetaResponseData : TeaModel {
            [NameInMap("Meta")]
            [Validation(Required=true)]
            public string Meta { get; set; }
        };

    }

}
