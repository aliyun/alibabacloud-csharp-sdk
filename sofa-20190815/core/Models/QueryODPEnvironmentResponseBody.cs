// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryODPEnvironmentResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryODPEnvironmentResponseBodyData Data { get; set; }
        public class QueryODPEnvironmentResponseBodyData : TeaModel {
            [NameInMap("AdvancedUser")]
            [Validation(Required=false)]
            public bool? AdvancedUser { get; set; }
            [NameInMap("AutoCreateSchema")]
            [Validation(Required=false)]
            public bool? AutoCreateSchema { get; set; }
            [NameInMap("DepolyMode")]
            [Validation(Required=false)]
            public string DepolyMode { get; set; }
            [NameInMap("Ldc")]
            [Validation(Required=false)]
            public bool? Ldc { get; set; }
            [NameInMap("NetMode")]
            [Validation(Required=false)]
            public string NetMode { get; set; }
            [NameInMap("Datacenters")]
            [Validation(Required=false)]
            public List<string> Datacenters { get; set; }
        };

    }

}
