// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListSecretsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSecretsResponseBodyData Data { get; set; }
        public class ListSecretsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Secrets.</para>
            /// </summary>
            [NameInMap("Secrets")]
            [Validation(Required=false)]
            public List<ListSecretsResponseBodyDataSecrets> Secrets { get; set; }
            public class ListSecretsResponseBodyDataSecrets : TeaModel {
                /// <summary>
                /// <para>The time when the Secret was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593760185111</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The namespace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing:test</para>
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// <para>The associated applications.</para>
                /// </summary>
                [NameInMap("RelateApps")]
                [Validation(Required=false)]
                public List<ListSecretsResponseBodyDataSecretsRelateApps> RelateApps { get; set; }
                public class ListSecretsResponseBodyDataSecretsRelateApps : TeaModel {
                    /// <summary>
                    /// <para>The application ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>f16b4000-9058-4c22-a49d-49a28f0b****</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>The application name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-app</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                }

                /// <summary>
                /// <para>The Secret ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("SecretId")]
                [Validation(Required=false)]
                public long? SecretId { get; set; }

                /// <summary>
                /// <para>The Secret name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry-auth</para>
                /// </summary>
                [NameInMap("SecretName")]
                [Validation(Required=false)]
                public string SecretName { get; set; }

                /// <summary>
                /// <para>The Secret type.</para>
                /// <para>Set the value to <b>kubernetes.io/dockerconfigjson</b>. The value indicates the secret for the username and password of the image repository and is used for authentication when images are pulled during application deployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kubernetes.io/dockerconfigjson</para>
                /// </summary>
                [NameInMap("SecretType")]
                [Validation(Required=false)]
                public string SecretType { get; set; }

                /// <summary>
                /// <para>The time when the Secret was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593760185111</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code returned. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the call is successful, the <b>ErrorCode</b> parameter is not returned.</description></item>
        /// <item><description>If the call fails, the <b>ErrorCode</b> parameter is returned. For more information, see the &quot;<b>Error codes</b>&quot; section in this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Null</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the call is successful, <b>success</b> is returned.</description></item>
        /// <item><description>If the call fails, an error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID that is used to query the details of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
