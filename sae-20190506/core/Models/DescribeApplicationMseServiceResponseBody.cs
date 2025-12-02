// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationMseServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status or POP error code. Valid values: 2xx: The request was successful. 3xx: The request was redirected. 4xx: The request was invalid. 5xx: A server error occurred.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The application information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationMseServiceResponseBodyData Data { get; set; }
        public class DescribeApplicationMseServiceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-cn-hvm47******</para>
            /// </summary>
            [NameInMap("MseAppId")]
            [Validation(Required=false)]
            public string MseAppId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MseAppName")]
            [Validation(Required=false)]
            public string MseAppName { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sae-ent</para>
            /// </summary>
            [NameInMap("MseAppNameSpace")]
            [Validation(Required=false)]
            public string MseAppNameSpace { get; set; }

            /// <summary>
            /// <para>The application status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EXPIRED</description></item>
            /// <item><description>REBOOTING</description></item>
            /// <item><description>WAITING</description></item>
            /// <item><description>FAIL</description></item>
            /// <item><description>NULL/SUCCESS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The error code. Value description:</para>
        /// <list type="bullet">
        /// <item><description>If the request succeeds, this field is not returned.</description></item>
        /// <item><description>For more information, see the <b>Error codes</b> section of this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>System.Upgrading</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The additional information. Value description:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>success</b> is returned.</description></item>
        /// <item><description>If the request failed, an error code is returned.</description></item>
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
        /// <para>B4D805CA-926D-41B1-8E63-7AD0C1ED****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the application instance groups were obtained successfully. Valid values:</para>
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
        /// <para>The ID of the trace, which is used to query the exact call information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
