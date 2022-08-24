// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class GetServiceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceResponseBodyData Data { get; set; }
        public class GetServiceResponseBodyData : TeaModel {
            [NameInMap("Errorcodes")]
            [Validation(Required=false)]
            public string Errorcodes { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("InputExample")]
            [Validation(Required=false)]
            public string InputExample { get; set; }
            [NameInMap("InputParams")]
            [Validation(Required=false)]
            public string InputParams { get; set; }
            [NameInMap("OutputExample")]
            [Validation(Required=false)]
            public string OutputExample { get; set; }
            [NameInMap("OutputParams")]
            [Validation(Required=false)]
            public string OutputParams { get; set; }
            [NameInMap("ServiceDescription")]
            [Validation(Required=false)]
            public string ServiceDescription { get; set; }
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
