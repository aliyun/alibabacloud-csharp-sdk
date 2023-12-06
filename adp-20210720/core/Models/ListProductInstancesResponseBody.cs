// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class ListProductInstancesResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListProductInstancesResponseBodyData Data { get; set; }
        public class ListProductInstancesResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListProductInstancesResponseBodyDataList> List { get; set; }
            public class ListProductInstancesResponseBodyDataList : TeaModel {
                [NameInMap("clusterUID")]
                [Validation(Required=false)]
                public string ClusterUID { get; set; }

                [NameInMap("continuousDeployment")]
                [Validation(Required=false)]
                public bool? ContinuousDeployment { get; set; }

                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("productName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("productUID")]
                [Validation(Required=false)]
                public string ProductUID { get; set; }

                [NameInMap("productVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

                [NameInMap("productVersionSpecUID")]
                [Validation(Required=false)]
                public string ProductVersionSpecUID { get; set; }

                [NameInMap("productVersionUID")]
                [Validation(Required=false)]
                public string ProductVersionUID { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

                [NameInMap("uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

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

    }

}
