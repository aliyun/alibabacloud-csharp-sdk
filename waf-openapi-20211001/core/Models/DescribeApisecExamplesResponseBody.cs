// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecExamplesResponseBody : TeaModel {
        [NameInMap("Examples")]
        [Validation(Required=false)]
        public List<DescribeApisecExamplesResponseBodyExamples> Examples { get; set; }
        public class DescribeApisecExamplesResponseBodyExamples : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.test.com/api/v1/hello.php?token=TkJGQw">http://www.test.com/api/v1/hello.php?token=TkJGQw</a></para>
            /// </summary>
            [NameInMap("ApiUrl")]
            [Validation(Required=false)]
            public string ApiUrl { get; set; }

            [NameInMap("PocPayload")]
            [Validation(Required=false)]
            public string PocPayload { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("Request")]
            [Validation(Required=false)]
            public string Request { get; set; }

            [NameInMap("RequestSensitiveData")]
            [Validation(Required=false)]
            public List<DescribeApisecExamplesResponseBodyExamplesRequestSensitiveData> RequestSensitiveData { get; set; }
            public class DescribeApisecExamplesResponseBodyExamplesRequestSensitiveData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("SensitiveCode")]
                [Validation(Required=false)]
                public string SensitiveCode { get; set; }

                [NameInMap("SensitiveDataList")]
                [Validation(Required=false)]
                public List<string> SensitiveDataList { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;header&quot;: {
            ///     &quot;Connection&quot;: &quot;keep-alive&quot;,
            ///     &quot;Content-Encoding&quot;: &quot;gzip&quot;,
            ///     &quot;Content-Type&quot;: &quot;text/html; charset=UTF-8&quot;
            ///   },
            ///   &quot;body&quot;: &quot;xxxx&quot;,
            ///   &quot;status&quot;: 200
            /// }</para>
            /// </summary>
            [NameInMap("Response")]
            [Validation(Required=false)]
            public string Response { get; set; }

            [NameInMap("ResponseSensitiveData")]
            [Validation(Required=false)]
            public List<DescribeApisecExamplesResponseBodyExamplesResponseSensitiveData> ResponseSensitiveData { get; set; }
            public class DescribeApisecExamplesResponseBodyExamplesResponseSensitiveData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("SensitiveCode")]
                [Validation(Required=false)]
                public string SensitiveCode { get; set; }

                [NameInMap("SensitiveDataList")]
                [Validation(Required=false)]
                public List<string> SensitiveDataList { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAGBgV9tolsLfijC4wam2htS*****D/46H3X2wIS</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
