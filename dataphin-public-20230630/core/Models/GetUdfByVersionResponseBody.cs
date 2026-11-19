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
        /// <para>The backend exception details.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The details of the custom function.</para>
        /// </summary>
        [NameInMap("UdfInfo")]
        [Validation(Required=false)]
        public GetUdfByVersionResponseBodyUdfInfo UdfInfo { get; set; }
        public class GetUdfByVersionResponseBodyUdfInfo : TeaModel {
            /// <summary>
            /// <para>The category of the function. Valid values: 1: Window function. 2: Aggregate function. 3: Numeric function. 4: String function. 5: Time function. 6: IP address helper function. 7: URL-related function. 8: Encoding and decoding function. 9: Business-related function. 10: Other.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// <para>The name of the registered class.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.lydaas.dataphin.UdfTest</para>
            /// </summary>
            [NameInMap("ClassName")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            /// <summary>
            /// <para>The command help information.</para>
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
            /// <para>The creator of the function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012110</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The description of the function.</para>
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
            /// <para>The time when the function was created. Format: yyyy-MM-d HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-10 10:01:01</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the function was last updated. Format: yyyy-MM-d HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-10 10:01:01</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the custom function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1030111021</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The user who last modified the function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012110</para>
            /// </summary>
            [NameInMap("LastModifier")]
            [Validation(Required=false)]
            public string LastModifier { get; set; }

            /// <summary>
            /// <para>The name of the function.</para>
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
