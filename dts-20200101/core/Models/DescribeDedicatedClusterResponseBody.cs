// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDedicatedClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The CPU utilization percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("CpuUtilization")]
        [Validation(Required=false)]
        public long? CpuUtilization { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsCluster****</para>
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>daily_test</para>
        /// </summary>
        [NameInMap("DedicatedClusterName")]
        [Validation(Required=false)]
        public string DedicatedClusterName { get; set; }

        /// <summary>
        /// <para>The disk utilization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DiskUtilization")]
        [Validation(Required=false)]
        public long? DiskUtilization { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsb8r****</para>
        /// </summary>
        [NameInMap("DtsInstanceID")]
        [Validation(Required=false)]
        public string DtsInstanceID { get; set; }

        /// <summary>
        /// <para>The number of DUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Du")]
        [Validation(Required=false)]
        public long? Du { get; set; }

        /// <summary>
        /// <para>The DU utilization percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("DuUtilization")]
        [Validation(Required=false)]
        public long? DuUtilization { get; set; }

        /// <summary>
        /// <para>The error code returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Value of Input Parameter %s is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1642476144000</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public long? GmtCreated { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1645200000000</para>
        /// </summary>
        [NameInMap("GmtFinished")]
        [Validation(Required=false)]
        public long? GmtFinished { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The memory utilization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MemUtilization")]
        [Validation(Required=false)]
        public long? MemUtilization { get; set; }

        /// <summary>
        /// <para>The number of nodes in the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public long? NodeCount { get; set; }

        /// <summary>
        /// <para>The number of oversold DUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("OversoldDu")]
        [Validation(Required=false)]
        public long? OversoldDu { get; set; }

        /// <summary>
        /// <para>The region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>621BB4F8-3016-4FAA-8D5A-5D3163CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The cluster status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>init</b>: initialization.</description></item>
        /// <item><description><b>schedule</b>: pending scheduling.</description></item>
        /// <item><description><b>running</b>: running.</description></item>
        /// <item><description><b>upgrade</b>: upgrading.</description></item>
        /// <item><description><b>downgrade</b>: downgrading.</description></item>
        /// <item><description><b>locked</b>: locked.</description></item>
        /// <item><description><b>releasing</b>: being released.</description></item>
        /// <item><description><b>released</b>: released.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>inti</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCpuCore")]
        [Validation(Required=false)]
        public long? TotalCpuCore { get; set; }

        /// <summary>
        /// <para>The total disk size, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("TotalDiskGBSize")]
        [Validation(Required=false)]
        public long? TotalDiskGBSize { get; set; }

        /// <summary>
        /// <para>The total memory size, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("TotalMemGBSize")]
        [Validation(Required=false)]
        public long? TotalMemGBSize { get; set; }

        /// <summary>
        /// <para>The number of used CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("UsedCpuCore")]
        [Validation(Required=false)]
        public long? UsedCpuCore { get; set; }

        /// <summary>
        /// <para>The used disk size, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("UsedDiskGBSize")]
        [Validation(Required=false)]
        public long? UsedDiskGBSize { get; set; }

        /// <summary>
        /// <para>The number of used DUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("UsedDu")]
        [Validation(Required=false)]
        public long? UsedDu { get; set; }

        /// <summary>
        /// <para>The used memory size, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("UsedMemGBSize")]
        [Validation(Required=false)]
        public long? UsedMemGBSize { get; set; }

    }

}
