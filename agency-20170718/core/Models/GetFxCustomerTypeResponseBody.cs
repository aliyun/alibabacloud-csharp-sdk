// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20170718.Models
{
    public class GetFxCustomerTypeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFxCustomerTypeResponseBodyData Data { get; set; }
        public class GetFxCustomerTypeResponseBodyData : TeaModel {
            [NameInMap("CustomerType")]
            [Validation(Required=false)]
            public int? CustomerType { get; set; }

            [NameInMap("IsSub")]
            [Validation(Required=false)]
            public int? IsSub { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
