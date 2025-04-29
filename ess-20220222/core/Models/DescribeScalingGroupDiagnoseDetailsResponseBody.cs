// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingGroupDiagnoseDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the diagnostic report.</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<DescribeScalingGroupDiagnoseDetailsResponseBodyDetails> Details { get; set; }
        public class DescribeScalingGroupDiagnoseDetailsResponseBodyDetails : TeaModel {
            /// <summary>
            /// <para>Item type for diagnostics. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>AccountArrearage: Checks if the user\&quot;s account is in arrears.</description></item>
            /// <item><description>AccountNotEnoughBalance: Checks the account balance.</description></item>
            /// <item><description>ElasticStrength: Checks the inventory health of instance types corresponding to the scaling group configuration.</description></item>
            /// <item><description>VSwitch: Checks if the switch is available, for example, whether it has been deleted.</description></item>
            /// <item><description>SecurityGroup: Checks if the security group is available, for example, whether it has been deleted.</description></item>
            /// <item><description>KeyPair: Checks if the key pair is available, for example, whether it has been deleted.</description></item>
            /// <item><description>SlbBackendServerQuota: Checks if the number of ECS instances mounted to the default SLB group and virtual server group exceeds the quota.</description></item>
            /// <item><description>AlbBackendServerQuota: Checks if the number of ECS instances mounted to the ALB group exceeds the quota.</description></item>
            /// <item><description>NlbBackendServerQuota: Checks if the number of ECS instances mounted to the NLB group exceeds the quota.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SecurityGroup</para>
            /// </summary>
            [NameInMap("DiagnoseType")]
            [Validation(Required=false)]
            public string DiagnoseType { get; set; }

            /// <summary>
            /// <para>Error code of the diagnostic item. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>VSwitchIdNotFound: The VSwitch does not exist.</para>
            /// </description></item>
            /// <item><description><para>SecurityGroupNotFound: The security group does not exist.</para>
            /// </description></item>
            /// <item><description><para>KeyPairNotFound: The key pair does not exist.</para>
            /// </description></item>
            /// <item><description><para>SlbBackendServerQuotaExceeded: The number of ECS instances mounted on the backend of the SLB default group and virtual server group exceeds the quota.</para>
            /// </description></item>
            /// <item><description><para>AlbBackendServerQuotaExceeded: The number of ECS instances mounted on the backend of the ALB group exceeds the quota.</para>
            /// </description></item>
            /// <item><description><para>NlbBackendServerQuotaExceeded: The number of ECS instances mounted on the backend of the NLB group exceeds the quota.</para>
            /// </description></item>
            /// <item><description><para>AccountArrearage: The account is in arrears.</para>
            /// </description></item>
            /// <item><description><para>AccountNotEnoughBalance: The account balance is insufficient.</para>
            /// </description></item>
            /// <item><description><para>ElasticStrengthAlert: The inventory health is poor.</para>
            /// </description></item>
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
