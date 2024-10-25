// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsResourceUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The resource usage data.</para>
        /// </summary>
        [NameInMap("EnsResourceUsage")]
        [Validation(Required=false)]
        public List<DescribeEnsResourceUsageResponseBodyEnsResourceUsage> EnsResourceUsage { get; set; }
        public class DescribeEnsResourceUsageResponseBodyEnsResourceUsage : TeaModel {
            /// <summary>
            /// <para>The number of edge services. This parameter is available only when you set the ServiceType parameter to 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ComputeResourceCount")]
            [Validation(Required=false)]
            public int? ComputeResourceCount { get; set; }

            /// <summary>
            /// <para>The CPU usage. Unit: cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CpuSum")]
            [Validation(Required=false)]
            public long? CpuSum { get; set; }

            /// <summary>
            /// <para>The number of data disks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("DiskCount")]
            [Validation(Required=false)]
            public int? DiskCount { get; set; }

            /// <summary>
            /// <para>The number of stopped VMs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("DownCount")]
            [Validation(Required=false)]
            public int? DownCount { get; set; }

            /// <summary>
            /// <para>The number of expired VM instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExpiredCount")]
            [Validation(Required=false)]
            public int? ExpiredCount { get; set; }

            /// <summary>
            /// <para>The number of VM instances that are about to expire.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExpiringCount")]
            [Validation(Required=false)]
            public int? ExpiringCount { get; set; }

            /// <summary>
            /// <para>The number of GPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("GpuSum")]
            [Validation(Required=false)]
            public long? GpuSum { get; set; }

            /// <summary>
            /// <para>The number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>The number of running instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("RunningCount")]
            [Validation(Required=false)]
            public int? RunningCount { get; set; }

            /// <summary>
            /// <para>The type of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: subscription instance.</description></item>
            /// <item><description>2: edge service instance.</description></item>
            /// <item><description>3: pay-as-you-go instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The total disk size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("StorageSum")]
            [Validation(Required=false)]
            public long? StorageSum { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E	 Request ID.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
