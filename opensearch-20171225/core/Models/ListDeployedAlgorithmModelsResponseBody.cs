// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListDeployedAlgorithmModelsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDeployedAlgorithmModelsResponseBodyResult> Result { get; set; }
        public class ListDeployedAlgorithmModelsResponseBodyResult : TeaModel {
            [NameInMap("apps")]
            [Validation(Required=false)]
            public List<string> Apps { get; set; }

            [NameInMap("appGroupName")]
            [Validation(Required=false)]
            public string AppGroupName { get; set; }

            [NameInMap("models")]
            [Validation(Required=false)]
            public List<ListDeployedAlgorithmModelsResponseBodyResultModels> Models { get; set; }
            public class ListDeployedAlgorithmModelsResponseBodyResultModels : TeaModel {
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                [NameInMap("projectId")]
                [Validation(Required=false)]
                public int? ProjectId { get; set; }

                [NameInMap("modelId")]
                [Validation(Required=false)]
                public int? ModelId { get; set; }

                [NameInMap("algorithmType")]
                [Validation(Required=false)]
                public string AlgorithmType { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

            }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
