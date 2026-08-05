// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribePackageDeductionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of deduction details.</para>
        /// </summary>
        [NameInMap("Deductions")]
        [Validation(Required=false)]
        public List<DescribePackageDeductionsResponseBodyDeductions> Deductions { get; set; }
        public class DescribePackageDeductionsResponseBodyDeductions : TeaModel {
            /// <summary>
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The cloud computer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-6wye9optu0kag****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The name of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DemoComputer</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The specifications of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eds.enterprise_office.4c8g</para>
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// <para>The end time of the period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-31T03:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The group resource type.</para>
            /// </summary>
            [NameInMap("GroupResourceType")]
            [Validation(Required=false)]
            public string GroupResourceType { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The status of the core-hour package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deleted</para>
            /// </summary>
            [NameInMap("InstanceState")]
            [Validation(Required=false)]
            public string InstanceState { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The operating system type of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The region ID of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Desktop</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The start time of the period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-31T02:00Z</para>
            /// </summary>
            [NameInMap("StaTime")]
            [Validation(Required=false)]
            public string StaTime { get; set; }

            /// <summary>
            /// <para>The number of cores deducted in this period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.0</para>
            /// </summary>
            [NameInMap("UsedCoreTime")]
            [Validation(Required=false)]
            public float? UsedCoreTime { get; set; }

            /// <summary>
            /// <para>The usage duration. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("UsedTime")]
            [Validation(Required=false)]
            public long? UsedTime { get; set; }

            /// <summary>
            /// <para>The usage duration in decimal format.</para>
            /// </summary>
            [NameInMap("UsedTimeDecimal")]
            [Validation(Required=false)]
            public string UsedTimeDecimal { get; set; }

            /// <summary>
            /// <para>The usage duration after proportional scaling.</para>
            /// </summary>
            [NameInMap("UsedTimeWithScale")]
            [Validation(Required=false)]
            public long? UsedTimeWithScale { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page in Settings for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>833C4D2C-09C7-5CE6-8159-06758B964970</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of deduction detail records returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The total deducted core-hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.1</para>
        /// </summary>
        [NameInMap("TotalUsedCoreTime")]
        [Validation(Required=false)]
        public float? TotalUsedCoreTime { get; set; }

        /// <summary>
        /// <para>The total usage duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("TotalUsedTime")]
        [Validation(Required=false)]
        public long? TotalUsedTime { get; set; }

        /// <summary>
        /// <para>The total usage duration in decimal format.</para>
        /// </summary>
        [NameInMap("TotalUsedTimeDecimal")]
        [Validation(Required=false)]
        public string TotalUsedTimeDecimal { get; set; }

    }

}
