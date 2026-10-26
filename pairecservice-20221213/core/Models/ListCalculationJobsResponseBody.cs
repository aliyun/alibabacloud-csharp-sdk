// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListCalculationJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The calculation tasks.</para>
        /// </summary>
        [NameInMap("CalculationJobs")]
        [Validation(Required=false)]
        public List<ListCalculationJobsResponseBodyCalculationJobs> CalculationJobs { get; set; }
        public class ListCalculationJobsResponseBodyCalculationJobs : TeaModel {
            /// <summary>
            /// <para>The name of the A/B metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pv</para>
            /// </summary>
            [NameInMap("ABMetricName")]
            [Validation(Required=false)]
            public string ABMetricName { get; set; }

            /// <summary>
            /// <para>The business date. The date is in the YYYY-MM-DD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            /// <summary>
            /// <para>The ID of the calculation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CalculationJobId")]
            [Validation(Required=false)]
            public string CalculationJobId { get; set; }

            /// <summary>
            /// <para>The task configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The execution time. The time is in the ISO 8601 format and includes the time zone offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtRanTime")]
            [Validation(Required=false)]
            public string GmtRanTime { get; set; }

            /// <summary>
            /// <para>The task message.</para>
            /// </summary>
            [NameInMap("JobMessage")]
            [Validation(Required=false)]
            public List<string> JobMessage { get; set; }

            /// <summary>
            /// <para>The task source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CronOffline: Offline scheduled task.</description></item>
            /// <item><description>DataRerun: Data rerun task.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CronOffline</para>
            /// </summary>
            [NameInMap("JobSource")]
            [Validation(Required=false)]
            public string JobSource { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Success: Succeeded.</description></item>
            /// <item><description>Failure: Failed.</description></item>
            /// <item><description>Initializing: Initializing.</description></item>
            /// <item><description>Running: Running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7AC05FF-EDE7-5C2B-B9AE-33D6DF4178BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
