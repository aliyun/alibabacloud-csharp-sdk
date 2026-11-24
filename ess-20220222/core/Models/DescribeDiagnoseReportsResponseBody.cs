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
        /// <para>The list of diagnostic reports.</para>
        /// </summary>
        [NameInMap("Reports")]
        [Validation(Required=false)]
        public List<DescribeDiagnoseReportsResponseBodyReports> Reports { get; set; }
        public class DescribeDiagnoseReportsResponseBodyReports : TeaModel {
            /// <summary>
            /// <para>The time when the diagnostic report was created. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
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
                /// <item><description><para>AccountArrearage: account overdue payment. Checks whether the user account has overdue payments.</para>
                /// </description></item>
                /// <item><description><para>AccountNotEnoughBalance: insufficient account balance. Checks whether the balance of a user account on the China site is greater than or equal to CNY 100.</para>
                /// </description></item>
                /// <item><description><para>ElasticStrength: inventory health. Checks the inventory health of the instance type configured for the scaling group.</para>
                /// </description></item>
                /// <item><description><para>VSwitch: vSwitch status. Checks whether the vSwitch is active, such as whether it is deleted.</para>
                /// </description></item>
                /// <item><description><para>SecurityGroup: security group status. Checks whether the security group is active, such as whether it is deleted.</para>
                /// </description></item>
                /// <item><description><para>KeyPair: key pair status. Checks whether the key pair is active, such as whether it is deleted.</para>
                /// </description></item>
                /// <item><description><para>SlbBackendServerQuota: number of instances mounted to the SLB instance in the scaling group. Checks whether the number of ECS instances mounted to the default server group and virtual service groups of the SLB instance exceeds the quota.</para>
                /// </description></item>
                /// <item><description><para>AlbBackendServerQuota: number of instances mounted to the ALB instance in the scaling group. Checks whether the number of ECS instances mounted to the server groups of the ALB instance exceeds the quota.</para>
                /// </description></item>
                /// <item><description><para>NlbBackendServerQuota: number of instances mounted to the NLB instance in the scaling group. Checks whether the number of ECS instances mounted to the server groups of the NLB instance exceeds the quota.</para>
                /// </description></item>
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
                /// <item><description><para>VSwitchIdNotFound: the vSwitch does not exist.</para>
                /// </description></item>
                /// <item><description><para>SecurityGroupNotFound: the security group does not exist.</para>
                /// </description></item>
                /// <item><description><para>KeyPairNotFound: the key pair does not exist.</para>
                /// </description></item>
                /// <item><description><para>SlbBackendServerQuotaExceeded: the number of ECS instances mounted to the default server group and virtual service groups of the SLB instance exceeds the quota.</para>
                /// </description></item>
                /// <item><description><para>AlbBackendServerQuotaExceeded: the number of ECS instances mounted to the server groups of the ALB instance exceeds the quota.</para>
                /// </description></item>
                /// <item><description><para>NlbBackendServerQuotaExceeded: the number of ECS instances mounted to the server groups of the NLB instance exceeds the quota.</para>
                /// </description></item>
                /// <item><description><para>AccountArrearage: the account has overdue payments.</para>
                /// </description></item>
                /// <item><description><para>AccountNotEnoughBalance: the account balance is insufficient (less than CNY 100).</para>
                /// </description></item>
                /// <item><description><para>ElasticStrengthAlert: the inventory health is poor.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VSwitchIdNotFound</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-280ih****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The diagnostic status of the diagnostic item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Normal: the diagnostic result is normal.</para>
                /// </description></item>
                /// <item><description><para>Warn: the diagnostic result is a warning.</para>
                /// </description></item>
                /// <item><description><para>Critical: the diagnostic result is critical.</para>
                /// </description></item>
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
            /// <para>The diagnostic status. The value is the most severe status among the diagnostic details. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Normal: the diagnostic result is normal.</para>
            /// </description></item>
            /// <item><description><para>Warn: the diagnostic result is a warning.</para>
            /// </description></item>
            /// <item><description><para>Critical: the diagnostic result is critical.</para>
            /// </description></item>
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
            /// <item><description><para>Processing: in progress.</para>
            /// </description></item>
            /// <item><description><para>Finished: completed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public string ProcessStatus { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
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
        /// <para>Id of the request</para>
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
