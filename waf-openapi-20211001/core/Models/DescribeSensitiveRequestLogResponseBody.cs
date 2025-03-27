// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSensitiveRequestLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The access logs.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSensitiveRequestLogResponseBodyData> Data { get; set; }
        public class DescribeSensitiveRequestLogResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/api/users/login</para>
            /// </summary>
            [NameInMap("ApiFormat")]
            [Validation(Required=false)]
            public string ApiFormat { get; set; }

            /// <summary>
            /// <para>The ID of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>197b52abcd81d6a8bd4***e477</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>103.118.55.**</para>
            /// </summary>
            [NameInMap("ClientIP")]
            [Validation(Required=false)]
            public string ClientIP { get; set; }

            /// <summary>
            /// <para>The number of sensitive data records involved in cross-border data transfer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The domain name of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.****.com</para>
            /// </summary>
            [NameInMap("MatchedHost")]
            [Validation(Required=false)]
            public string MatchedHost { get; set; }

            /// <summary>
            /// <para>IP region, formatted as a region code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("RemoteCountryId")]
            [Validation(Required=false)]
            public string RemoteCountryId { get; set; }

            /// <summary>
            /// <para>The time when the request was initiated. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723392000</para>
            /// </summary>
            [NameInMap("RequestTime")]
            [Validation(Required=false)]
            public long? RequestTime { get; set; }

            /// <summary>
            /// <para>The details of sensitive data. The value is a string that consists of a JSON struct. The JSON struct contains key-value pairs. In a key-value pair, a key indicates the identifier of a sensitive data type, including built-in and custom types, and a value indicates specific sensitive data.</para>
            /// <remarks>
            /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported sensitive data types.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///           &quot;1000&quot;:[ 
            ///               &quot;90.88.49.19&quot;,
            ///               &quot;90.88.49.19&quot;
            ///           ],
            ///           &quot;835436&quot;:[ 
            ///               &quot;<a href="http://www.abc.com">www.abc.com</a>&quot;
            ///           ]
            /// }</para>
            /// </summary>
            [NameInMap("SensitiveList")]
            [Validation(Required=false)]
            public string SensitiveList { get; set; }

            /// <summary>
            /// <para>The trace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0a3d455b17027784870843933dce3d</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26E46541-7AAB-5565-801D-F14DBDC5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
