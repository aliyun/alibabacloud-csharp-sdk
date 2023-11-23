// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListAlgorithmsResponseBody : TeaModel {
        [NameInMap("Algorithms")]
        [Validation(Required=false)]
        public List<ListAlgorithmsResponseBodyAlgorithms> Algorithms { get; set; }
        public class ListAlgorithmsResponseBodyAlgorithms : TeaModel {
            [NameInMap("AlgorithmDescription")]
            [Validation(Required=false)]
            public string AlgorithmDescription { get; set; }

            [NameInMap("AlgorithmId")]
            [Validation(Required=false)]
            public string AlgorithmId { get; set; }

            [NameInMap("AlgorithmName")]
            [Validation(Required=false)]
            public string AlgorithmName { get; set; }

            [NameInMap("AlgorithmProvider")]
            [Validation(Required=false)]
            public string AlgorithmProvider { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
