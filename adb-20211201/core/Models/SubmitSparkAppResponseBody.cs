// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SubmitSparkAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SubmitSparkAppResponseBodyData Data { get; set; }
        public class SubmitSparkAppResponseBodyData : TeaModel {
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
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestApp</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

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
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
