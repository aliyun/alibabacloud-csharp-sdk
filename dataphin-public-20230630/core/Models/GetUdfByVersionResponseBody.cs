// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetUdfByVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
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
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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

        /// <summary>
        /// <para>The details of the user-defined function.</para>
        /// </summary>
        [NameInMap("UdfInfo")]
        [Validation(Required=false)]
        public GetUdfByVersionResponseBodyUdfInfo UdfInfo { get; set; }
        public class GetUdfByVersionResponseBodyUdfInfo : TeaModel {
            /// <summary>
            /// <para>The udf type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: window function.</description></item>
            /// <item><description>2: statistical function.</description></item>
            /// <item><description>3: numerical function.</description></item>
            /// <item><description>4: string function.</description></item>
            /// <item><description>5: time function.</description></item>
            /// <item><description>6: IP address utility function.</description></item>
            /// <item><description>7: URL-related function.</description></item>
            /// <item><description>8: encoding and decoding function.</description></item>
            /// <item><description>9: business-related function.</description></item>
            /// <item><description>10: other.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// <para>The registered class name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.lydaas.dataphin.UdfTest</para>
            /// </summary>
            [NameInMap("ClassName")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            /// <summary>
            /// <para>The command help.</para>
            /// 
            /// <b>Example:</b>
            /// <para>udf_to_lower(char x)</para>
            /// </summary>
            [NameInMap("CommandHelp")]
            [Validation(Required=false)]
            public string CommandHelp { get; set; }

            /// <summary>
            /// <para>The compute engine. Valid values: HADOOP, MAX_COMPUTE, and FLINK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HADOOP</para>
            /// </summary>
            [NameInMap("ComputeEngineType")]
            [Validation(Required=false)]
            public string ComputeEngineType { get; set; }

            /// <summary>
            /// <para>The creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012110</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The directory where the function is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The creation time, in the yyyy-MM-d HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-10 10:01:01</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time, in the yyyy-MM-d HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-10 10:01:01</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the user-defined function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1030111021</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The last modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012110</para>
            /// </summary>
            [NameInMap("LastModifier")]
            [Validation(Required=false)]
            public string LastModifier { get; set; }

            /// <summary>
            /// <para>The function name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>udf_to_lower</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
