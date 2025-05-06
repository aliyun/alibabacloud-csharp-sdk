// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The queried workspaces.</para>
        /// </summary>
        [NameInMap("workspaces")]
        [Validation(Required=false)]
        public List<ListWorkspacesResponseBodyWorkspaces> Workspaces { get; set; }
        public class ListWorkspacesResponseBodyWorkspaces : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal. This parameter is required only if the paymentType parameter is set to Pre.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The auto-renewal duration. This parameter is required only if the paymentType parameter is set to Pre.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("autoRenewPeriod")]
            [Validation(Required=false)]
            public int? AutoRenewPeriod { get; set; }

            /// <summary>
            /// <para>The unit of the auto-renewal duration. This parameter is required only if the paymentType parameter is set to Pre.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YEAR, MONTH, WEEK, DAY, HOUR, MINUTE</para>
            /// </summary>
            [NameInMap("autoRenewPeriodUnit")]
            [Validation(Required=false)]
            public string AutoRenewPeriodUnit { get; set; }

            /// <summary>
            /// <para>The time when the workflow was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684115879955</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The information of the Data Lake Formation (DLF) catalog.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("dlfCatalogId")]
            [Validation(Required=false)]
            public string DlfCatalogId { get; set; }

            /// <summary>
            /// <para>The version of DLF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("dlfType")]
            [Validation(Required=false)]
            public string DlfType { get; set; }

            /// <summary>
            /// <para>The subscription period. This parameter is required only if the paymentType parameter is set to Pre.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The end of the end time range.</para>
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

            /// <summary>
            /// <para>The unit of the subscription duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YEAR, MONTH, WEEK, DAY, HOUR, MINUTE</para>
            /// </summary>
            [NameInMap("paymentDurationUnit")]
            [Validation(Required=false)]
            public string PaymentDurationUnit { get; set; }

            /// <summary>
            /// <para>The status of the payment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAID/UNPAID</para>
            /// </summary>
            [NameInMap("paymentStatus")]
            [Validation(Required=false)]
            public string PaymentStatus { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PayAsYouGo</description></item>
            /// <item><description>Pre</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayAsYouGo</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The information about the subscription quota.</para>
            /// </summary>
            [NameInMap("prePaidQuota")]
            [Validation(Required=false)]
            public ListWorkspacesResponseBodyWorkspacesPrePaidQuota PrePaidQuota { get; set; }
            public class ListWorkspacesResponseBodyWorkspacesPrePaidQuota : TeaModel {
                /// <summary>
                /// <para>The amount of resources that are allocated by a subscription quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;cpu\&quot;:\&quot;1\&quot;,\&quot;memory\&quot;:\&quot;4Gi\&quot;,\&quot;cu\&quot;:\&quot;1\&quot;}</para>
                /// </summary>
                [NameInMap("allocatedResource")]
                [Validation(Required=false)]
                public string AllocatedResource { get; set; }

                /// <summary>
                /// <para>Indicates whether auto-renewal is enabled for the subscription quota.</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("autoRenewal")]
                [Validation(Required=false)]
                public bool? AutoRenewal { get; set; }

                /// <summary>
                /// <para>The creation time of the subscription quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1745683200000</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The expiration time of the subscription quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1740537153000</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <para>The ID of the instance that is generated when you purchase the subscription quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-abc12345</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The maximum amount of resources that can be used in a subscription quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;cpu\&quot;:\&quot;1\&quot;,\&quot;memory\&quot;:\&quot;4Gi\&quot;,\&quot;cu\&quot;:\&quot;1\&quot;}</para>
                /// </summary>
                [NameInMap("maxResource")]
                [Validation(Required=false)]
                public string MaxResource { get; set; }

                /// <summary>
                /// <para>The status of the subscription quota. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL</description></item>
                /// <item><description>WAIT_FOR_EXPIRE</description></item>
                /// <item><description>EXPIRED</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("paymentStatus")]
                [Validation(Required=false)]
                public string PaymentStatus { get; set; }

                /// <summary>
                /// <para>The amount of resources that are used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;cpu\&quot;:\&quot;0\&quot;,\&quot;memory\&quot;:\&quot;0Gi\&quot;,\&quot;cu\&quot;:\&quot;0\&quot;}</para>
                /// </summary>
                [NameInMap("usedResource")]
                [Validation(Required=false)]
                public string UsedResource { get; set; }

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
            /// <para>The reason why the workspace is released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SERVICE_RELEASE</para>
            /// </summary>
            [NameInMap("releaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            /// <summary>
            /// <para>The resource specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100cu</para>
            /// </summary>
            [NameInMap("resourceSpec")]
            [Validation(Required=false)]
            public string ResourceSpec { get; set; }

            /// <summary>
            /// <para>The reason of the job status change.</para>
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
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>w-******</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>The name of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spark-1</para>
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
