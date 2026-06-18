// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class CreateApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The API key information.</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public CreateApiKeyResponseBodyApiKey ApiKey { get; set; }
        public class CreateApiKeyResponseBodyApiKey : TeaModel {
            /// <summary>
            /// <para>API Key ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1858636</para>
            /// </summary>
            [NameInMap("apiKeyId")]
            [Validation(Required=false)]
            public long? ApiKeyId { get; set; }

            /// <summary>
            /// <para>The value of the API key.</para>
            /// <remarks>
            /// <para>Notice: Copy your API key immediately. Keep it secure. Anyone who obtains this key can initiate service requests on your behalf and incur charges. If you lose the key, you can reset it or create a new one..</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>sk-ws-djI.8O7dkfkW2aICctnid4u4</para>
            /// </summary>
            [NameInMap("apiKeyValue")]
            [Validation(Required=false)]
            public string ApiKeyValue { get; set; }

            /// <summary>
            /// <para>The creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1378030599924858</para>
            /// </summary>
            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1774338222000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-3fa048e86117d91f</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0CDC72E-52D7-5BC8-9396-9276B4FDF6B3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
