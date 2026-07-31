// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the authentication failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Authentication failed.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The health status of the instance access nodes.</para>
        /// </summary>
        [NameInMap("CS")]
        [Validation(Required=false)]
        public DescribeDBClusterHealthStatusResponseBodyCS CS { get; set; }
        public class DescribeDBClusterHealthStatusResponseBodyCS : TeaModel {
            /// <summary>
            /// <para>The number of healthy instance access nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }

            /// <summary>
            /// <para>The total number of instance access nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExpectedCount")]
            [Validation(Required=false)]
            public long? ExpectedCount { get; set; }

            /// <summary>
            /// <para>The number of instance access nodes at risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// <para>The health status of the instance access nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RISK</b>: The instance access nodes are at risk.</para>
            /// </description></item>
            /// <item><description><para><b>NORMAL</b>: The instance access nodes are healthy.</para>
            /// </description></item>
            /// <item><description><para><b>UNAVAILABLE</b>: The instance access nodes are unavailable.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UNAVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of unavailable instance access nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UnavailableCount")]
            [Validation(Required=false)]
            public long? UnavailableCount { get; set; }

        }

        /// <summary>
        /// <para>The health status of the executor groups.</para>
        /// </summary>
        [NameInMap("Executor")]
        [Validation(Required=false)]
        public DescribeDBClusterHealthStatusResponseBodyExecutor Executor { get; set; }
        public class DescribeDBClusterHealthStatusResponseBodyExecutor : TeaModel {
            /// <summary>
            /// <para>The number of healthy executor nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }

            /// <summary>
            /// <para>The total number of executor nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExpectedCount")]
            [Validation(Required=false)]
            public long? ExpectedCount { get; set; }

            /// <summary>
            /// <para>The number of executor nodes at risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// <para>The health status of the executor groups. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RISK</b>: The executor groups are at risk.</para>
            /// </description></item>
            /// <item><description><para><b>NORMAL</b>: The executor groups are healthy.</para>
            /// </description></item>
            /// <item><description><para><b>UNAVAILABLE</b>: The executor groups are unavailable.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UNAVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of unavailable executor nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UnavailableCount")]
            [Validation(Required=false)]
            public long? UnavailableCount { get; set; }

        }

        /// <summary>
        /// <para>The health status of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RISK</b>: The cluster is at risk.</para>
        /// </description></item>
        /// <item><description><para><b>NORMAL</b>: The cluster is healthy.</para>
        /// </description></item>
        /// <item><description><para><b>UNAVAILABLE</b>: The cluster is unavailable.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The cluster health status is considered <b>NORMAL</b> only if the instance access nodes, executor groups, and worker node groups are all <b>NORMAL</b>, and the instance is responsive. If any of these components has a <b>RISK</b> status, the cluster status is <b>RISK</b>. If any component has an <b>UNAVAILABLE</b> status, the cluster status is <b>UNAVAILABLE</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CAV</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The health status of the worker node groups.</para>
        /// </summary>
        [NameInMap("Worker")]
        [Validation(Required=false)]
        public DescribeDBClusterHealthStatusResponseBodyWorker Worker { get; set; }
        public class DescribeDBClusterHealthStatusResponseBodyWorker : TeaModel {
            /// <summary>
            /// <para>The number of healthy worker node groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }

            /// <summary>
            /// <para>The total number of worker node groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExpectedCount")]
            [Validation(Required=false)]
            public long? ExpectedCount { get; set; }

            /// <summary>
            /// <para>The number of worker node groups at risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// <para>The health status of the worker node groups. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RISK</b>: The worker node groups are at risk.</para>
            /// </description></item>
            /// <item><description><para><b>NORMAL</b>: The worker node groups are healthy.</para>
            /// </description></item>
            /// <item><description><para><b>UNAVAILABLE</b>: The worker node groups are unavailable.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UNAVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of unavailable worker node groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UnavailableCount")]
            [Validation(Required=false)]
            public long? UnavailableCount { get; set; }

        }

    }

}
