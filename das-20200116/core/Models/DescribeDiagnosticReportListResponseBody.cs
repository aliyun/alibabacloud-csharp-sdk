// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeDiagnosticReportListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information of the diagnostics reports. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>total</b>: the number of diagnostics reports.</description></item>
        /// <item><description><b>score</b>: the health score.</description></item>
        /// <item><description><b>diagnosticTime</b>: the time when the diagnostics report was generated. The time is displayed in UTC.</description></item>
        /// <item><description><b>startTime</b>: the start time of the query. The time is displayed in UTC.</description></item>
        /// <item><description><b>endTime</b>: the end time of the query. The time is displayed in UTC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;total&quot;: 1,     &quot;list&quot;: [       {         &quot;score&quot;: 100,         &quot;diagnosticTime&quot;: &quot;2022-11-14T08:17:00Z&quot;,         &quot;startTime&quot;: &quot;2022-11-14T07:16:59Z&quot;,         &quot;endTime&quot;: &quot;2022-11-14T08:16:59Z&quot;       }     ]   }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D00DB161-FEF6-5428-B37A-8D29A4C2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public string Synchro { get; set; }

    }

}
