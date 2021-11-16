// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ImportConnectionsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImportConnectionsResponseBodyData Data { get; set; }
        public class ImportConnectionsResponseBodyData : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
