// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateNamespaceResponseBody : TeaModel {
        /// <summary>
        /// <para>bucketPath</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about a namespace.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateNamespaceResponseBodyData Data { get; set; }
        public class CreateNamespaceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the SAE built-in registry is enabled:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableMicroRegistration")]
            [Validation(Required=false)]
            public bool? EnableMicroRegistration { get; set; }

            /// <summary>
            /// <para>Indicates whether the namespace was created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The instance was created.</description></item>
            /// <item><description><b>false</b>: The call failed to be created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("NameSpaceShortId")]
            [Validation(Required=false)]
            public string NameSpaceShortId { get; set; }

            /// <summary>
            /// <para>The short ID of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("NamespaceDescription")]
            [Validation(Required=false)]
            public string NamespaceDescription { get; set; }

            /// <summary>
            /// <para>The error code returned. Take note of the following rules:</para>
            /// <list type="bullet">
            /// <item><description>The <b>ErrorCode</b> parameter is not returned if the request succeeds.</description></item>
            /// <item><description>If the call fails, the <b>ErrorCode</b> parameter is returned. For more information, see the &quot;<b>Error codes</b>&quot; section of this topic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:test</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>Null</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("NamespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

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
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para><a href="http://sae_pop_pre/#vpc">http://sae_pop_pre/#vpc</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>bucketName</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The description of the custom namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>mountDir</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a981dd515966966104121683d****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
