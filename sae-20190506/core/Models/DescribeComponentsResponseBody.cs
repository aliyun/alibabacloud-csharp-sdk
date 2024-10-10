// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeComponentsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the component version was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: indicates that the component version was obtained.</description></item>
        /// <item><description><b>false</b>: indicates that the component version could not be obtained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The component type.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeComponentsResponseBodyData> Data { get; set; }
        public class DescribeComponentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the component is expired. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The component is expired.</description></item>
            /// <item><description><b>false</b>: The component is not expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Open JDK 8</para>
            /// </summary>
            [NameInMap("ComponentDescription")]
            [Validation(Required=false)]
            public string ComponentDescription { get; set; }

            /// <summary>
            /// <para>The description of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open JDK 8</para>
            /// </summary>
            [NameInMap("ComponentKey")]
            [Validation(Required=false)]
            public string ComponentKey { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// <list type="bullet">
            /// <item><description>The <b>ErrorCode</b> parameter is not returned when the request succeeds.</description></item>
            /// <item><description>The <b>ErrorCode</b> parameter is returned when the request fails. For more information, see <b>Error codes</b> in this topic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public bool? Expired { get; set; }

            /// <summary>
            /// <para>The ID of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JDK</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: indicates that the request was successful.</description></item>
        /// <item><description><b>3xx</b>: indicates that the request was redirected.</description></item>
        /// <item><description><b>4xx</b>: indicates that the request was invalid.</description></item>
        /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The ID of the trace. It is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The details of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
