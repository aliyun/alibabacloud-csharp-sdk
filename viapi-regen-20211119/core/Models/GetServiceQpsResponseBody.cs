// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class GetServiceQpsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceQpsResponseBodyData Data { get; set; }
        public class GetServiceQpsResponseBodyData : TeaModel {
            [NameInMap("UserQps")]
            [Validation(Required=false)]
            public Dictionary<string, object> UserQps { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
