// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The API key information.</para>
        /// </summary>
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
            /// <para>The value of the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-ws-djI.mhU0D****testtestest</para>
            /// </summary>
            [NameInMap("apiKeyValue")]
            [Validation(Required=false)]
            public string ApiKeyValue { get; set; }

            /// <summary>
            /// <para>The permission settings.</para>
            /// </summary>
            [NameInMap("auth")]
            [Validation(Required=false)]
            public GetApiKeyResponseBodyApiKeyAuth Auth { get; set; }
            public class GetApiKeyResponseBodyApiKeyAuth : TeaModel {
                /// <summary>
                /// <para>The IP access whitelist.</para>
                /// </summary>
                [NameInMap("accessIps")]
                [Validation(Required=false)]
                public List<string> AccessIps { get; set; }

                /// <summary>
                /// <para>The model access scope.</para>
                /// </summary>
                [NameInMap("modelAccessScope")]
                [Validation(Required=false)]
                public GetApiKeyResponseBodyApiKeyAuthModelAccessScope ModelAccessScope { get; set; }
                public class GetApiKeyResponseBodyApiKeyAuthModelAccessScope : TeaModel {
                    /// <summary>
                    /// <para>The list of accessible models.</para>
                    /// </summary>
                    [NameInMap("accessibleModels")]
                    [Validation(Required=false)]
                    public List<string> AccessibleModels { get; set; }

                    /// <summary>
                    /// <para>Indicates whether all models with granted inference permissions in the workspace can be accessed. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("allowAllModels")]
                    [Validation(Required=false)]
                    public bool? AllowAllModels { get; set; }

                }

                /// <summary>
                /// <para>All: all permissions. Custom: custom permissions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

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
            /// <para>v7</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the API key is disabled.</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Active.</description></item>
            /// <item><description><b>1</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("disabled")]
            [Validation(Required=false)]
            public int? Disabled { get; set; }

            /// <summary>
            /// <para>The time when the API key was created.</para>
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
            /// <para>ws-b2d30f148c236908</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The response status code.</para>
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
        /// <para>DFD55E7B-0615-5343-BDA0-FBEE86F29935</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
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
