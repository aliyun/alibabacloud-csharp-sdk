// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataServiceApiCallsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListDataServiceApiCallsResponseBodyPageResult PageResult { get; set; }
        public class ListDataServiceApiCallsResponseBodyPageResult : TeaModel {
            [NameInMap("CallLogList")]
            [Validation(Required=false)]
            public List<ListDataServiceApiCallsResponseBodyPageResultCallLogList> CallLogList { get; set; }
            public class ListDataServiceApiCallsResponseBodyPageResultCallLogList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>102112</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public long? ApiId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>201211</para>
                /// </summary>
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public long? AppKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("BizCode")]
                [Validation(Required=false)]
                public string BizCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("BizCodeDescription")]
                [Validation(Required=false)]
                public string BizCodeDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>192.168.1.1</para>
                /// </summary>
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("CostTime")]
                [Validation(Required=false)]
                public int? CostTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-11-01 01:01:03.000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public int? Env { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("ExecuteCostTime")]
                [Validation(Required=false)]
                public int? ExecuteCostTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExecuteMode")]
                [Validation(Required=false)]
                public int? ExecuteMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("HttpStatusCode")]
                [Validation(Required=false)]
                public string HttpStatusCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("HttpStatusDescription")]
                [Validation(Required=false)]
                public string HttpStatusDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>102356</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>102356</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public int? ProjectId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234567890-232sds-3e232-ae2e232</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;name&quot;:&quot;test&quot;}</para>
                /// </summary>
                [NameInMap("RequestParameter")]
                [Validation(Required=false)]
                public string RequestParameter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("RequestSize")]
                [Validation(Required=false)]
                public int? RequestSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;code&quot;:&quot;200&quot;,&quot;message&quot;:&quot;success&quot;}</para>
                /// </summary>
                [NameInMap("ResponseParameter")]
                [Validation(Required=false)]
                public string ResponseParameter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("ResponseSize")]
                [Validation(Required=false)]
                public int? ResponseSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ResultCount")]
                [Validation(Required=false)]
                public int? ResultCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>select col1 from t_test1 limit 100;</para>
                /// </summary>
                [NameInMap("Sql")]
                [Validation(Required=false)]
                public string Sql { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-11-01 01:01:01.000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Successful")]
                [Validation(Required=false)]
                public bool? Successful { get; set; }

            }

            /// <summary>
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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
