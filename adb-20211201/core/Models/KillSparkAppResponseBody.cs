// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class KillSparkAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public KillSparkAppResponseBodyData Data { get; set; }
        public class KillSparkAppResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Spark application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s202204132018hzprec1ac****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LAKEHOUSE-1-1</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amv-bp1c3em7b2e****</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The error message returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[Advisor] Advisor feature is not available for instance: am-2ze292w4fyglwxxxx</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The execution state of the Spark application. Valid values:</para>
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
            /// <para>running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69D0810B-F9F5-5F4C-A57F-DF36133B63C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
