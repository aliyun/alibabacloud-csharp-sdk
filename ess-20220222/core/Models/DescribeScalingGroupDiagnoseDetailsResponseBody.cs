// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingGroupDiagnoseDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The diagnostic reports.</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<DescribeScalingGroupDiagnoseDetailsResponseBodyDetails> Details { get; set; }
        public class DescribeScalingGroupDiagnoseDetailsResponseBodyDetails : TeaModel {
            /// <summary>
            /// <para>The type of the diagnostic item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AccountArrearage: Checks whether your Alibaba Cloud account has overdue payments.</description></item>
            /// <item><description>AccountNotEnoughBalance: Checks whether the balance of your Alibaba Cloud account is sufficient.</description></item>
            /// <item><description>ElasticStrength: Checks whether the instance types that are specified in the scaling configuration are sufficient.</description></item>
            /// <item><description>VSwitch: Checks whether the vSwitch is available. If the specified vSwitch is deleted, specify an existing vSwitch for the scaling group.</description></item>
            /// <item><description>SecurityGroup: Checks whether the security group is available. If the specified security group is deleted, specify an existing security group for the scaling group.</description></item>
            /// <item><description>KeyPair: Checks whether the key pair is available. If the specified key pair is deleted, specify another key pair for the scaling group.</description></item>
            /// <item><description>SlbBackendServerQuota: Checks whether the number of ECS instances that are added to the default server group and the vServer groups of the SLB instances associated with the scaling group has reached the upper limit.</description></item>
            /// <item><description>AlbBackendServerQuota: Checks whether the number of ECS instances that are attached to the ALB instances of the scaling group has reached the upper limit.</description></item>
            /// <item><description>NlbBackendServerQuota: Checks whether the number of ECS instances that are attached to the NLB instances of the scaling group has reached the upper limit.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SecurityGroup</para>
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
            /// <item><description>AccountArrearage: Your account has an overdue payment.</description></item>
            /// <item><description>AccountNotEnoughBalance: The balance of your Alibaba Cloud account is insufficient.</description></item>
            /// <item><description>ElasticStrengthAlert: The inventory levels are lower than required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AccountArrearage</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The resource ID corresponding to the diagnostic result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-280ih****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>Status of the diagnostic item. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>Normal: The diagnostic result is normal.</para>
            /// </description></item>
            /// <item><description><para>Warn: The diagnostic result is a warning.</para>
            /// </description></item>
            /// <item><description><para>Critical: The diagnostic result is critical.</para>
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
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>688B18B8-FB1E-42EB-A1ED-7F55B090****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
