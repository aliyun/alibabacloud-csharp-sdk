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
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A client error occurred.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSecretsResponseBodyData Data { get; set; }
        public class ListSecretsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of Secret instances.</para>
            /// </summary>
            [NameInMap("Secrets")]
            [Validation(Required=false)]
            public List<ListSecretsResponseBodyDataSecrets> Secrets { get; set; }
            public class ListSecretsResponseBodyDataSecrets : TeaModel {
                /// <summary>
                /// <para>The time when the Secret instance was created.</para>
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
                /// <para>The Secret instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("SecretId")]
                [Validation(Required=false)]
                public long? SecretId { get; set; }

                /// <summary>
                /// <para>The Secret instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry-auth</para>
                /// </summary>
                [NameInMap("SecretName")]
                [Validation(Required=false)]
                public string SecretName { get; set; }

                /// <summary>
                /// <para>The type of the Secret instance. The only valid value is:</para>
                /// <para><b>kubernetes.io/dockerconfigjson</b>: a Secret that stores credentials for a container image registry and is used to authenticate image pulls during deployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kubernetes.io/dockerconfigjson</para>
                /// </summary>
                [NameInMap("SecretType")]
                [Validation(Required=false)]
                public string SecretType { get; set; }

                /// <summary>
                /// <para>The time when the Secret instance was last updated.</para>
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
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>This parameter is returned if the request fails. For more information, see the <b>Error codes</b> section.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, <b>success</b> is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, an error message is returned.</para>
        /// </description></item>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID. You can use this ID to query the details of a call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
