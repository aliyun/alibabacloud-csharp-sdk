// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppAttemptLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkAppAttemptLogResponseBodyData Data { get; set; }
        public class GetSparkAppAttemptLogResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s202204132018hzprec1ac61a000****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;The ID of the Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.
            /// &lt;props=&quot;intl&quot;&gt;The ID of the Data Lakehouse Edition cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-bp1bg858bo8c****</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The log content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22/04/22 15:30:49 INFO Utils: Start the dump task because s202207151211hz****-0001 app end, the interval is 238141ms;22/04/22 15:30:49 INFO AbstractConnector: Stopped Spark@5e774d9d{HTTP/1.1, (http/1.1)}{0.0.0.0:4040}</para>
            /// </summary>
            [NameInMap("LogContent")]
            [Validation(Required=false)]
            public string LogContent { get; set; }

            /// <summary>
            /// <para>The number of log lines. A value of 0 indicates that no valid logs exist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>775946240</para>
            /// </summary>
            [NameInMap("LogSize")]
            [Validation(Required=false)]
            public int? LogSize { get; set; }

            /// <summary>
            /// <para>The alert message, such as task execution failure or insufficient resources. This parameter is empty if no alert is generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WARNING: log file maybe deleted, please check oss path: oss://TestBucketName/applog/</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C3A9594F-1D40-4472-A96C-8FB8AA20D38C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
