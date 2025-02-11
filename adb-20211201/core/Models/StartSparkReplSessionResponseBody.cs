// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class StartSparkReplSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public StartSparkReplSessionResponseBodyData Data { get; set; }
        public class StartSparkReplSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>178157466******</para>
            /// </summary>
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            /// <summary>
            /// <para>The attempt ID of the Spark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s202301061000h****</para>
            /// </summary>
            [NameInMap("AttemptId")]
            [Validation(Required=false)]
            public string AttemptId { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>session time out</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The ID of the session that executes the code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public long? SessionId { get; set; }

            /// <summary>
            /// <para>The status of the session. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>IDLE</description></item>
            /// <item><description>BUSY</description></item>
            /// <item><description>DEAD</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IDLE</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The URL of the web UI for the Spark application.</para>
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
        /// <para>C1797FEA-B7D6-5ED6-A24B-2C8C5F4D7361</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
