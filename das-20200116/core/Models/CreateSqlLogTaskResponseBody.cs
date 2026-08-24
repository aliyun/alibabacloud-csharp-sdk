// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateSqlLogTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSqlLogTaskResponseBodyData Data { get; set; }
        public class CreateSqlLogTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task creation time. Specify the value as a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681363254423</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The end time. Specify the value as a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1608888296000</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }

            /// <summary>
            /// <para>The database instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-2ze8g2am97624****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Export_test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The start time. Specify the value as a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1596177993000</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: pending scheduling.</description></item>
            /// <item><description><b>RUNNING</b>: running.</description></item>
            /// <item><description><b>FAILED</b>: failed.</description></item>
            /// <item><description><b>CANCELED</b>: canceled.</description></item>
            /// <item><description><b>COMPLETED</b>: completed.</description></item>
            /// </list>
            /// <remarks>
            /// <para>When the task is in the <b>COMPLETED</b> state, you can view the task results.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>54f8041743ca3a9ac5cb9342d050527c</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83D9D59B-057A-54A9-BFF9-CF2B42F05645</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: successful.</description></item>
        /// <item><description><b>false</b>: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
