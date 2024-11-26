// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qianzhou20211111.Models
{
    public class QueryNodeInfoResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryNodeInfoResponseBodyData> Data { get; set; }
        public class QueryNodeInfoResponseBodyData : TeaModel {
            [NameInMap("cluserName")]
            [Validation(Required=false)]
            public string CluserName { get; set; }

            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
