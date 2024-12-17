// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeDiagnoseReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The diagnostic reports.</para>
        /// </summary>
        [NameInMap("Reports")]
        [Validation(Required=false)]
        public List<DescribeDiagnoseReportsResponseBodyReports> Reports { get; set; }
        public class DescribeDiagnoseReportsResponseBodyReports : TeaModel {
            /// <summary>
            /// <para>The time when the diagnostic report was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-23T02:22:30Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The details of the diagnostic report.</para>
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<DescribeDiagnoseReportsResponseBodyReportsDetails> Details { get; set; }
            public class DescribeDiagnoseReportsResponseBodyReportsDetails : TeaModel {
                /// <summary>
                /// <para>The type of the diagnostic item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AccountArrearage: Checks whether your Alibaba Cloud account has overdue payments.</description></item>
                /// <item><description>AccountNotEnoughBalance: Checks whether the balance of your Alibaba Cloud account at the China site (aliyun.com) is greater than or equal to CNY 100.</description></item>
                /// <item><description>ElasticStrength: Checks whether the instance types that are specified in the scaling configuration are sufficient.</description></item>
                /// <item><description>VSwitch: Checks whether a specific vSwitch can work as expected. For example, if a vSwitch is deleted, the vSwitch cannot provide services and an exception occurs.</description></item>
                /// <item><description>SecurityGroup: Checks whether a specific security group can work as expected. For example, if a security group is deleted, the security group cannot provide services and an exception occurs.</description></item>
                /// <item><description>KeyPair: Checks whether the key pair is available. If the specified key pair is deleted, specify another key pair for the scaling group.</description></item>
                /// <item><description>SlbBackendServerQuota: Checks whether the number of ECS instances that are added to the default server group and the vServer groups of the SLB instances associated with the scaling group has reached the upper limit.</description></item>
                /// <item><description>AlbBackendServerQuota: Checks whether the number of ECS instances that are added to the backend server groups of the ALB instances associated with the scaling group has reached the upper limit.</description></item>
                /// <item><description>NlbBackendServerQuota: Checks whether the number of ECS instances that are added to the backend server groups of the NLB instances associated with the scaling group has reached the upper limit.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AccountArrearage</para>
                /// </summary>
                [NameInMap("DiagnoseType")]
                [Validation(Required=false)]
                public string DiagnoseType { get; set; }

                /// <summary>
                /// <para>The error code of the diagnostic item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>VSwitchIdNotFound: The vSwitch does not exist.</description></item>
                /// <item><description>SecurityGroupNotFound: The security group does not exist.</description></item>
                /// <item><description>KeyPairNotFound: The key pair does not exist.</description></item>
                /// <item><description>SlbBackendServerQuotaExceeded: The number of ECS instances that are added to the default server group and the vServer groups of the SLB instances associated with the scaling group has reached the upper limit.</description></item>
                /// <item><description>AlbBackendServerQuotaExceeded: The number of ECS instances that are attached to the ALB instances of the scaling group has reached the upper limit.</description></item>
                /// <item><description>NlbBackendServerQuotaExceeded: The number of ECS instances that are attached to the NLB instances of the scaling group has reached the upper limit.</description></item>
                /// <item><description>AccountArrearage: Your account has overdue payments.</description></item>
                /// <item><description>AccountNotEnoughBalance: The balance of your Alibaba Cloud account is less than CNY 100.</description></item>
                /// <item><description>ElasticStrengthAlert: The inventory levels are lower than expected.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VSwitchIdNotFound</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The ID of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-280ih****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The status of the diagnostic item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Normal: The diagnostic result is normal.</description></item>
                /// <item><description>Warn: The diagnostic result is warning.</description></item>
                /// <item><description>Critical: The diagnostic result is critical.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The status of the diagnostic item. Only the severe status is displayed in the diagnostic report. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal: The diagnostic result is normal.</description></item>
            /// <item><description>Warn: The diagnostic result is warning.</description></item>
            /// <item><description>Critical: The diagnostic result is critical.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("DiagnoseStatus")]
            [Validation(Required=false)]
            public string DiagnoseStatus { get; set; }

            /// <summary>
            /// <para>The status of the diagnostic report. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>processing: The diagnosis is in progress.</description></item>
            /// <item><description>Finished: The diagnosis is complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public string ProcessStatus { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the diagnostic report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dr-bp14p0cjp7wvjob5l6hk</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The ID of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-bp124uve5iph3*****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <para>The user ID of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>161456884*******</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECA123C6-107B-5F70-A177-740A7224C996</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of diagnostic reports.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
