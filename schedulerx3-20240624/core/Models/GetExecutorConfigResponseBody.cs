// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetExecutorConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The configuration data for the Executor.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetExecutorConfigResponseBodyData Data { get; set; }
        public class GetExecutorConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The default global configuration for Data Integration tasks. This configuration specifies the default handling policies for different types of DDL messages. Example:
            /// <c>{&quot;RENAMECOLUMN&quot;:&quot;WARNING&quot;,&quot;DROPTABLE&quot;:&quot;WARNING&quot;,&quot;CREATETABLE&quot;:&quot;WARNING&quot;,&quot;MODIFYCOLUMN&quot;:&quot;WARNING&quot;,&quot;TRUNCATETABLE&quot;:&quot;WARNING&quot;,&quot;DROPCOLUMN&quot;:&quot;WARNING&quot;,&quot;ADDCOLUMN&quot;:&quot;WARNING&quot;,&quot;RENAMETABLE&quot;:&quot;WARNING&quot;}</c></para>
            /// <para>The DDL message types are as follows:</para>
            /// <list type="bullet">
            /// <item><description><para>RENAMECOLUMN: <c>RENAME COLUMN</c></para>
            /// </description></item>
            /// <item><description><para>DROPTABLE: <c>DROP TABLE</c></para>
            /// </description></item>
            /// <item><description><para>CREATETABLE: <c>CREATE TABLE</c></para>
            /// </description></item>
            /// <item><description><para>MODIFYCOLUMN: <c>MODIFY COLUMN</c></para>
            /// </description></item>
            /// <item><description><para>TRUNCATETABLE: <c>TRUNCATE TABLE</c></para>
            /// </description></item>
            /// <item><description><para>DROPCOLUMN: <c>DROP COLUMN</c></para>
            /// </description></item>
            /// <item><description><para>ADDCOLUMN: <c>ADD COLUMN</c></para>
            /// </description></item>
            /// <item><description><para>RENAMETABLE: <c>RENAME TABLE</c></para>
            /// </description></item>
            /// </list>
            /// <para>When DataWorks receives a DDL message, it applies one of the following handling policies:</para>
            /// <list type="bullet">
            /// <item><description><para>WARNING: Discards the message and logs a warning in the Real-time Synchronization Task log.</para>
            /// </description></item>
            /// <item><description><para>IGNORE: Discards the message without sending it to the Destination Data Source.</para>
            /// </description></item>
            /// <item><description><para>CRITICAL: Causes the Real-time Synchronization Task to fail.</para>
            /// </description></item>
            /// <item><description><para>NORMAL: Forwards the message to the Destination Data Source. Because handling of DDL messages can vary by Destination Data Source, DataWorks only forwards the message.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;cluster&quot;:&quot;c2c619b5129e0400fa3df263b249622aa&quot;,&quot;namespace&quot;:&quot;default&quot;,&quot;service&quot;:&quot;xxljob-http-demo1-svc&quot;}]</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The type of the Executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s_service</para>
            /// </summary>
            [NameInMap("ExecutorType")]
            [Validation(Required=false)]
            public string ExecutorType { get; set; }

        }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>not support query script history, please upgrade engine version to 2.2.2+</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
