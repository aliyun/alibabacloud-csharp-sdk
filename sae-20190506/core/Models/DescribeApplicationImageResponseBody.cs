// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationImageResponseBody : TeaModel {
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
        /// <para>The information about the image of the application.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationImageResponseBodyData Data { get; set; }
        public class DescribeApplicationImageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>This parameter is reserved.</para>
            /// </summary>
            [NameInMap("CrUrl")]
            [Validation(Required=false)]
            public string CrUrl { get; set; }

            /// <summary>
            /// <para>This parameter is reserved.</para>
            /// </summary>
            [NameInMap("Logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The name of the namespace to which the image repository belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// <para>The type of the repository. Only Container Registry is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALI_HUB</para>
            /// </summary>
            [NameInMap("RepoOriginType")]
            [Validation(Required=false)]
            public string RepoOriginType { get; set; }

            /// <summary>
            /// <para>The tag of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>latest</para>
            /// </summary>
            [NameInMap("RepoTag")]
            [Validation(Required=false)]
            public string RepoTag { get; set; }

            /// <summary>
            /// <para>This parameter is reserved.</para>
            /// </summary>
            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

        }

        /// <summary>
        /// <para>The error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the call is successful, the <b>ErrorCode</b> parameter is not returned.</description></item>
        /// <item><description>If the call fails, the <b>ErrorCode</b> parameter is returned. For more information, see the <b>Error codes</b> section in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>success: If the call is successful, <b>success</b> is returned.</description></item>
        /// <item><description>An error code: If the call fails, an error code is returned.</description></item>
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
        /// <para>Indicates whether the information about the image was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The information was obtained.</description></item>
        /// <item><description><b>false</b>: The information failed to be obtained.</description></item>
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
