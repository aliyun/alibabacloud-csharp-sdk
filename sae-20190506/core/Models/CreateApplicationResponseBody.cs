// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status or POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: Success.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: Redirection.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: Request error.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: Server error.</para>
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
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateApplicationResponseBodyData Data { get; set; }
        public class CreateApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the successfully created application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>017f39b8-dfa4-4e16-a84b-1dcee4b1****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The returned release order ID, used to query the task execution status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01db03d3-3ee9-48b3-b3d0-dfce2d88****</para>
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

        }

        /// <summary>
        /// <para>The error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, the <b>ErrorCode</b> field is not returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, the <b>ErrorCode</b> field is returned. For more information, see the error code list in this topic.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>空</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Additional information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is normal, <b>success</b> is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request is abnormal, a specific error code is returned.</para>
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
        /// <para>Whether the application is created successfully. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Created successfully.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Failed to create.</para>
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
        /// <para>The trace ID, used for term query of call information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
