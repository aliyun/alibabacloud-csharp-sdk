// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The overview information about OceanBase instances.</para>
        /// </summary>
        [NameInMap("InstanceSummary")]
        [Validation(Required=false)]
        public DescribeInstanceSummaryResponseBodyInstanceSummary InstanceSummary { get; set; }
        public class DescribeInstanceSummaryResponseBodyInstanceSummary : TeaModel {
            /// <summary>
            /// <para>The total number of alerts during the query period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AlarmSummaryCount")]
            [Validation(Required=false)]
            public long? AlarmSummaryCount { get; set; }

            /// <summary>
            /// <para>The total number of abnormal SQL statements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AnomalySQLCount")]
            [Validation(Required=false)]
            public long? AnomalySQLCount { get; set; }

            /// <summary>
            /// <para>The number of cluster instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ClusterInstancesCount")]
            [Validation(Required=false)]
            public long? ClusterInstancesCount { get; set; }

            /// <summary>
            /// <para>The number of expired instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExpiredInstancesCount")]
            [Validation(Required=false)]
            public long? ExpiredInstancesCount { get; set; }

            /// <summary>
            /// <para>The total number of expired instances to be released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ImmediatelyExpiredInstancesCount")]
            [Validation(Required=false)]
            public long? ImmediatelyExpiredInstancesCount { get; set; }

            /// <summary>
            /// <para>The total number of clusters with capacity risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InsufficientDiskInstancesCount")]
            [Validation(Required=false)]
            public long? InsufficientDiskInstancesCount { get; set; }

            /// <summary>
            /// <para>The number of overloaded instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OverLoadInstancesCount")]
            [Validation(Required=false)]
            public long? OverLoadInstancesCount { get; set; }

            /// <summary>
            /// <para>A list of regional instances.</para>
            /// </summary>
            [NameInMap("RegionalInstanceSummaryList")]
            [Validation(Required=false)]
            public List<DescribeInstanceSummaryResponseBodyInstanceSummaryRegionalInstanceSummaryList> RegionalInstanceSummaryList { get; set; }
            public class DescribeInstanceSummaryResponseBodyInstanceSummaryRegionalInstanceSummaryList : TeaModel {
                /// <summary>
                /// <para>The number of expired instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExpiredInstancesCount")]
                [Validation(Required=false)]
                public long? ExpiredInstancesCount { get; set; }

                /// <summary>
                /// <para>The number of instances about to expire.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ImmediatelyExpiredInstancesCount")]
                [Validation(Required=false)]
                public long? ImmediatelyExpiredInstancesCount { get; set; }

                /// <summary>
                /// <para>The number of recently created instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RecentCreatedInstancesCount")]
                [Validation(Required=false)]
                public long? RecentCreatedInstancesCount { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The total number of running instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RunningInstancesCount")]
                [Validation(Required=false)]
                public long? RunningInstancesCount { get; set; }

                /// <summary>
                /// <para>The total number of instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("TotalInstancesCount")]
                [Validation(Required=false)]
                public long? TotalInstancesCount { get; set; }

            }

            /// <summary>
            /// <para>The number of running instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RunningInstancesCount")]
            [Validation(Required=false)]
            public long? RunningInstancesCount { get; set; }

            /// <summary>
            /// <para>The number of tenant instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TenantInstancesCount")]
            [Validation(Required=false)]
            public long? TenantInstancesCount { get; set; }

            /// <summary>
            /// <para>The total number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalInstancesCount")]
            [Validation(Required=false)]
            public long? TotalInstancesCount { get; set; }

            /// <summary>
            /// <para>The number of data transmission instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalOmsInstancesCount")]
            [Validation(Required=false)]
            public long? TotalOmsInstancesCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
