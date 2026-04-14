// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeImportOASTaskResponseBody : TeaModel {
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE5722A6-AE78-4741-A9B0-6C817D360510</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the import task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running</description></item>
        /// <item><description>Finished</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
