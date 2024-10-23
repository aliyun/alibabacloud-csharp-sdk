// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Health state details of access nodes.</para>
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
            /// <para>The number of risky access nodes.</para>
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
            /// <item><description><b>RISK</b>: risky</description></item>
            /// <item><description><b>NORMAL</b>: healthy</description></item>
            /// <item><description><b>UNAVAILABLE</b>: unavailable</description></item>
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
        /// <para>Health state details of compute node groups.</para>
        /// </summary>
        [NameInMap("Executor")]
        [Validation(Required=false)]
        public DescribeDBClusterHealthStatusResponseBodyExecutor Executor { get; set; }
        public class DescribeDBClusterHealthStatusResponseBodyExecutor : TeaModel {
            /// <summary>
            /// <para>The number of healthy compute node groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }

            /// <summary>
            /// <para>The total number of compute node groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ExpectedCount")]
            [Validation(Required=false)]
            public long? ExpectedCount { get; set; }

            /// <summary>
            /// <para>The number of risky compute node groups.</para>
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
            /// <item><description><b>RISK</b>: risky</description></item>
            /// <item><description><b>NORMAL</b>: healthy</description></item>
            /// <item><description><b>UNAVAILABLE</b>: unavailable</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of unavailable compute node groups.</para>
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
        /// <item><description><para><b>RISK</b>: risky</para>
        /// </description></item>
        /// <item><description><para><b>NORMAL</b>: healthy</para>
        /// </description></item>
        /// <item><description><para><b>UNAVAILABLE</b>: unavailable</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the health states of access nodes, compute node groups, and storage node groups are all <b>healthy</b> and the cluster is detected to be alive, the health state of the cluster is <b>healthy</b>. If the preceding three health states include <b>risky</b>, the health state of the cluster is <b>risky</b>. If the preceding three health states include <b>unavailable</b>, the health state of the cluster is <b>unavailable</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Health state details of storage node groups.</para>
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
            /// <item><description><b>RISK</b>: risky</description></item>
            /// <item><description><b>NORMAL</b>: healthy</description></item>
            /// <item><description><b>UNAVAILABLE</b>: unavailable</description></item>
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
