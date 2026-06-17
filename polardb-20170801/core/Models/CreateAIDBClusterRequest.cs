// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateAIDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the cluster is managed by an ACK cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("AckAdmin")]
        [Validation(Required=false)]
        public string AckAdmin { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Auto-renewal is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Auto-renewal is disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>PayType</b> is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically use a coupon. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the cluster. You can use the description to perform a fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB cluster that the application depends on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-******************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The node specification.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polar.pg.g4.6xlarge.gu4</para>
        /// </summary>
        [NameInMap("DBNodeClass")]
        [Validation(Required=false)]
        public string DBNodeClass { get; set; }

        /// <summary>
        /// <para>The extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maas</para>
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// <para>The inference engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sglang</para>
        /// </summary>
        [NameInMap("InferenceEngine")]
        [Validation(Required=false)]
        public string InferenceEngine { get; set; }

        /// <summary>
        /// <para>The Container Service for Kubernetes (ACK) cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("KubeClusterId")]
        [Validation(Required=false)]
        public string KubeClusterId { get; set; }

        /// <summary>
        /// <para>The Kubernetes configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("KubeConfig")]
        [Validation(Required=false)]
        public string KubeConfig { get; set; }

        /// <summary>
        /// <para>The management mode of the Kubernetes cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>self_k8s</para>
        /// </summary>
        [NameInMap("KubeManagement")]
        [Validation(Required=false)]
        public string KubeManagement { get; set; }

        /// <summary>
        /// <para>The type of the Kubernetes deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aideploy</para>
        /// </summary>
        [NameInMap("KubeType")]
        [Validation(Required=false)]
        public string KubeType { get; set; }

        /// <summary>
        /// <para>The Kubernetes configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("KubernetesConfig")]
        [Validation(Required=false)]
        public string KubernetesConfig { get; set; }

        /// <summary>
        /// <para>The management mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack</para>
        /// </summary>
        [NameInMap("ManagementMode")]
        [Validation(Required=false)]
        public string ManagementMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Qwen3-30B-A3B</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Postpaid</b>: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: subscription.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. This parameter is required if <b>PayType</b> is set to <b>Prepaid</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Year</b></para>
        /// </description></item>
        /// <item><description><para><b>Month</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The coupon code. If you do not specify this parameter, the default coupon is used.</para>
        /// <list type="bullet">
        /// <item><description><para>true (default): Use a coupon.</para>
        /// </description></item>
        /// <item><description><para>false: Do not use a coupon.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp**************</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The storage space. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public int? StorageSpace { get; set; }

        /// <summary>
        /// <para>The storage type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>essdpl0</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The billing intervals for the pay-as-you-go cluster.</para>
        /// </summary>
        [NameInMap("TimeSlices")]
        [Validation(Required=false)]
        public List<CreateAIDBClusterRequestTimeSlices> TimeSlices { get; set; }
        public class CreateAIDBClusterRequestTimeSlices : TeaModel {
            /// <summary>
            /// <para>The start time of the billing interval. The time is in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758729600</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            /// <summary>
            /// <para>The end time of the billing interval, which must be later than the start time. The time is in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758733200</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

        }

        /// <summary>
        /// <para>The subscription duration. This parameter is required if <b>PayType</b> is set to <b>Prepaid</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>Period</b> is set to <b>Month</b>, the value of <b>UsedTime</b> must be an integer from <c>[1-9]</c>.</para>
        /// </description></item>
        /// <item><description><para>If <b>Period</b> is set to <b>Year</b>, the value of <b>UsedTime</b> must be an integer from <c>[1-3]</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-*******************</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-**********</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The availability zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
