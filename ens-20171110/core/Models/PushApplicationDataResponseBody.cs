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
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public int? ResultCode { get; set; }

                [NameInMap("ResultDescrip")]
                [Validation(Required=false)]
                public string ResultDescrip { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
