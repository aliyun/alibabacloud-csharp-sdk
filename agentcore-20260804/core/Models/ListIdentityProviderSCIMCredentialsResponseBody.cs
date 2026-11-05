// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListIdentityProviderSCIMCredentialsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business result code. In case of failure, evaluate this code together with the HTTP status code and message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The operation result. For the result structure, see the response fields of this operation. The response of an asynchronous write operation indicates that the request is accepted, but does not guarantee that the background task is completed.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListIdentityProviderSCIMCredentialsResponseBodyData> Data { get; set; }
        public class ListIdentityProviderSCIMCredentialsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation time returned by AgentIdentity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-26T00:00:00Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The credential ID. This field is required and cannot be empty when deleting a credential. Use the ID returned in the credential list, not the plaintext token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>credential-example</para>
            /// </summary>
            [NameInMap("credentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }

            /// <summary>
            /// <para>The expiration time returned by AgentIdentity. Only credentials with the Enabled status that have not expired are considered available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2027-10-26T00:00:00Z</para>
            /// </summary>
            [NameInMap("expireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The credential status. Only credentials with the Enabled status that have not expired are considered available. This field is not the operationStatus of a SCIM task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The processing status of the current request. This does not indicate the final result of the background task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message indicating request acceptance or an error. For asynchronous task results, verify them by using the corresponding query operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. Used to correlate this call for troubleshooting. Retain this ID in case of failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-example</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of true indicates that the request was processed successfully. For asynchronous writes, you must continue to query the task result.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
