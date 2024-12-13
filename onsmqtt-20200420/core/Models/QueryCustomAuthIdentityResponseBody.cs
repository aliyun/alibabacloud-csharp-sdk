// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryCustomAuthIdentityResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request is successful. Other status codes indicate that the request failed. For a list of error codes, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCustomAuthIdentityResponseBodyData Data { get; set; }
        public class QueryCustomAuthIdentityResponseBodyData : TeaModel {
            /// <summary>
            /// <para>If excess return values exist, this parameter is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAAAAXA+GzVqTutYpgkFjBrchKzuvSbpuTqtt6OF9tsC9QnJ</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The returned results.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<QueryCustomAuthIdentityResponseBodyDataResults> Results { get; set; }
            public class QueryCustomAuthIdentityResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>The client ID if IdentityType is set to CLIENT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GID_ICP@@@4d378084</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The identity type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>USER</description></item>
                /// <item><description>CLIENT</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>USER</para>
                /// </summary>
                [NameInMap("IdentityType")]
                [Validation(Required=false)]
                public string IdentityType { get; set; }

                /// <summary>
                /// <para>The AccessKey secret.</para>
                /// 
                /// <b>Example:</b>
                /// <para>62a5916d71767185b48907d85c2efae2</para>
                /// </summary>
                [NameInMap("Secret")]
                [Validation(Required=false)]
                public string Secret { get; set; }

                /// <summary>
                /// <para>The signature verification mode. ORIGIN: compares the password and the AccessKey secret. SIGNED: uses the HMAC_SHA1 algorithm to sign the client ID to obtain a password and then compares the password.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SIGNED</para>
                /// </summary>
                [NameInMap("SignMode")]
                [Validation(Required=false)]
                public string SignMode { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11568B5B-13A8-4E72-9DBA-3A14F7D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
