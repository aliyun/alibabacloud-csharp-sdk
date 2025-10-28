// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ScaleoutApplicationWithNewInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application that you want to scale out. You can call the ListApplication operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e370c17f-*****-3df0721a327</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. This parameter takes effect only when the InstanceChargeType parameter is set to PrePaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables auto-renewal.</description></item>
        /// <item><description>false: does not enable auto-renewal. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the InstanceChargePeriodUnit parameter is set to Week, the valid values of the AutoRenewPeriod parameter are 1, 2, and 3.</description></item>
        /// <item><description>If the InstanceChargePeriodUnit parameter is set to Month, the valid values of the AutoRenewPeriod parameter are 1, 2, 3, 6, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The ID of the cluster to which you want to add ECS instances. If the application and application instance group for the scale-out are specified, this parameter is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e37**********-33df0721a327</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the instance group that you want to scale out. You can call the ListDeployGroup operation to query the group ID. For more information, see <a href="https://help.aliyun.com/document_detail/62077.html">ListDeployGroup</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e37**********-33df0721a327</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The duration of the subscription. The unit of the subscription duration is specified by the InstanceChargePeriodUnit parameter. This parameter takes effect only when the InstanceChargeType parameter is set to PrePaid.</para>
        /// <list type="bullet">
        /// <item><description>If the InstanceChargePeriodUnit parameter is set to Week, the valid values of the InstanceChargePeriod parameter are 1, 2, 3, and 4.</description></item>
        /// <item><description>If the InstanceChargePeriodUnit parameter is set to Month, the valid values of the InstanceChargePeriod parameter are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstanceChargePeriod")]
        [Validation(Required=false)]
        public int? InstanceChargePeriod { get; set; }

        /// <summary>
        /// <para>The unit of the subscription period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Week: billed on a weekly basis.</description></item>
        /// <item><description>Month: billed on a monthly basis. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("InstanceChargePeriodUnit")]
        [Validation(Required=false)]
        public string InstanceChargePeriodUnit { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription.</description></item>
        /// <item><description>PostPaid: pay-as-you-go. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The number of instances to be added for the scale-out.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ScalingNum")]
        [Validation(Required=false)]
        public int? ScalingNum { get; set; }

        /// <summary>
        /// <para>The instance reclaim mode of the scaling group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>recycle: economical mode</description></item>
        /// <item><description>release: release mode</description></item>
        /// </list>
        /// <para>For more information about how to remove instances from a specified scaling group, see <a href="https://help.aliyun.com/document_detail/25955.html">RemoveInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>release</para>
        /// </summary>
        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public string ScalingPolicy { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance launch template. You can call the DescribeLaunchTemplates operation to query the launch template ID. For more information, see <a href="https://help.aliyun.com/document_detail/73759.html">DescribeLaunchTemplates</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-****hy9s2</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the existing ECS instance used for the scale-out. If this parameter is specified, the specifications and configurations of the specified ECS instance are used as a template to purchase new instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-28wt4****</para>
        /// </summary>
        [NameInMap("TemplateInstanceId")]
        [Validation(Required=false)]
        public string TemplateInstanceId { get; set; }

        /// <summary>
        /// <para>The version of the ECS instance launch template. You can call the DescribeLaunchTemplateVersions operation to query the launch template version. For more information, see <a href="https://help.aliyun.com/document_detail/73761.html">DescribeLaunchTemplateVersions</a>.</para>
        /// <remarks>
        /// <para>If you set this parameter to <c>-1</c>, the default launch template version is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
