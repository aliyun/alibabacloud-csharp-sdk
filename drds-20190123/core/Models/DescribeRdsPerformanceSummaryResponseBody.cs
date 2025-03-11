// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRdsPerformanceSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>A collection of objects.</para>
        /// </summary>
        [NameInMap("RdsPerformanceInfos")]
        [Validation(Required=false)]
        public List<DescribeRdsPerformanceSummaryResponseBodyRdsPerformanceInfos> RdsPerformanceInfos { get; set; }
        public class DescribeRdsPerformanceSummaryResponseBodyRdsPerformanceInfos : TeaModel {
            /// <summary>
            /// <para>The number of active sessions of the RDS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ActiveSessions")]
            [Validation(Required=false)]
            public int? ActiveSessions { get; set; }

            /// <summary>
            /// <para>The CPU utilization of an RDS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.26</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// <para>The IOPS of the RDS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17.62</para>
            /// </summary>
            [NameInMap("Iops")]
            [Validation(Required=false)]
            public float? Iops { get; set; }

            /// <summary>
            /// <para>The ID of an RDS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-**************</para>
            /// </summary>
            [NameInMap("RdsId")]
            [Validation(Required=false)]
            public string RdsId { get; set; }

            /// <summary>
            /// <para>The disk usage of apsaradb for RDS. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4145144777</para>
            /// </summary>
            [NameInMap("SpaceUsage")]
            [Validation(Required=false)]
            public long? SpaceUsage { get; set; }

            /// <summary>
            /// <para>The total number of current RDS sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>162</para>
            /// </summary>
            [NameInMap("TotalSessions")]
            [Validation(Required=false)]
            public int? TotalSessions { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6876277-ECFD-4658-AC1E-A7FAD8******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
