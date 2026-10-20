// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The workspace object.</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public GetWorkspaceResponseBodyWorkspace Workspace { get; set; }
        public class GetWorkspaceResponseBodyWorkspace : TeaModel {
            /// <summary>
            /// <para>Specifies whether auto-renewal is enabled. This parameter is required for subscription workspaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The auto-renewal period. This parameter is required for subscription workspaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("autoRenewPeriod")]
            [Validation(Required=false)]
            public int? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>The auto-renewal cycle. This parameter is required for subscription workspaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YEAR, MONTH, WEEK, DAY, HOUR, MINUTE</para>
            /// </summary>
            [NameInMap("autoRenewPeriodUnit")]
            [Validation(Required=false)]
            public string AutoRenewPeriodUnit { get; set; }

            /// <summary>
            /// <para>The time when the workspace was created. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1776824869000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The DLF catalog information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("dlfCatalogId")]
            [Validation(Required=false)]
            public string DlfCatalogId { get; set; }

            /// <summary>
            /// <para>The bound DLF type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DLF-NEXT</para>
            /// </summary>
            [NameInMap("dlfType")]
            [Validation(Required=false)]
            public string DlfType { get; set; }

            /// <summary>
            /// <para>The subscription duration. This parameter is required for subscription workspaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The time when the workspace is released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1786586477000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The reason for the failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>out of stock</para>
            /// </summary>
            [NameInMap("failReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            /// <summary>
            /// <para>The list of GPU instance types.</para>
            /// </summary>
            [NameInMap("gpuSpec")]
            [Validation(Required=false)]
            public List<string> GpuSpec { get; set; }

            /// <summary>
            /// <para>The IP whitelist of the workspace.</para>
            /// </summary>
            [NameInMap("ipWhiteList")]
            [Validation(Required=false)]
            public List<string> IpWhiteList { get; set; }

            /// <summary>
            /// <para>The unit of the subscription period. This parameter is required for subscription workspaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YEAR, MONTH, WEEK, DAY, HOUR, MINUTE</para>
            /// </summary>
            [NameInMap("paymentDurationUnit")]
            [Validation(Required=false)]
            public string PaymentDurationUnit { get; set; }

            /// <summary>
            /// <para>The payment status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAID/UNPAID</para>
            /// </summary>
            [NameInMap("paymentStatus")]
            [Validation(Required=false)]
            public string PaymentStatus { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PayAsYouGo or Subscription</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The information about the subscription resource quota.</para>
            /// </summary>
            [NameInMap("prePaidQuota")]
            [Validation(Required=false)]
            public GetWorkspaceResponseBodyWorkspacePrePaidQuota PrePaidQuota { get; set; }
            public class GetWorkspaceResponseBodyWorkspacePrePaidQuota : TeaModel {
                /// <summary>
                /// <para>The amount of resources currently allocated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cu&quot;: 100}</para>
                /// </summary>
                [NameInMap("allocatedResource")]
                [Validation(Required=false)]
                public string AllocatedResource { get; set; }

                /// <summary>
                /// <para>Specifies whether auto-renewal is enabled for the resource.</para>
                /// <list type="bullet">
                /// <item><description>true: Auto-renewal is enabled. The resource is automatically renewed upon expiration.</description></item>
                /// <item><description>false: Auto-renewal is disabled. The resource is stopped upon expiration.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("autoRenewal")]
                [Validation(Required=false)]
                public bool? AutoRenewal { get; set; }

                /// <summary>
                /// <para>The time when the workspace was created. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1791802817000</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The expiration time of the GPU subscription quota. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1779768979586</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ray-df0tghlhat1776wy-klbifz8l</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The maximum amount of resources that can be used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cu&quot;: 100}</para>
                /// </summary>
                [NameInMap("maxResource")]
                [Validation(Required=false)]
                public string MaxResource { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>298581757170384</para>
                /// </summary>
                [NameInMap("orderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The order status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("paymentStatus")]
                [Validation(Required=false)]
                public string PaymentStatus { get; set; }

                /// <summary>
                /// <para>The amount of resources currently used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cu&quot;: 50}</para>
                /// </summary>
                [NameInMap("usedResource")]
                [Validation(Required=false)]
                public string UsedResource { get; set; }

            }

            /// <summary>
            /// <para>The list of GPU subscription quotas.</para>
            /// </summary>
            [NameInMap("prePaidQuotaGpu")]
            [Validation(Required=false)]
            public List<GetWorkspaceResponseBodyWorkspacePrePaidQuotaGpu> PrePaidQuotaGpu { get; set; }
            public class GetWorkspaceResponseBodyWorkspacePrePaidQuotaGpu : TeaModel {
                /// <summary>
                /// <para>Specifies whether auto-renewal is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("autoRenewal")]
                [Validation(Required=false)]
                public bool? AutoRenewal { get; set; }

                /// <summary>
                /// <para>The number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("cpuCoreCount")]
                [Validation(Required=false)]
                public string CpuCoreCount { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1782292672000</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The expiration time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1782292772000</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <para>The number of GPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("gpuAmount")]
                [Validation(Required=false)]
                public int? GpuAmount { get; set; }

                /// <summary>
                /// <para>The number of GPU instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("gpuMachineNum")]
                [Validation(Required=false)]
                public int? GpuMachineNum { get; set; }

                /// <summary>
                /// <para>The GPU memory size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4096</para>
                /// </summary>
                [NameInMap("gpuMemorySize")]
                [Validation(Required=false)]
                public long? GpuMemorySize { get; set; }

                /// <summary>
                /// <para>The number of GPU instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("gpuNum")]
                [Validation(Required=false)]
                public int? GpuNum { get; set; }

                /// <summary>
                /// <para>The GPU instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.gn7i-c8g1.2xlarge</para>
                /// </summary>
                [NameInMap("gpuSpec")]
                [Validation(Required=false)]
                public string GpuSpec { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>w-xxxxxx-quota-gpu-xxxx</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance family.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g5</para>
                /// </summary>
                [NameInMap("instanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// <para>The instance type ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g5.small</para>
                /// </summary>
                [NameInMap("instanceTypeId")]
                [Validation(Required=false)]
                public string InstanceTypeId { get; set; }

                /// <summary>
                /// <para>The memory size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4096</para>
                /// </summary>
                [NameInMap("memorySize")]
                [Validation(Required=false)]
                public string MemorySize { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2345634254</para>
                /// </summary>
                [NameInMap("orderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The order status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("paymentStatus")]
                [Validation(Required=false)]
                public string PaymentStatus { get; set; }

            }

            /// <summary>
            /// <para>The name of the RAM role used to execute Spark jobs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun</para>
            /// </summary>
            [NameInMap("ramRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The reason why the workspace is released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stable</para>
            /// </summary>
            [NameInMap("releaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek4f7uj74wdthi</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The UID of the user who created the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13*************</para>
            /// </summary>
            [NameInMap("resourceOwnerId")]
            [Validation(Required=false)]
            public string ResourceOwnerId { get; set; }

            /// <summary>
            /// <para>The resource specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cu&quot;: 100}</para>
            /// </summary>
            [NameInMap("resourceSpec")]
            [Validation(Required=false)]
            public string ResourceSpec { get; set; }

            /// <summary>
            /// <para>The information about the workspace status change.</para>
            /// </summary>
            [NameInMap("stateChangeReason")]
            [Validation(Required=false)]
            public GetWorkspaceResponseBodyWorkspaceStateChangeReason StateChangeReason { get; set; }
            public class GetWorkspaceResponseBodyWorkspaceStateChangeReason : TeaModel {
                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The status information of the node pod.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The OSS path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spark-result</para>
            /// </summary>
            [NameInMap("storage")]
            [Validation(Required=false)]
            public string Storage { get; set; }

            /// <summary>
            /// <para>The tag keys.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetWorkspaceResponseBodyWorkspaceTags> Tags { get; set; }
            public class GetWorkspaceResponseBodyWorkspaceTags : TeaModel {
                /// <summary>
                /// <para>The tag keys.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[\&quot;COST\&quot;]</para>
                /// </summary>
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3d775731-9ec1-4fe2-a00d-061d51fce677</para>
                /// </summary>
                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>w-******</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>The workspace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Spark batch job workspace-1</para>
            /// </summary>
            [NameInMap("workspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

            /// <summary>
            /// <para>The workspace status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STARTING,RUNNING,TERMINATED</para>
            /// </summary>
            [NameInMap("workspaceStatus")]
            [Validation(Required=false)]
            public string WorkspaceStatus { get; set; }

        }

    }

}
