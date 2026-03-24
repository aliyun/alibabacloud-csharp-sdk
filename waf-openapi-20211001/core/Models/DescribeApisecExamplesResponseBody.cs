// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecExamplesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of API security examples.</para>
        /// </summary>
        [NameInMap("Examples")]
        [Validation(Required=false)]
        public List<DescribeApisecExamplesResponseBodyExamples> Examples { get; set; }
        public class DescribeApisecExamplesResponseBodyExamples : TeaModel {
            /// <summary>
            /// <para>The complete URL of the API request.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.test.com/api/v1/hello.php?token=TkJGQw">http://www.test.com/api/v1/hello.php?token=TkJGQw</a></para>
            /// </summary>
            [NameInMap("ApiUrl")]
            [Validation(Required=false)]
            public string ApiUrl { get; set; }

            /// <summary>
            /// <para>The proof-of-concept (PoC) request.</para>
            /// </summary>
            [NameInMap("PocPayload")]
            [Validation(Required=false)]
            public string PocPayload { get; set; }

            /// <summary>
            /// <para>The protocol type of the API request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>http</b>: HTTP</para>
            /// </description></item>
            /// <item><description><para><b>https</b>: HTTPS</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The content of the sample request. This is a string converted from a JSON object that consists of a series of parameters. The JSON object contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>method</b>: the request method.</para>
            /// </description></item>
            /// <item><description><para><b>host</b>: the requested domain name.</para>
            /// </description></item>
            /// <item><description><para><b>header</b>: the request header.</para>
            /// </description></item>
            /// <item><description><para><b>server_port</b>: the service port.</para>
            /// </description></item>
            /// <item><description><para><b>body</b>: the request body.</para>
            /// </description></item>
            /// <item><description><para><b>url</b>: the URI of the request.</para>
            /// </description></item>
            /// <item><description><para><b>server_protocol</b>: the server-side protocol.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If the <b>body</b> content exceeds 16 KB, only a portion of the content is returned.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Request")]
            [Validation(Required=false)]
            public string Request { get; set; }

            /// <summary>
            /// <para>The list of sensitive data in the request.</para>
            /// </summary>
            [NameInMap("RequestSensitiveData")]
            [Validation(Required=false)]
            public List<DescribeApisecExamplesResponseBodyExamplesRequestSensitiveData> RequestSensitiveData { get; set; }
            public class DescribeApisecExamplesResponseBodyExamplesRequestSensitiveData : TeaModel {
                /// <summary>
                /// <para>The code that indicates the type of sensitive data in the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("SensitiveCode")]
                [Validation(Required=false)]
                public string SensitiveCode { get; set; }

                /// <summary>
                /// <para>The list of sensitive data.</para>
                /// </summary>
                [NameInMap("SensitiveDataList")]
                [Validation(Required=false)]
                public List<string> SensitiveDataList { get; set; }

            }

            /// <summary>
            /// <para>The content of the sample response. This is a string converted from a JSON object that consists of a series of parameters. The JSON object contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>status</b>: the status code.</para>
            /// </description></item>
            /// <item><description><para><b>header</b>: the response header.</para>
            /// </description></item>
            /// <item><description><para><b>body</b>: the response body.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If the <b>body</b> content exceeds 16 KB, only a portion of the content is returned.</para>
            /// </remarks>
            /// 
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

            /// <summary>
            /// <para>The list of sensitive data in the response.</para>
            /// </summary>
            [NameInMap("ResponseSensitiveData")]
            [Validation(Required=false)]
            public List<DescribeApisecExamplesResponseBodyExamplesResponseSensitiveData> ResponseSensitiveData { get; set; }
            public class DescribeApisecExamplesResponseBodyExamplesResponseSensitiveData : TeaModel {
                /// <summary>
                /// <para>The code that indicates the type of sensitive data in the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("SensitiveCode")]
                [Validation(Required=false)]
                public string SensitiveCode { get; set; }

                /// <summary>
                /// <para>The list of sensitive data.</para>
                /// </summary>
                [NameInMap("SensitiveDataList")]
                [Validation(Required=false)]
                public List<string> SensitiveDataList { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries returned on each page. Valid values: 1 to 5. Default value: 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAGBgV9tolsLfijC4wam2htS*****D/46H3X2wIS</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
