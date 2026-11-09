// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryCustomAuthIdentityResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. 200: The request is successful. Other codes indicate errors. For more information about error codes, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCustomAuthIdentityResponseBodyData Data { get; set; }
        public class QueryCustomAuthIdentityResponseBodyData : TeaModel {
            /// <summary>
            /// <para>If more results are available, a NextToken is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAAAAXA+GzVqTutYpgkFjBrchKzuvSbpuTqtt6OF9tsC9QnJ</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<QueryCustomAuthIdentityResponseBodyDataResults> Results { get; set; }
            public class QueryCustomAuthIdentityResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>The client ID of the device when the identity type is CLIENT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GID_ICP@@@4d378084</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The identity type.</para>
                /// <list type="bullet">
                /// <item><description><para>USER: Username only.</para>
                /// </description></item>
                /// <item><description><para>CLIENT: Specific to a client.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>USER</para>
                /// </summary>
                [NameInMap("IdentityType")]
                [Validation(Required=false)]
                public string IdentityType { get; set; }

                /// <summary>
                /// <para>The secret key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>62a5916d71767185b48907d85c2efa****</para>
                /// </summary>
                [NameInMap("Secret")]
                [Validation(Required=false)]
                public string Secret { get; set; }

                /// <summary>
                /// <para>The signature verification mode. ORIGIN: Original value comparison, which compares the password with the secret. SIGNED: The HmacSHA1 signature is calculated for the clientId using the secret for verification, and then the password is compared.</para>
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
        /// <para>The additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>11568B5B-13A8-4E72-9DBA-3A14F7D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. true: The request is successful. false: The request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
