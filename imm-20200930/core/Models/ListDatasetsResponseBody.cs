// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListDatasetsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Responses
        /// </summary>
        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<ListDatasetsResponseBodyDatasets> Datasets { get; set; }
        public class ListDatasetsResponseBodyDatasets : TeaModel {
            /// <summary>
            /// ProjectName
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// DatasetName
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            [NameInMap("Workflow")]
            [Validation(Required=false)]
            public string Workflow { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DatasetMaxOSSBindCount")]
            [Validation(Required=false)]
            public long? DatasetMaxOSSBindCount { get; set; }

            [NameInMap("DatasetMaxFileCount")]
            [Validation(Required=false)]
            public long? DatasetMaxFileCount { get; set; }

            [NameInMap("DatasetMaxEntityCount")]
            [Validation(Required=false)]
            public long? DatasetMaxEntityCount { get; set; }

            [NameInMap("DatasetMaxRelationCount")]
            [Validation(Required=false)]
            public long? DatasetMaxRelationCount { get; set; }

            [NameInMap("DatasetMaxTotalFileSize")]
            [Validation(Required=false)]
            public long? DatasetMaxTotalFileSize { get; set; }

            [NameInMap("BindCount")]
            [Validation(Required=false)]
            public long? BindCount { get; set; }

        }

    }

}
