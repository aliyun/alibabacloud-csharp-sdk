// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeModelsResponseBody : TeaModel {
        /// <summary>
        /// The returned information about models. It is an array consisting of ModelDetail data.
        /// </summary>
        [NameInMap("ModelDetails")]
        [Validation(Required=false)]
        public DescribeModelsResponseBodyModelDetails ModelDetails { get; set; }
        public class DescribeModelsResponseBodyModelDetails : TeaModel {
            [NameInMap("ModelDetail")]
            [Validation(Required=false)]
            public List<DescribeModelsResponseBodyModelDetailsModelDetail> ModelDetail { get; set; }
            public class DescribeModelsResponseBodyModelDetailsModelDetail : TeaModel {
                /// <summary>
                /// The time when the model was created.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The definition of the model description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the API group to which the model belongs.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The ID of the model.
                /// </summary>
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                /// <summary>
                /// The name of the model.
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// The URI of the model.
                /// </summary>
                [NameInMap("ModelRef")]
                [Validation(Required=false)]
                public string ModelRef { get; set; }

                /// <summary>
                /// The last modification time of the model.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The definition of the model.
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
