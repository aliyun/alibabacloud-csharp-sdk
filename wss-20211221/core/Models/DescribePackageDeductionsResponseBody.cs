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
            /// <para>The agent type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenClaw</para>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

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
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-xxxx</para>
            /// </summary>
            [NameInMap("DeductionRequestId")]
            [Validation(Required=false)]
            public string DeductionRequestId { get; set; }

            /// <summary>
            /// <para>The deduction types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KNOWLEDGE_SPACE/CONVESATION</para>
            /// </summary>
            [NameInMap("DeductionType")]
            [Validation(Required=false)]
            public string DeductionType { get; set; }

            /// <summary>
            /// <para>The Cloud Desktop ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-6wye9optu0kag****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The name of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DemoComputer</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The specifications of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eds.enterprise_office.4c8g</para>
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// <para>The end time of the deduction record in UTC. The format is yyyy-MM-ddTHH:mm:ssZ. For records aggregated by hour, the format can be yyyy-MM-ddTHH:mmZ with seconds omitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-31T03:00:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The group resource type to which the deduction record belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GROUP_CORE_PACKAGE</para>
            /// </summary>
            [NameInMap("GroupResourceType")]
            [Validation(Required=false)]
            public string GroupResourceType { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A specific instance ID</para>
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
            /// <para>The instance specifications for the deduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ec.agentbay-pc</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The memory. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-3.7</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The operating system type of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The ID of the credit package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crp-xxx</para>
            /// </summary>
            [NameInMap("PackageId")]
            [Validation(Required=false)]
            public string PackageId { get; set; }

            /// <summary>
            /// <para>The region ID of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the first resource in the deduction item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-xxx</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

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
            /// <para>The ID of the session associated with the deduction record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ai-123456****</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The start time of the deduction record in UTC. The format is yyyy-MM-ddTHH:mm:ssZ. For records aggregated by hour, the format can be yyyy-MM-ddTHH:mmZ with seconds omitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-31T02:00:00Z</para>
            /// </summary>
            [NameInMap("StaTime")]
            [Validation(Required=false)]
            public string StaTime { get; set; }

            /// <summary>
            /// <para>The summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Summary of the AI query</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The number of cores deducted.</para>
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
            /// <para>The usage calculated from UsedTime by using a precision factor, rounded to four decimal places. This field is returned only for applicable resource types and must be read based on the metering criteria of the corresponding resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0000</para>
            /// </summary>
            [NameInMap("UsedTimeDecimal")]
            [Validation(Required=false)]
            public string UsedTimeDecimal { get; set; }

            /// <summary>
            /// <para>The usage that includes the deduction coefficient. In scenarios where deduction is based on duration, the value is measured in seconds and returned as an integer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
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
        /// <para>The number of entries per page in the Settings for paging during a paged query.</para>
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
        /// <para>The total number of core-hour package deduction details queried.</para>
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
        /// <para>The total usage calculated by using a precision factor, rounded to four decimal places. This field uses the same metering criteria as UsedTimeDecimal in the details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0000</para>
        /// </summary>
        [NameInMap("TotalUsedTimeDecimal")]
        [Validation(Required=false)]
        public string TotalUsedTimeDecimal { get; set; }

    }

}
