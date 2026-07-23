// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListFeatureConsistencyCheckJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of feature consistency check jobs.</para>
        /// </summary>
        [NameInMap("FeatureConsistencyCheckJobs")]
        [Validation(Required=false)]
        public List<ListFeatureConsistencyCheckJobsResponseBodyFeatureConsistencyCheckJobs> FeatureConsistencyCheckJobs { get; set; }
        public class ListFeatureConsistencyCheckJobsResponseBodyFeatureConsistencyCheckJobs : TeaModel {
            /// <summary>
            /// <para>The configuration of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The ID of the feature consistency check configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("FeatureConsistencyCheckJobConfigId")]
            [Validation(Required=false)]
            public string FeatureConsistencyCheckJobConfigId { get; set; }

            /// <summary>
            /// <para>The name of the feature consistency check job configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>feature_consistency_check_1</para>
            /// </summary>
            [NameInMap("FeatureConsistencyCheckJobConfigName")]
            [Validation(Required=false)]
            public string FeatureConsistencyCheckJobConfigName { get; set; }

            /// <summary>
            /// <para>The ID of the feature consistency check job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("FeatureConsistencyCheckJobId")]
            [Validation(Required=false)]
            public string FeatureConsistencyCheckJobId { get; set; }

            /// <summary>
            /// <para>The end time of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtEndTime")]
            [Validation(Required=false)]
            public string GmtEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtStartTime")]
            [Validation(Required=false)]
            public string GmtStartTime { get; set; }

            /// <summary>
            /// <para>A list of log entries.</para>
            /// </summary>
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<string> Logs { get; set; }

            /// <summary>
            /// <para>The status of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>ToRun</c>: Waiting to run.</para>
            /// </description></item>
            /// <item><description><para><c>Running</c>: In progress.</para>
            /// </description></item>
            /// <item><description><para><c>Success</c>: Successful.</para>
            /// </description></item>
            /// <item><description><para><c>Failure</c>: Failed.</para>
            /// </description></item>
            /// <item><description><para><c>Stopped</c>: Stopped or canceled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A04CB8C0-E74A-5E83-BC61-64D153574EC7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
