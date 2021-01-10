// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDWSSubsConnectionStringResponseBody : TeaModel {
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
        public GetDWSSubsConnectionStringResponseBodyData Data { get; set; }
        public class GetDWSSubsConnectionStringResponseBodyData : TeaModel {
            [NameInMap("ClusterUrl")]
            [Validation(Required=false)]
            public string ClusterUrl { get; set; }
            [NameInMap("Consumer")]
            [Validation(Required=false)]
            public string Consumer { get; set; }
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }
            [NameInMap("TableId")]
            [Validation(Required=false)]
            public string TableId { get; set; }
        };

    }

}
