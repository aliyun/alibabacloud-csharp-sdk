// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_console20190403.Models
{
    public class RetrieveFaceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RetrieveFaceResponseBodyData Data { get; set; }
        public class RetrieveFaceResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<RetrieveFaceResponseBodyDataData> Data { get; set; }
            public class RetrieveFaceResponseBodyDataData : TeaModel {
                public long? UserId { get; set; }
                public string UserName { get; set; }
                public string Rate { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
