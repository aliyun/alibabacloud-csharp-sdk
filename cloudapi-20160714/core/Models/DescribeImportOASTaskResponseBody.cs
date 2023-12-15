// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeImportOASTaskResponseBody : TeaModel {
        /// <summary>
        /// The execution status of the subtask. Valid values:
        /// 
        /// *   RUNNING
        /// *   WAIT
        /// *   OVER
        /// *   FAIL
        /// *   CANCEL
        /// </summary>
        [NameInMap("ApiResults")]
        [Validation(Required=false)]
        public DescribeImportOASTaskResponseBodyApiResults ApiResults { get; set; }
        public class DescribeImportOASTaskResponseBodyApiResults : TeaModel {
            [NameInMap("ApiResult")]
            [Validation(Required=false)]
            public List<DescribeImportOASTaskResponseBodyApiResultsApiResult> ApiResult { get; set; }
            public class DescribeImportOASTaskResponseBodyApiResultsApiResult : TeaModel {
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("UpdateStatus")]
                [Validation(Required=false)]
                public string UpdateStatus { get; set; }

            }

        }

        /// <summary>
        /// The execution status of the subtask. Valid values:
        /// 
        /// *   RUNNING
        /// *   WAIT
        /// *   OVER
        /// *   FAIL
        /// *   CANCEL
        /// </summary>
        [NameInMap("ModelResults")]
        [Validation(Required=false)]
        public DescribeImportOASTaskResponseBodyModelResults ModelResults { get; set; }
        public class DescribeImportOASTaskResponseBodyModelResults : TeaModel {
            [NameInMap("ModelResult")]
            [Validation(Required=false)]
            public List<DescribeImportOASTaskResponseBodyModelResultsModelResult> ModelResult { get; set; }
            public class DescribeImportOASTaskResponseBodyModelResultsModelResult : TeaModel {
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                [NameInMap("UpdateStatus")]
                [Validation(Required=false)]
                public string UpdateStatus { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the import task. Valid values:
        /// 
        /// *   Running
        /// *   Finished
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
