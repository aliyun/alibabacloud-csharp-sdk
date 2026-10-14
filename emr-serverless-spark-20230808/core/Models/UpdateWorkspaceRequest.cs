// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class UpdateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The resource limit of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("cu")]
        [Validation(Required=false)]
        public int? Cu { get; set; }

        /// <summary>
        /// <para>The number of GPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        /// <summary>
        /// <para>The GPU instance type.</para>
        /// </summary>
        [NameInMap("gpuSpec")]
        [Validation(Required=false)]
        public List<string> GpuSpec { get; set; }

        /// <summary>
        /// <para>The GPU subscription information.</para>
        /// </summary>
        [NameInMap("gpuSubscription")]
        [Validation(Required=false)]
        public UpdateWorkspaceRequestGpuSubscription GpuSubscription { get; set; }
        public class UpdateWorkspaceRequestGpuSubscription : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal.</para>
            /// </summary>
            [NameInMap("autoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The number of subscription periods.</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The number of GPU machines.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("gpuMachineNum")]
            [Validation(Required=false)]
            public int? GpuMachineNum { get; set; }

            /// <summary>
            /// <para>The ID of the GPU quota instance to be upgraded. This parameter is required when the operation parameter is set to UPGRADE.</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The GPU instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.gn7i-c8g1.2xlarge</para>
            /// </summary>
            [NameInMap("instanceTypeId")]
            [Validation(Required=false)]
            public string InstanceTypeId { get; set; }

            /// <summary>
            /// <para>The operation type. Valid values: BUY and UPGRADE. BUY indicates a new purchase, and UPGRADE indicates an upgrade. If you set this parameter to UPGRADE, you must specify the orderId parameter. Default value: BUY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BUY</para>
            /// </summary>
            [NameInMap("operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The subscription period unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MONTH</para>
            /// </summary>
            [NameInMap("paymentDurationUnit")]
            [Validation(Required=false)]
            public string PaymentDurationUnit { get; set; }

        }

        /// <summary>
        /// <para>The workspace IP address whitelist.</para>
        /// </summary>
        [NameInMap("ipWhiteList")]
        [Validation(Required=false)]
        public List<string> IpWhiteList { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwpi66knkxny</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The information about switching the billing method from pay-as-you-go to subscription.</para>
        /// </summary>
        [NameInMap("subscription")]
        [Validation(Required=false)]
        public UpdateWorkspaceRequestSubscription Subscription { get; set; }
        public class UpdateWorkspaceRequestSubscription : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal. This parameter is required for the subscription billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoRenew")]
            [Validation(Required=false)]
            public string AutoRenew { get; set; }

            /// <summary>
            /// <para>The auto-renewal period. This parameter is required for the subscription billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("autoRenewPeriod")]
            [Validation(Required=false)]
            public string AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>The auto-renewal cycle. This parameter is required for the subscription billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MONTH</para>
            /// </summary>
            [NameInMap("autoRenewPeriodUnit")]
            [Validation(Required=false)]
            public string AutoRenewPeriodUnit { get; set; }

            /// <summary>
            /// <para>The client token for idempotency verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-token-asxkxxxxxxx</para>
            /// </summary>
            [NameInMap("clientToken")]
            [Validation(Required=false)]
            public string ClientToken { get; set; }

            /// <summary>
            /// <para>The number of subscription periods. This parameter is required for the subscription billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1799</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The subscription period unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MONTH</para>
            /// </summary>
            [NameInMap("paymentDurationUnit")]
            [Validation(Required=false)]
            public string PaymentDurationUnit { get; set; }

            /// <summary>
            /// <para>The list of running queues to be switched.</para>
            /// </summary>
            [NameInMap("queue")]
            [Validation(Required=false)]
            public List<string> Queue { get; set; }

        }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>w-975bcfda9625****</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("workspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
