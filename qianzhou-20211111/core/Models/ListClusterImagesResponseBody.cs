// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qianzhou20211111.Models
{
    public class ListClusterImagesResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("datas")]
        [Validation(Required=false)]
        public ListClusterImagesResponseBodyDatas Datas { get; set; }
        public class ListClusterImagesResponseBodyDatas : TeaModel {
            [NameInMap("current")]
            [Validation(Required=false)]
            public int? Current { get; set; }

            [NameInMap("data")]
            [Validation(Required=false)]
            public List<ListClusterImagesResponseBodyDatasData> Data { get; set; }
            public class ListClusterImagesResponseBodyDatasData : TeaModel {
                [NameInMap("cluster_id")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("controller_name")]
                [Validation(Required=false)]
                public string ControllerName { get; set; }

                [NameInMap("controller_type")]
                [Validation(Required=false)]
                public string ControllerType { get; set; }

                [NameInMap("created")]
                [Validation(Required=false)]
                public string Created { get; set; }

                [NameInMap("image_hash")]
                [Validation(Required=false)]
                public string ImageHash { get; set; }

                [NameInMap("image_name")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                [NameInMap("updated")]
                [Validation(Required=false)]
                public string Updated { get; set; }

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
