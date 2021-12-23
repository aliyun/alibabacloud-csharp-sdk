// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class ListFunctionDeploymentResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<ListFunctionDeploymentResponseBodyDataList> DataList { get; set; }
        public class ListFunctionDeploymentResponseBodyDataList : TeaModel {
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("DeploymentId")]
            [Validation(Required=false)]
            public string DeploymentId { get; set; }

            [NameInMap("DownloadSignedUrl")]
            [Validation(Required=false)]
            public string DownloadSignedUrl { get; set; }

            [NameInMap("ModifiedAt")]
            [Validation(Required=false)]
            public string ModifiedAt { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public ListFunctionDeploymentResponseBodyDataListStatus Status { get; set; }
            public class ListFunctionDeploymentResponseBodyDataListStatus : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
            };

            [NameInMap("VersionNo")]
            [Validation(Required=false)]
            public string VersionNo { get; set; }

        }

        [NameInMap("Paginator")]
        [Validation(Required=false)]
        public ListFunctionDeploymentResponseBodyPaginator Paginator { get; set; }
        public class ListFunctionDeploymentResponseBodyPaginator : TeaModel {
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
