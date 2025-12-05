// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetPtsReportsBySceneIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The system status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message. If the request was successful, this parameter is left empty.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The reports.</para>
        /// </summary>
        [NameInMap("ReportOverViewList")]
        [Validation(Required=false)]
        public List<GetPtsReportsBySceneIdResponseBodyReportOverViewList> ReportOverViewList { get; set; }
        public class GetPtsReportsBySceneIdResponseBodyReportOverViewList : TeaModel {
            /// <summary>
            /// <para>The number of stress testers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentCount")]
            [Validation(Required=false)]
            public int? AgentCount { get; set; }

            /// <summary>
            /// <para>The end time of the stress testing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-26 16:38:30</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The report ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NGGB5FV</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The title of the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PTS-test-20240920094710</para>
            /// </summary>
            [NameInMap("ReportName")]
            [Validation(Required=false)]
            public string ReportName { get; set; }

            /// <summary>
            /// <para>The start time of the stress testing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-26 16:28:30</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The consumed Virtual User Minutes (VUM).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Vum")]
            [Validation(Required=false)]
            public long? Vum { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC4E3177-6745-4925-B423-4E89VV34221A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
