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
            /// <para>The Spark application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s202204191546hzpread6a896000****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-clusterxxx</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The alert message returned for the operation, such as task execution failure or insufficient resources. If no alert occurs, null is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Insufficient resources.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The execution state of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SUBMITTED</b></description></item>
            /// <item><description><b>STARTING</b></description></item>
            /// <item><description><b>RUNNING</b></description></item>
            /// <item><description><b>FAILING</b></description></item>
            /// <item><description><b>FAILED</b></description></item>
            /// <item><description><b>KILLING</b></description></item>
            /// <item><description><b>KILLED</b></description></item>
            /// <item><description><b>SUCCEEDING</b></description></item>
            /// <item><description><b>COMPLETED</b></description></item>
            /// <item><description><b>FATAL</b></description></item>
            /// <item><description><b>UNKNOWN</b></description></item>
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
