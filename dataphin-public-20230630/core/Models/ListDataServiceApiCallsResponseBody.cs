// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataServiceApiCallsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paginated query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListDataServiceApiCallsResponseBodyPageResult PageResult { get; set; }
        public class ListDataServiceApiCallsResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The list of API call logs.</para>
            /// </summary>
            [NameInMap("CallLogList")]
            [Validation(Required=false)]
            public List<ListDataServiceApiCallsResponseBodyPageResultCallLogList> CallLogList { get; set; }
            public class ListDataServiceApiCallsResponseBodyPageResultCallLogList : TeaModel {
                /// <summary>
                /// <para>The ID of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102112</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public long? ApiId { get; set; }

                /// <summary>
                /// <para>The name of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The application key.</para>
                /// <remarks>
                /// <para>Notice: This parameter is deprecated. Use AppKeyStr instead.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                [Obsolete]
                public long? AppKey { get; set; }

                /// <summary>
                /// <para>The application key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc12345</para>
                /// </summary>
                [NameInMap("AppKeyStr")]
                [Validation(Required=false)]
                public string AppKeyStr { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The business status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("BizCode")]
                [Validation(Required=false)]
                public string BizCode { get; set; }

                /// <summary>
                /// <para>The description of the business status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("BizCodeDescription")]
                [Validation(Required=false)]
                public string BizCodeDescription { get; set; }

                /// <summary>
                /// <para>The IP address of the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.1</para>
                /// </summary>
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                /// <summary>
                /// <para>The duration of the request, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("CostTime")]
                [Validation(Required=false)]
                public int? CostTime { get; set; }

                /// <summary>
                /// <para>The end time of the request. Format: yyyy-MM-dd HH:mm:ss.SSS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-01 01:01:03.000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The environment. Valid values: 0 (dev) and 1 (prod).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public int? Env { get; set; }

                /// <summary>
                /// <para>The execution duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("ExecuteCostTime")]
                [Validation(Required=false)]
                public int? ExecuteCostTime { get; set; }

                /// <summary>
                /// <para>The execution mode. Valid values: 1 (synchronous) and 2 (asynchronous).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExecuteMode")]
                [Validation(Required=false)]
                public int? ExecuteMode { get; set; }

                /// <summary>
                /// <para>The HTTP status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("HttpStatusCode")]
                [Validation(Required=false)]
                public string HttpStatusCode { get; set; }

                /// <summary>
                /// <para>The description of the status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("HttpStatusDescription")]
                [Validation(Required=false)]
                public string HttpStatusDescription { get; set; }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102356</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102356</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public int? ProjectId { get; set; }

                /// <summary>
                /// <para>The name of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890-232sds-3e232-ae2e232</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <para>The request parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;name&quot;:&quot;test&quot;}</para>
                /// </summary>
                [NameInMap("RequestParameter")]
                [Validation(Required=false)]
                public string RequestParameter { get; set; }

                /// <summary>
                /// <para>The size of the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("RequestSize")]
                [Validation(Required=false)]
                public int? RequestSize { get; set; }

                /// <summary>
                /// <para>The response parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;code&quot;:&quot;200&quot;,&quot;message&quot;:&quot;success&quot;}</para>
                /// </summary>
                [NameInMap("ResponseParameter")]
                [Validation(Required=false)]
                public string ResponseParameter { get; set; }

                /// <summary>
                /// <para>The size of the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("ResponseSize")]
                [Validation(Required=false)]
                public int? ResponseSize { get; set; }

                /// <summary>
                /// <para>The number of returned data records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ResultCount")]
                [Validation(Required=false)]
                public int? ResultCount { get; set; }

                /// <summary>
                /// <para>The SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select col1 from t_test1 limit 100;</para>
                /// </summary>
                [NameInMap("Sql")]
                [Validation(Required=false)]
                public string Sql { get; set; }

                /// <summary>
                /// <para>The start time of the request. Format: yyyy-MM-dd HH:mm:ss.SSS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-01 01:01:01.000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The call status of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>Indicates whether the request was successful.</para>
                /// </summary>
                [NameInMap("Successful")]
                [Validation(Required=false)]
                public bool? Successful { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
