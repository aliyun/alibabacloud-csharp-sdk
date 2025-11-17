// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryLastAccelerationEngineJobResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46e53*********92704c8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The entity of the most recent acceleration task.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryLastAccelerationEngineJobResponseBodyResult Result { get; set; }
        public class QueryLastAccelerationEngineJobResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Execution time, in the format yyyy-MM-dd hh:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-18 17:07:43</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>Completion time, in the format yyyy-MM-dd hh:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-18 17:08:26</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Acceleration task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>46e53********5464564</para>
            /// </summary>
            [NameInMap("JobHistoryId")]
            [Validation(Required=false)]
            public string JobHistoryId { get; set; }

            /// <summary>
            /// <para>Task status. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>TODO -- To be run</description></item>
            /// <item><description>RUNNING -- Running</description></item>
            /// <item><description>SUCCESS -- Successfully completed</description></item>
            /// <item><description>FAILURE -- Abnormally terminated</description></item>
            /// <item><description>CANCELED -- Canceled</description></item>
            /// <item><description>CHECK_DEPENDENCY -- Checking dependencies</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
