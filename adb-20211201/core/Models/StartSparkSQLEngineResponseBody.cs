// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class StartSparkSQLEngineResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public StartSparkSQLEngineResponseBodyData Data { get; set; }
        public class StartSparkSQLEngineResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Spark job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s202301xxxx</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the Spark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQLEngine1</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The state of the Spark SQL engine. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SUBMITTED</description></item>
            /// <item><description>STARTING</description></item>
            /// <item><description>RUNNING</description></item>
            /// <item><description>FAILED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUBMITTED</para>
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
