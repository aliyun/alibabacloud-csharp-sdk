// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppStateResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkAppStateResponseBodyData Data { get; set; }
        public class GetSparkAppStateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s202204191546hzpread6a896000****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-bp1h405854m****</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The alert message returned, such as task execution failure or insufficient resources. This parameter is empty if no alerts are generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Insufficient resources.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The execution status of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SUBMITTED</b>: Submitted.</description></item>
            /// <item><description><b>STARTING</b>: Starting.</description></item>
            /// <item><description><b>RUNNING</b>: Running.</description></item>
            /// <item><description><b>FAILING</b>: Failing. The task failed and the environment is being cleaned up.</description></item>
            /// <item><description><b>FAILED</b>: Failed.</description></item>
            /// <item><description><b>KILLING</b>: Killing. The task is being terminated and the environment is being cleaned up.</description></item>
            /// <item><description><b>KILLED</b>: Killed.</description></item>
            /// <item><description><b>SUCCEEDING</b>: Succeeding. The task execution is complete and the environment is being cleaned up.</description></item>
            /// <item><description><b>COMPLETED</b>: Completed.</description></item>
            /// <item><description><b>FATAL</b>: Fatal error.</description></item>
            /// <item><description><b>UNKNOWN</b>: Unknown error.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65A809F-34CE-4550-9BC1-0ED21ETG380</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
