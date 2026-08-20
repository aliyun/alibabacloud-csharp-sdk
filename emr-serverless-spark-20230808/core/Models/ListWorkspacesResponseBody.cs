// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of records to retrieve in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of workspaces.</para>
        /// </summary>
        [NameInMap("workspaces")]
        [Validation(Required=false)]
        public List<ListWorkspacesResponseBodyWorkspaces> Workspaces { get; set; }
        public class ListWorkspacesResponseBodyWorkspaces : TeaModel {
            /// <summary>
            /// <para>Indicates whether auto-renewal is enabled. This parameter is required for the prepaid type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The auto-renewal duration. This parameter is required for the prepaid type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("autoRenewPeriod")]
            [Validation(Required=false)]
            public int? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>The auto-renewal epoch unit. This parameter is required for the prepaid type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YEAR, MONTH, WEEK, DAY, HOUR, MINUTE</para>
            /// </summary>
            [NameInMap("autoRenewPeriodUnit")]
            [Validation(Required=false)]
            public string AutoRenewPeriodUnit { get; set; }

            /// <summary>
            /// <para>The time when the workspace was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684115879955</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The DLF Catalog information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("dlfCatalogId")]
            [Validation(Required=false)]
            public string DlfCatalogId { get; set; }

            /// <summary>
            /// <para>The DLF binding type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("dlfType")]
            [Validation(Required=false)]
            public string DlfType { get; set; }

            /// <summary>
            /// <para>The subscription period quantity. This parameter is required for the prepaid type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The time when the workspace was released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687103999999</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The failure reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>out of stock</para>
            /// </summary>
            [NameInMap("failReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            [NameInMap("gpuSpec")]
            [Validation(Required=false)]
            public List<string> GpuSpec { get; set; }

            [NameInMap("ipWhiteList")]
            [Validation(Required=false)]
            public List<string> IpWhiteList { get; set; }

            /// <summary>
            /// <para>The subscription period unit. This parameter is required for the prepaid type.</para>
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
            /// <para>The payment type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PayAsYouGo or Subscription</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The prepaid resource quota information.</para>
            /// </summary>
            [NameInMap("prePaidQuota")]
            [Validation(Required=false)]
            public ListWorkspacesResponseBodyWorkspacesPrePaidQuota PrePaidQuota { get; set; }
            public class ListWorkspacesResponseBodyWorkspacesPrePaidQuota : TeaModel {
                /// <summary>
                /// <para>The amount of resources currently allocated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;cpu\&quot;:\&quot;1\&quot;,\&quot;memory\&quot;:\&quot;4Gi\&quot;,\&quot;cu\&quot;:\&quot;1\&quot;}</para>
                /// </summary>
                [NameInMap("allocatedResource")]
                [Validation(Required=false)]
                public string AllocatedResource { get; set; }

                /// <summary>
                /// <para>Indicates whether auto-renewal is enabled for the resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Auto-renewal is enabled. The resource is automatically renewed upon expiration.</description></item>
                /// <item><description>false: Auto-renewal is not enabled. The resource stops being available upon expiration.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("autoRenewal")]
                [Validation(Required=false)]
                public bool? AutoRenewal { get; set; }

                /// <summary>
                /// <para>The time when the resource quota was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1745683200000</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the resource quota expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1740537153000</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <para>The instance ID of the resource associated with the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-abc12345</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The maximum amount of resources available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;cpu\&quot;:\&quot;1\&quot;,\&quot;memory\&quot;:\&quot;4Gi\&quot;,\&quot;cu\&quot;:\&quot;1\&quot;}</para>
                /// </summary>
                [NameInMap("maxResource")]
                [Validation(Required=false)]
                public string MaxResource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23464687565</para>
                /// </summary>
                [NameInMap("orderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The payment status of the current resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: Active.</description></item>
                /// <item><description>WAIT_FOR_EXPIRE: About to expire.</description></item>
                /// <item><description>EXPIRED: Expired.</description></item>
                /// </list>
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
                /// <para>{\&quot;cpu\&quot;:\&quot;0\&quot;,\&quot;memory\&quot;:\&quot;0Gi\&quot;,\&quot;cu\&quot;:\&quot;0\&quot;}</para>
                /// </summary>
                [NameInMap("usedResource")]
                [Validation(Required=false)]
                public string UsedResource { get; set; }

            }

            [NameInMap("prePaidQuotaGpu")]
            [Validation(Required=false)]
            public List<ListWorkspacesResponseBodyWorkspacesPrePaidQuotaGpu> PrePaidQuotaGpu { get; set; }
            public class ListWorkspacesResponseBodyWorkspacesPrePaidQuotaGpu : TeaModel {
                [NameInMap("autoRenewal")]
                [Validation(Required=false)]
                public bool? AutoRenewal { get; set; }

                [NameInMap("cpuCoreCount")]
                [Validation(Required=false)]
                public string CpuCoreCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1782292672000</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1782292772000</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                [NameInMap("gpuAmount")]
                [Validation(Required=false)]
                public int? GpuAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("gpuMachineNum")]
                [Validation(Required=false)]
                public int? GpuMachineNum { get; set; }

                [NameInMap("gpuMemorySize")]
                [Validation(Required=false)]
                public long? GpuMemorySize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("gpuNum")]
                [Validation(Required=false)]
                public int? GpuNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ecs.gn7i-c8g1.2xlarge</para>
                /// </summary>
                [NameInMap("gpuSpec")]
                [Validation(Required=false)]
                public string GpuSpec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>w-xxxxxxxxx-gpu-quota-xxxx</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("instanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                [NameInMap("instanceTypeId")]
                [Validation(Required=false)]
                public string InstanceTypeId { get; set; }

                [NameInMap("memorySize")]
                [Validation(Required=false)]
                public string MemorySize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2534863936</para>
                /// </summary>
                [NameInMap("orderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("paymentStatus")]
                [Validation(Required=false)]
                public string PaymentStatus { get; set; }

            }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The reason why the workspace was released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SERVICE_RELEASE</para>
            /// </summary>
            [NameInMap("releaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The resource specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100cu</para>
            /// </summary>
            [NameInMap("resourceSpec")]
            [Validation(Required=false)]
            public string ResourceSpec { get; set; }

            /// <summary>
            /// <para>The state change information of the workspace.</para>
            /// </summary>
            [NameInMap("stateChangeReason")]
            [Validation(Required=false)]
            public ListWorkspacesResponseBodyWorkspacesStateChangeReason StateChangeReason { get; set; }
            public class ListWorkspacesResponseBodyWorkspacesStateChangeReason : TeaModel {
                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
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

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListWorkspacesResponseBodyWorkspacesTags> Tags { get; set; }
            public class ListWorkspacesResponseBodyWorkspacesTags : TeaModel {
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>Workspace ID。</para>
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
            /// <para>Spark batch workspace-1</para>
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
