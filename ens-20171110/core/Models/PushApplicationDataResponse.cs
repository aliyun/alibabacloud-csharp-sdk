// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PushApplicationDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PushResults")]
        [Validation(Required=true)]
        public PushApplicationDataResponsePushResults PushResults { get; set; }
        public class PushApplicationDataResponsePushResults : TeaModel {
            [NameInMap("PushResult")]
            [Validation(Required=true)]
            public List<PushApplicationDataResponsePushResultsPushResult> PushResult { get; set; }
            public class PushApplicationDataResponsePushResultsPushResult : TeaModel {
                public string Version { get; set; }
                public string ResultDescrip { get; set; }
                public int? ResultCode { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
