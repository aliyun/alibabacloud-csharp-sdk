// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetFoundationReferenceResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetFoundationReferenceResponseBodyData Data { get; set; }
        public class GetFoundationReferenceResponseBodyData : TeaModel {
            [NameInMap("clusterConfig")]
            [Validation(Required=false)]
            public string ClusterConfig { get; set; }

            [NameInMap("foundationVersionUID")]
            [Validation(Required=false)]
            public string FoundationVersionUID { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
