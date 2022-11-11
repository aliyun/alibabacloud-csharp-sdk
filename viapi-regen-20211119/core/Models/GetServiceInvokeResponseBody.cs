// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class GetServiceInvokeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceInvokeResponseBodyData Data { get; set; }
        public class GetServiceInvokeResponseBodyData : TeaModel {
            [NameInMap("UserInvoke")]
            [Validation(Required=false)]
            public Dictionary<string, object> UserInvoke { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
