// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterHealthStatusResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The access nodes of the queried cluster.</para>
        /// </summary>
        [NameInMap("CS")]
        [Validation(Required=false)]
        public DescribeDBClusterHealthStatusResponseBodyCS CS { get; set; }
        public class DescribeDBClusterHealthStatusResponseBodyCS : TeaModel {
            /// <summary>
            /// <para>The number of healthy access nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }

            /// <summary>
            /// <para>The total number of access nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ExpectedCount")]
            [Validation(Required=false)]
            public long? ExpectedCount { get; set; }

            /// <summary>
            /// <para>The number of risky nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// <para>The health state of access nodes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RISK</b></description></item>
            /// <item><description><b>NORMAL</b></description></item>
            /// <item><description><b>UNAVAILABLE</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of unavailable access nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("UnavailableCount")]
            [Validation(Required=false)]
            public long? UnavailableCount { get; set; }

        }

        /// <summary>
        /// <para>The compute node groups of the queried cluster.</para>
        /// </summary>
        [NameInMap("Executor")]
        [Validation(Required=false)]
        public DescribeDBClusterHealthStatusResponseBodyExecutor Executor { get; set; }
        public class DescribeDBClusterHealthStatusResponseBodyExecutor : TeaModel {
            /// <summary>
            /// <para>The number of healthy access nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }

            /// <summary>
            /// <para>The total number of compute nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ExpectedCount")]
            [Validation(Required=false)]
            public long? ExpectedCount { get; set; }

            /// <summary>
            /// <para>The number of risky nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// <para>The health state of compute node groups. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RISK</b></description></item>
            /// <item><description><b>NORMAL</b></description></item>
            /// <item><description><b>UNAVAILABLE</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of unavailable access nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("UnavailableCount")]
            [Validation(Required=false)]
            public long? UnavailableCount { get; set; }

        }

        /// <summary>
        /// <para>The health state of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RISK</b></description></item>
        /// <item><description><b>NORMAL</b></description></item>
        /// <item><description><b>UNAVAILABLE</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> When the states of the access nodes, compute node groups, and storage node groups of a cluster are all <b>NORMAL</b> and a connection to the cluster is established, the state of the cluster is <b>NORMAL</b>. When the state of the access nodes, compute node groups, or storage node groups of the cluster is <b>RISK</b>, the state of the cluster is <b>RISK</b>. When the state of the access nodes, compute node groups, or storage node groups of the cluster is <b>UNAVAILABLE</b>, the state of the cluster is <b>UNAVAILABLE</b>.</para>
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
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The storage node groups of the queried cluster.</para>
        /// </summary>
        [NameInMap("Worker")]
        [Validation(Required=false)]
        public DescribeDBClusterHealthStatusResponseBodyWorker Worker { get; set; }
        public class DescribeDBClusterHealthStatusResponseBodyWorker : TeaModel {
            /// <summary>
            /// <para>The number of healthy storage node groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }

            /// <summary>
            /// <para>The total number of storage node groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ExpectedCount")]
            [Validation(Required=false)]
            public long? ExpectedCount { get; set; }

            /// <summary>
            /// <para>The number of risky storage node groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            /// <summary>
            /// <para>The health state of storage node groups. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RISK</b></description></item>
            /// <item><description><b>NORMAL</b></description></item>
            /// <item><description><b>UNAVAILABLE</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of unavailable storage node groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("UnavailableCount")]
            [Validation(Required=false)]
            public long? UnavailableCount { get; set; }

        }

    }

}
