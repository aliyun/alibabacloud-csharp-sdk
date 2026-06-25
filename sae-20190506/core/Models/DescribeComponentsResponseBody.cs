// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeComponentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: success</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: redirect</para>
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
        /// <para>An array of supported application components.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeComponentsResponseBodyData> Data { get; set; }
        public class DescribeComponentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The component description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open JDK 8</para>
            /// </summary>
            [NameInMap("ComponentDescription")]
            [Validation(Required=false)]
            public string ComponentDescription { get; set; }

            /// <summary>
            /// <para>The component ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open JDK 8</para>
            /// </summary>
            [NameInMap("ComponentKey")]
            [Validation(Required=false)]
            public string ComponentKey { get; set; }

            /// <summary>
            /// <para>Indicates whether the component is expired. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The component is expired.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The component is not expired.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public bool? Expired { get; set; }

            /// <summary>
            /// <para>The component type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JDK</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, the <b>ErrorCode</b> parameter is empty.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, the <b>ErrorCode</b> parameter indicates an error code. For more information, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
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
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
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
        /// <para>The trace ID used to query call details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
