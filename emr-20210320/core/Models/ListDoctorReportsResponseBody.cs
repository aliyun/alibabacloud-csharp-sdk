// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The reports.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDoctorReportsResponseBodyData> Data { get; set; }
        public class ListDoctorReportsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The component types.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>compute</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>hive</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>hdfs</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>yarn</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>oss</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>hbase</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ComponentTypes")]
            [Validation(Required=false)]
            public List<string> ComponentTypes { get; set; }

            /// <summary>
            /// <para>The date on which the report was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-29</para>
            /// </summary>
            [NameInMap("DateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            /// <summary>
            /// <para>The summary of the report.</para>
            /// </summary>
            [NameInMap("SummaryReport")]
            [Validation(Required=false)]
            public ListDoctorReportsResponseBodyDataSummaryReport SummaryReport { get; set; }
            public class ListDoctorReportsResponseBodyDataSummaryReport : TeaModel {
                /// <summary>
                /// <para>The score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// <para>The optimization suggestion.</para>
                /// 
                /// <b>Example:</b>
                /// <h3>Compute health score: 88. The cluster is in healthy state. Keep it up.</h3><list type="bullet"><item><description><b>Compute task scan</b><list type="bullet"><item><description>Scanned 1518 compute tasks in the cluster: <span style=\\"color: #D93026;\\">209 tasks in unhealthy state</span>, <span style=\\"color: #F1A600;\\">596 tasks in sub-healthy state</span>, <span style=\\"color: #1E8E3E;\\">713 tasks in healthy state</span>.</description></item></list><list type="bullet"><item><description>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1518 Tez tasks with a weighted average score of 88. Memory usage accounts for 100.0% of the cluster, CPU usage accounts for 100.0% of the cluster. 209 tasks are in unhealthy state, 596 tasks are in sub-healthy state.</description></item></list><list type="bullet">Click \\"View Details\\" in the task detail list below to view specific issues and solutions. The \\"Low-Score Task Compute Memory Time (GB*Sec) Top 20\\" table is sorted by memory time usage. Large tasks may have a greater impact on the overall cluster, so prioritize them.</list><item><description><b><span style=\\"color: #D93026;\\">Low memory utilization</span></b><list type="bullet"><item><description>Overall cluster memory utilization is 47.8%, which is relatively low. Compute resources are being wasted. Prioritize optimizing TOP tasks with high memory compute time but low memory utilization.</description></item></list><list type="bullet"><item><description>Tez jobs have an average memory utilization of 47.8%.</description></item></list></description></item></list>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// <para>The summary of the report.</para>
                /// 
                /// <b>Example:</b>
                /// <h4>[Compute Check] Compute health score: 88. Good health. Keep it up.</h4><p style=\\"text-indent:2em\\">Most tasks in the cluster are in healthy state.</para><p style=\\"text-indent:2em\\">Cluster memory utilization: 47.8%, relatively low.</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
