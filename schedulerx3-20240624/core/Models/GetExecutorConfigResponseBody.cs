// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetExecutorConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetExecutorConfigResponseBodyData Data { get; set; }
        public class GetExecutorConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The default global configuration content for the Data Integration synchronization Solutions node, which specifies the default processing policy for different DDL message types. Example:
            /// {&quot;RENAMECOLUMN&quot;:&quot;WARNING&quot;,&quot;DROPTABLE&quot;:&quot;WARNING&quot;,&quot;CREATETABLE&quot;:&quot;WARNING&quot;,&quot;MODIFYCOLUMN&quot;:&quot;WARNING&quot;,&quot;TRUNCATETABLE&quot;:&quot;WARNING&quot;,&quot;DROPCOLUMN&quot;:&quot;WARNING&quot;,&quot;ADDCOLUMN&quot;:&quot;WARNING&quot;,&quot;RENAMETABLE&quot;:&quot;WARNING&quot;}</para>
            /// <para>DDL message types:</para>
            /// <list type="bullet">
            /// <item><description>RENAMECOLUMN: Rename a column.</description></item>
            /// <item><description>DROPTABLE: Delete a table.</description></item>
            /// <item><description>CREATETABLE: Create a table.</description></item>
            /// <item><description>MODIFYCOLUMN: Modify a column type.</description></item>
            /// <item><description>TRUNCATETABLE: Truncate a table.</description></item>
            /// <item><description>DROPCOLUMN: Delete a column.</description></item>
            /// <item><description>ADDCOLUMN: Add a column.</description></item>
            /// <item><description>RENAMETABLE: Rename a table.</description></item>
            /// </list>
            /// <para>When DataWorks receives a DDL message of the corresponding type, the processing policy is as follows:</para>
            /// <list type="bullet">
            /// <item><description>WARNING: Discard the message directly and record alerting information in the real-time synchronization log, indicating that the message was discarded due to an execute error.</description></item>
            /// <item><description>IGNORE: Discard the message directly without sending it to the destination data source.</description></item>
            /// <item><description>CRITICAL: Set the real-time synchronization node to the error state and stop the node.</description></item>
            /// <item><description>NORMAL: Forward the message to the destination data source for processing. Because different destination data sources may have a different processing policy for DDL messages, DataWorks only forwards the message.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;cluster&quot;:&quot;c2c619b5129e0400fa3df263b249622aa&quot;,&quot;namespace&quot;:&quot;default&quot;,&quot;service&quot;:&quot;xxljob-http-demo1-svc&quot;}]</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The executor type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s_service</para>
            /// </summary>
            [NameInMap("ExecutorType")]
            [Validation(Required=false)]
            public string ExecutorType { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>not support query script history, please upgrade engine version to 2.2.2+</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>39938688-0BAB-5AD8-BF02-F4910FAC7589</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
