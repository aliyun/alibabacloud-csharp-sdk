// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeEdasContainersResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: success</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: redirection</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: request error</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: server error</para>
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
        /// <para>A list of components.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeEdasContainersResponseBodyData> Data { get; set; }
        public class DescribeEdasContainersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the component is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The component is disabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The component is not disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>The version of the application container provided by the HSF framework, such as the Ali-Tomcat container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.5.3</para>
            /// </summary>
            [NameInMap("EdasContainerVersion")]
            [Validation(Required=false)]
            public string EdasContainerVersion { get; set; }

        }

        /// <summary>
        /// <para>The error code. This parameter is returned only if the request fails. For more information, see the <b>Error codes</b> section of this topic.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, the <b>ErrorCode</b> field is not returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, the <b>ErrorCode</b> field is returned. For more information, see the <b>Error codes</b> section.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The operation succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The operation failed.</para>
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
        /// <para>The request trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
