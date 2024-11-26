// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qianzhou20211111.Models
{
    public class ListClusterDeprecatedAPIResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("datas")]
        [Validation(Required=false)]
        public ListClusterDeprecatedAPIResponseBodyDatas Datas { get; set; }
        public class ListClusterDeprecatedAPIResponseBodyDatas : TeaModel {
            [NameInMap("current")]
            [Validation(Required=false)]
            public int? Current { get; set; }

            [NameInMap("data")]
            [Validation(Required=false)]
            public List<ListClusterDeprecatedAPIResponseBodyDatasData> Data { get; set; }
            public class ListClusterDeprecatedAPIResponseBodyDatasData : TeaModel {
                [NameInMap("cluster_id")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("current_version")]
                [Validation(Required=false)]
                public string CurrentVersion { get; set; }

                [NameInMap("deprecated_k8s_version")]
                [Validation(Required=false)]
                public string DeprecatedK8sVersion { get; set; }

                [NameInMap("ds")]
                [Validation(Required=false)]
                public string Ds { get; set; }

                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("last_time")]
                [Validation(Required=false)]
                public string LastTime { get; set; }

                [NameInMap("request_uri")]
                [Validation(Required=false)]
                public string RequestUri { get; set; }

                [NameInMap("source_ips")]
                [Validation(Required=false)]
                public string SourceIps { get; set; }

                [NameInMap("target_version")]
                [Validation(Required=false)]
                public string TargetVersion { get; set; }

                [NameInMap("user_agent")]
                [Validation(Required=false)]
                public string UserAgent { get; set; }

            }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
