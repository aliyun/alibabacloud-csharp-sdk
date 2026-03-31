// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetApiKeyResponseBody : TeaModel {
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public GetApiKeyResponseBodyApiKey ApiKey { get; set; }
        public class GetApiKeyResponseBodyApiKey : TeaModel {
            /// <summary>
            /// <para>API Key ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2965964</para>
            /// </summary>
            [NameInMap("apiKeyId")]
            [Validation(Required=false)]
            public long? ApiKeyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sk-ws-djI.mhU0D****testtestest</para>
            /// </summary>
            [NameInMap("apiKeyValue")]
            [Validation(Required=false)]
            public string ApiKeyValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1378030599924858</para>
            /// </summary>
            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v7</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("disabled")]
            [Validation(Required=false)]
            public int? Disabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1774338222000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ws-b2d30f148c236908</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
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
        /// <para>DFD55E7B-0615-5343-BDA0-FBEE86F29935</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
