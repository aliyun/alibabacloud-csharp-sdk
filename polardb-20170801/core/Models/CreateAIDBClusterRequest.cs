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
        /// <item><description><b>true</b>: enables auto-renewal</description></item>
        /// <item><description><b>false</b>: disables auto-renewal
        /// Default value: <b>false</b>.<remarks>
        /// <para>This parameter takes effect only when the <b>PayType</b> parameter is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically apply coupons. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): applies coupons</description></item>
        /// <item><description><b>false</b>: does not apply coupons</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The initial model capacity of the instance. The value must be a positive integer. A capacity unit of 1000 is equivalent to one L20N card.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4000</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can generate the token on the client side. Ensure that the token is unique across different requests. The token is case-sensitive and can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5c******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a public endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("CreatePublicEndpoint")]
        [Validation(Required=false)]
        public string CreatePublicEndpoint { get; set; }

        /// <summary>
        /// <para>The cluster description. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The PolarDB instance ID on which the application depends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-******************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The node specifications. Call DescribeAvailableModels to query the specifications supported by the target ModelName, and select a DBNodeClass that is compatible with the model, such as polar.pg.g4.6xlarge.gu4.</para>
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
        /// <para>The ACK cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1234567890abcdef</para>
        /// </summary>
        [NameInMap("KubeClusterId")]
        [Validation(Required=false)]
        public string KubeClusterId { get; set; }

        /// <summary>
        /// <para>The Kubernetes configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiVersion: v1
        /// clusters: []
        /// contexts: []
        /// kind: Config
        /// users: []</para>
        /// </summary>
        [NameInMap("KubeConfig")]
        [Validation(Required=false)]
        public string KubeConfig { get; set; }

        /// <summary>
        /// <para>The Kubernetes cluster management mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>self_k8s</para>
        /// </summary>
        [NameInMap("KubeManagement")]
        [Validation(Required=false)]
        public string KubeManagement { get; set; }

        /// <summary>
        /// <para>The deployment type.</para>
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
        /// <para>{&quot;namespace&quot;:&quot;default&quot;}</para>
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
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen3-30B-A3B</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model operator space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pms-xxx</para>
        /// </summary>
        [NameInMap("ModelSpace")]
        [Validation(Required=false)]
        public string ModelSpace { get; set; }

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
        /// <para>Example@123</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
        /// <item><description><b>Prepaid</b>: subscription</description></item>
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
        /// <para>If the billing method is <b>Prepaid</b>, this parameter is required. Specifies the billing cycle of the subscription cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: yearly. The unit is year when you select the subscription billing method.</description></item>
        /// <item><description><b>Month</b>: monthly. The unit is month when you select the subscription billing method.</description></item>
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
        /// <para>The security group ID. This parameter is actually required. If it is not provided, the service returns MethodArgumentNotValidException (400). You can call the ECS DescribeSecurityGroups operation to obtain the security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp**************</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The storage space.</para>
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
        /// <para>The pay-as-you-go time ranges.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("TimeSlices")]
        [Validation(Required=false)]
        public List<CreateAIDBClusterRequestTimeSlices> TimeSlices { get; set; }
        public class CreateAIDBClusterRequestTimeSlices : TeaModel {
            /// <summary>
            /// <para>The start time of the task. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758729600</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            /// <summary>
            /// <para>The end time. The end time must be later than the start time. Specify the time in the <c>YYYY-MM-DDThh:mmZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758733200</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

        }

        /// <summary>
        /// <para>The subscription duration. This parameter is required when the billing method is <b>Prepaid</b>.</para>
        /// <list type="bullet">
        /// <item><description>If <b>Period</b> is set to <b>Month</b>, the value of <b>UsedTime</b> is an integer ranging from <c>1</c> to <c>9</c>.</description></item>
        /// <item><description>If <b>Period</b> is set to <b>Year</b>, the value of <b>UsedTime</b> is an integer ranging from <c>1</c> to <c>3</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
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
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
