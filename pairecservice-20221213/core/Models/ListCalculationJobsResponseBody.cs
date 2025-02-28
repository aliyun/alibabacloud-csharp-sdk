// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListCalculationJobsResponseBody : TeaModel {
        [NameInMap("CalculationJobs")]
        [Validation(Required=false)]
        public List<ListCalculationJobsResponseBodyCalculationJobs> CalculationJobs { get; set; }
        public class ListCalculationJobsResponseBodyCalculationJobs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pv</para>
            /// </summary>
            [NameInMap("ABMetricName")]
            [Validation(Required=false)]
            public string ABMetricName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-15</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CalculationJobId")]
            [Validation(Required=false)]
            public string CalculationJobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtRanTime")]
            [Validation(Required=false)]
            public string GmtRanTime { get; set; }

            [NameInMap("JobMessage")]
            [Validation(Required=false)]
            public List<string> JobMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CronOffline</para>
            /// </summary>
            [NameInMap("JobSource")]
            [Validation(Required=false)]
            public string JobSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F7AC05FF-EDE7-5C2B-B9AE-33D6DF4178BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
