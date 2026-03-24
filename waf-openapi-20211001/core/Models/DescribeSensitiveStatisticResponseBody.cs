// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSensitiveStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of sensitive data statistics.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSensitiveStatisticResponseBodyData> Data { get; set; }
        public class DescribeSensitiveStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The API path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/api/login</para>
            /// </summary>
            [NameInMap("ApiFormat")]
            [Validation(Required=false)]
            public string ApiFormat { get; set; }

            /// <summary>
            /// <para>The client IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.50.11.**</para>
            /// </summary>
            [NameInMap("ClientIP")]
            [Validation(Required=false)]
            public string ClientIP { get; set; }

            /// <summary>
            /// <para>The number of data entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>169</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The matched domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.****.com</para>
            /// </summary>
            [NameInMap("MatchedHost")]
            [Validation(Required=false)]
            public string MatchedHost { get; set; }

            /// <summary>
            /// <para>The sensitive data type.</para>
            /// <remarks>
            /// <para>Call <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> to obtain the supported sensitive data types.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1003</para>
            /// </summary>
            [NameInMap("SensitiveCode")]
            [Validation(Required=false)]
            public string SensitiveCode { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
