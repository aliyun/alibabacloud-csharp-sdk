// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qianzhou20211111.Models
{
    public class QueryByInstanceInfoResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryByInstanceInfoResponseBodyData> Data { get; set; }
        public class QueryByInstanceInfoResponseBodyData : TeaModel {
            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("clusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

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
