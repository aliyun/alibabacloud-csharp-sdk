// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListCalculationJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of calculation jobs.</para>
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
            /// <para>The business date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            /// <summary>
            /// <para>The calculation job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CalculationJobId")]
            [Validation(Required=false)]
            public string CalculationJobId { get; set; }

            /// <summary>
            /// <para>The job configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The time when the job was run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtRanTime")]
            [Validation(Required=false)]
            public string GmtRanTime { get; set; }

            /// <summary>
            /// <para>The job messages.</para>
            /// </summary>
            [NameInMap("JobMessage")]
            [Validation(Required=false)]
            public List<string> JobMessage { get; set; }

            /// <summary>
            /// <para>The source of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CronOffline: The job is an offline scheduled task.</para>
            /// </description></item>
            /// <item><description><para>DataRerun: The job is a data rerun task.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CronOffline</para>
            /// </summary>
            [NameInMap("JobSource")]
            [Validation(Required=false)]
            public string JobSource { get; set; }

            /// <summary>
            /// <para>The status of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Success</para>
            /// </description></item>
            /// <item><description><para>Failure</para>
            /// </description></item>
            /// <item><description><para>Initializing</para>
            /// </description></item>
            /// <item><description><para>Running</para>
            /// </description></item>
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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
