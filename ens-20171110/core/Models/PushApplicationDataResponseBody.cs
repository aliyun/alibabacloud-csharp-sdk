// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PushApplicationDataResponseBody : TeaModel {
        [NameInMap("PushResults")]
        [Validation(Required=false)]
        public PushApplicationDataResponseBodyPushResults PushResults { get; set; }
        public class PushApplicationDataResponseBodyPushResults : TeaModel {
            [NameInMap("PushResult")]
            [Validation(Required=false)]
            public List<PushApplicationDataResponseBodyPushResultsPushResult> PushResult { get; set; }
            public class PushApplicationDataResponseBodyPushResultsPushResult : TeaModel {
                public string Name { get; set; }
                public int? ResultCode { get; set; }
                public string ResultDescrip { get; set; }
                public string Version { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
