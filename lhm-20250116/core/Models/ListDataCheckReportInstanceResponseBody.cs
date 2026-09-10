// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListDataCheckReportInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of report historical instances.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListDataCheckReportInstanceResponseBodyData> Data { get; set; }
        public class ListDataCheckReportInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The batch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20001</para>
            /// </summary>
            [NameInMap("batchId")]
            [Validation(Required=false)]
            public string BatchId { get; set; }

            /// <summary>
            /// <para>The report label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>daily_check</para>
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The report generation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01 12:00:00</para>
            /// </summary>
            [NameInMap("reportTime")]
            [Validation(Required=false)]
            public string ReportTime { get; set; }

        }

        /// <summary>
        /// <para>The error code. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues for this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call failed. Troubleshoot by using errCode and errMessage.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
