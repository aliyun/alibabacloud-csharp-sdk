// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeImportOASTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The execution status of the subtask. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RUNNING</description></item>
        /// <item><description>WAIT</description></item>
        /// <item><description>OVER</description></item>
        /// <item><description>FAIL</description></item>
        /// <item><description>CANCEL</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ApiResults")]
        [Validation(Required=false)]
        public DescribeImportOASTaskResponseBodyApiResults ApiResults { get; set; }
        public class DescribeImportOASTaskResponseBodyApiResults : TeaModel {
            [NameInMap("ApiResult")]
            [Validation(Required=false)]
            public List<DescribeImportOASTaskResponseBodyApiResultsApiResult> ApiResult { get; set; }
            public class DescribeImportOASTaskResponseBodyApiResultsApiResult : TeaModel {
                /// <summary>
                /// <para>The API ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c5a0c2900ff746b789c007545be22fb8</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <para>The API name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GetByCreatorIdUsingGET</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The API description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>release data api 411055691505041</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The cause of the failure if the API fails to be imported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Internal Error</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The API group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>736508d885074167ba8fbce3bc95ea0b</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The HTTP request HTTP method of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The request path of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/creator/getByCreatorId</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The execution status of the subtask. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RUNNING</description></item>
                /// <item><description>WAIT</description></item>
                /// <item><description>OVER</description></item>
                /// <item><description>FAIL</description></item>
                /// <item><description>CANCEL</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>WAIT</para>
                /// </summary>
                [NameInMap("UpdateStatus")]
                [Validation(Required=false)]
                public string UpdateStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The execution status of the subtask. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RUNNING</description></item>
        /// <item><description>WAIT</description></item>
        /// <item><description>OVER</description></item>
        /// <item><description>FAIL</description></item>
        /// <item><description>CANCEL</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ModelResults")]
        [Validation(Required=false)]
        public DescribeImportOASTaskResponseBodyModelResults ModelResults { get; set; }
        public class DescribeImportOASTaskResponseBodyModelResults : TeaModel {
            [NameInMap("ModelResult")]
            [Validation(Required=false)]
            public List<DescribeImportOASTaskResponseBodyModelResultsModelResult> ModelResult { get; set; }
            public class DescribeImportOASTaskResponseBodyModelResultsModelResult : TeaModel {
                /// <summary>
                /// <para>The cause of the failure if the model fails to be imported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Internal Error</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The API group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>736508d885074167ba8fbce3bc95ea0b</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The ID of the imported model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6b48d724c921415486e190c494dd6bf8</para>
                /// </summary>
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                /// <summary>
                /// <para>The model name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Pet</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The execution status of the subtask. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RUNNING</description></item>
                /// <item><description>WAIT</description></item>
                /// <item><description>OVER</description></item>
                /// <item><description>FAIL</description></item>
                /// <item><description>CANCEL</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FAIL</para>
                /// </summary>
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
