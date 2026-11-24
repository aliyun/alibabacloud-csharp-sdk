// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkReplSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkReplSessionResponseBodyData Data { get; set; }
        public class GetSparkReplSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the session is active. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Active.</description></item>
            /// <item><description>false: Inactive.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Active")]
            [Validation(Required=false)]
            public string Active { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>178157466101****</para>
            /// </summary>
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            /// <summary>
            /// <para>The retry ID of the Spark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s202301061000hz57d797b00002****</para>
            /// </summary>
            [NameInMap("AttemptId")]
            [Validation(Required=false)]
            public string AttemptId { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Session timed out</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The ID of the session for code execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public long? SessionId { get; set; }

            /// <summary>
            /// <para>The current session status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>IDLE: The session is idle.</description></item>
            /// <item><description>BUSY: The session is busy and executing a task.</description></item>
            /// <item><description>DEAD: The session is closed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IDEL</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The Web UI address of the Spark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://adbsparkui-cn-hangzhou.aliyuncs.com/?token=">https://adbsparkui-cn-hangzhou.aliyuncs.com/?token=</a>****</para>
            /// </summary>
            [NameInMap("WebUiAddress")]
            [Validation(Required=false)]
            public string WebUiAddress { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4CE6DF97-AEA4-484F-906F-C407EE3770EB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
