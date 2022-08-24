// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class UpdateServiceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateServiceResponseBodyData Data { get; set; }
        public class UpdateServiceResponseBodyData : TeaModel {
            [NameInMap("AuthorizationType")]
            [Validation(Required=false)]
            public string AuthorizationType { get; set; }
            [NameInMap("AuthorizedAccount")]
            [Validation(Required=false)]
            public string AuthorizedAccount { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("ServiceDescription")]
            [Validation(Required=false)]
            public string ServiceDescription { get; set; }
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
