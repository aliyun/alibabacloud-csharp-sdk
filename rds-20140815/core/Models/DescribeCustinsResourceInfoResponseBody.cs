// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCustinsResourceInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeCustinsResourceInfoResponseBodyData> Data { get; set; }
        public class DescribeCustinsResourceInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The deadline for the CPU adjustment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-25</para>
            /// </summary>
            [NameInMap("CpuAdjustDeadline")]
            [Validation(Required=false)]
            public string CpuAdjustDeadline { get; set; }

            /// <summary>
            /// <para>The maximum percentage of the system CPU resources that the instance can use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("CpuAdjustableMaxRatio")]
            [Validation(Required=false)]
            public string CpuAdjustableMaxRatio { get; set; }

            /// <summary>
            /// <para>The maximum CPU utilization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("CpuAdjustableMaxValue")]
            [Validation(Required=false)]
            public string CpuAdjustableMaxValue { get; set; }

            /// <summary>
            /// <para>The CPU utilization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CpuIncreaseRatio")]
            [Validation(Required=false)]
            public string CpuIncreaseRatio { get; set; }

            /// <summary>
            /// <para>The CPU utilization. Unit: percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("CpuIncreaseRatioValue")]
            [Validation(Required=false)]
            public string CpuIncreaseRatioValue { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-wz92gn1ll9fe5d3a4</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The maximum IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("IopsAdjustableMaxValue")]
            [Validation(Required=false)]
            public string IopsAdjustableMaxValue { get; set; }

            /// <summary>
            /// <para>The deadline for the adjustment of the maximum number of connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-25</para>
            /// </summary>
            [NameInMap("MaxConnAdjustDeadline")]
            [Validation(Required=false)]
            public string MaxConnAdjustDeadline { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxConnAdjustableMaxValue")]
            [Validation(Required=false)]
            public string MaxConnAdjustableMaxValue { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxConnIncreaseRatio")]
            [Validation(Required=false)]
            public string MaxConnIncreaseRatio { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxConnIncreaseRatioValue")]
            [Validation(Required=false)]
            public string MaxConnIncreaseRatioValue { get; set; }

            /// <summary>
            /// <para>The deadline for the adjustment of the maximum IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-25</para>
            /// </summary>
            [NameInMap("MaxIopsAdjustDeadline")]
            [Validation(Required=false)]
            public string MaxIopsAdjustDeadline { get; set; }

            /// <summary>
            /// <para>The maximum IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxIopsIncreaseRatio")]
            [Validation(Required=false)]
            public string MaxIopsIncreaseRatio { get; set; }

            /// <summary>
            /// <para>The maximum IOPS that can be supported by the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxIopsIncreaseRatioValue")]
            [Validation(Required=false)]
            public string MaxIopsIncreaseRatioValue { get; set; }

            /// <summary>
            /// <para>The maximum percentage of the system memory that the instance can use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("MemAdjustableMaxRatio")]
            [Validation(Required=false)]
            public string MemAdjustableMaxRatio { get; set; }

            /// <summary>
            /// <para>The maximum value of the resources to be evaluated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("MemAdjustableMaxValue")]
            [Validation(Required=false)]
            public string MemAdjustableMaxValue { get; set; }

            /// <summary>
            /// <para>The deadline for the memory adjustment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-25</para>
            /// </summary>
            [NameInMap("MemoryAdjustDeadline")]
            [Validation(Required=false)]
            public string MemoryAdjustDeadline { get; set; }

            /// <summary>
            /// <para>The memory increase percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-25</para>
            /// </summary>
            [NameInMap("MemoryIncreaseRatio")]
            [Validation(Required=false)]
            public string MemoryIncreaseRatio { get; set; }

            /// <summary>
            /// <para>The memory usage. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("MemoryIncreaseRatioValue")]
            [Validation(Required=false)]
            public string MemoryIncreaseRatioValue { get; set; }

            /// <summary>
            /// <para>The number of CPUs of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("OriginCpu")]
            [Validation(Required=false)]
            public string OriginCpu { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("OriginMaxConn")]
            [Validation(Required=false)]
            public string OriginMaxConn { get; set; }

            /// <summary>
            /// <para>The maximum IOPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("OriginMaxIops")]
            [Validation(Required=false)]
            public string OriginMaxIops { get; set; }

            /// <summary>
            /// <para>The actual memory used. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("OriginMemory")]
            [Validation(Required=false)]
            public string OriginMemory { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D4D4BE8A-DD46-440A-BFCD-EE31DA81C9DD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
