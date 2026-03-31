// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class QueryQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryQuotaResponseBodyData Data { get; set; }
        public class QueryQuotaResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The order information.</para>
            /// </summary>
            [NameInMap("billingPolicy")]
            [Validation(Required=false)]
            public QueryQuotaResponseBodyDataBillingPolicy BillingPolicy { get; set; }
            public class QueryQuotaResponseBodyDataBillingPolicy : TeaModel {
                /// <summary>
                /// <para>The billing method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>subscription: the subscription quota.</description></item>
                /// <item><description>payasyougo: the pay-as-you-go quota.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>subscription</para>
                /// </summary>
                [NameInMap("billingMethod")]
                [Validation(Required=false)]
                public string BillingMethod { get; set; }

                /// <summary>
                /// <para>In MaxCompute, instanceId and orderId are considered the same.</para>
                /// 
                /// <b>Example:</b>
                /// <para>880c0d0d-5d79-4217-b683-8e8bdd2a2523</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The order specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OdpsStandard</para>
                /// </summary>
                [NameInMap("odpsSpecCode")]
                [Validation(Required=false)]
                public string OdpsSpecCode { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>880c0d0d-5d79-4217-b683-8e8bdd2a2523</para>
                /// </summary>
                [NameInMap("orderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Managed Service for Prometheus cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AT-120N</para>
            /// </summary>
            [NameInMap("cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            /// <summary>
            /// <para>The time when the resource was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1714356241163</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that is used to create the quota plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1248953767546358</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>The group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The quota ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2523</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The quota name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>quota_a</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The quota alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>quota_nickname</para>
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>The quota description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;minCU&quot;:10,	
            /// &quot;adhocCU&quot;:0,
            /// &quot;maxCU&quot;:10,
            /// &quot;schedulerType&quot;:&quot;Fair&quot;,
            /// }</para>
            /// </summary>
            [NameInMap("parameter")]
            [Validation(Required=false)]
            public Dictionary<string, object> Parameter { get; set; }

            /// <summary>
            /// <para>The parent resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

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
            /// <para>The identifiers of MaxCompute quota objects. The identifiers are the same as those in the Alibaba Cloud sales bill. This parameter is used for tags.</para>
            /// </summary>
            [NameInMap("saleTag")]
            [Validation(Required=false)]
            public QueryQuotaResponseBodyDataSaleTag SaleTag { get; set; }
            public class QueryQuotaResponseBodyDataSaleTag : TeaModel {
                /// <summary>
                /// <para>The identifier of a MaxCompute quota object. This identifier exists in the Alibaba Cloud sales bill. You can use this identifier to associate the cost of a quota object with a tag.</para>
                /// </summary>
                [NameInMap("resourceIds")]
                [Validation(Required=false)]
                public List<string> ResourceIds { get; set; }

                /// <summary>
                /// <para>The object type. Valid values: quota and project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The information about the scheduling plan.</para>
            /// </summary>
            [NameInMap("scheduleInfo")]
            [Validation(Required=false)]
            public QueryQuotaResponseBodyDataScheduleInfo ScheduleInfo { get; set; }
            public class QueryQuotaResponseBodyDataScheduleInfo : TeaModel {
                /// <summary>
                /// <para>The current quota plan that has taken effect based on the scheduling plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planA</para>
                /// </summary>
                [NameInMap("currPlan")]
                [Validation(Required=false)]
                public string CurrPlan { get; set; }

                /// <summary>
                /// <para>The time when the plan specified by currPlan is scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0800</para>
                /// </summary>
                [NameInMap("currTime")]
                [Validation(Required=false)]
                public string CurrTime { get; set; }

                /// <summary>
                /// <para>The quota plan that will take effect based on the scheduling plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planB</para>
                /// </summary>
                [NameInMap("nextPlan")]
                [Validation(Required=false)]
                public string NextPlan { get; set; }

                /// <summary>
                /// <para>The time when the plan specified by nextPlan is scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1700</para>
                /// </summary>
                [NameInMap("nextTime")]
                [Validation(Required=false)]
                public string NextTime { get; set; }

                /// <summary>
                /// <para>The quota plan that immediately takes effect. If the quota plan specified by this parameter is triggered and the plan is different from the plan specified by currPlan, this parameter is not empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planC</para>
                /// </summary>
                [NameInMap("oncePlan")]
                [Validation(Required=false)]
                public string OncePlan { get; set; }

                /// <summary>
                /// <para>The time when the quota plan specified by oncePlan is scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1500</para>
                /// </summary>
                [NameInMap("onceTime")]
                [Validation(Required=false)]
                public string OnceTime { get; set; }

                /// <summary>
                /// <para>The operator name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userA</para>
                /// </summary>
                [NameInMap("operatorName")]
                [Validation(Required=false)]
                public string OperatorName { get; set; }

                /// <summary>
                /// <para>The time zone of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UTC+8</para>
                /// </summary>
                [NameInMap("timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

            }

            /// <summary>
            /// <para>The status of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The level-2 quotas.</para>
            /// </summary>
            [NameInMap("subQuotaInfoList")]
            [Validation(Required=false)]
            public List<QueryQuotaResponseBodyDataSubQuotaInfoList> SubQuotaInfoList { get; set; }
            public class QueryQuotaResponseBodyDataSubQuotaInfoList : TeaModel {
                /// <summary>
                /// <para>The order information.</para>
                /// </summary>
                [NameInMap("billingPolicy")]
                [Validation(Required=false)]
                public QueryQuotaResponseBodyDataSubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                public class QueryQuotaResponseBodyDataSubQuotaInfoListBillingPolicy : TeaModel {
                    /// <summary>
                    /// <para>The billing method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>subscription: the subscription quota.</description></item>
                    /// <item><description>payasyougo: the pay-as-you-go quota.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subscription</para>
                    /// </summary>
                    [NameInMap("billingMethod")]
                    [Validation(Required=false)]
                    public string BillingMethod { get; set; }

                    /// <summary>
                    /// <para>In MaxCompute, instanceId and orderId are considered the same.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>880c0d0d-5d79-4217-b683-8e8bdd2a2523</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The order specifications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OdpsStandard</para>
                    /// </summary>
                    [NameInMap("odpsSpecCode")]
                    [Validation(Required=false)]
                    public string OdpsSpecCode { get; set; }

                    /// <summary>
                    /// <para>The order ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>880c0d0d-5d79-4217-b683-8e8bdd2a2523</para>
                    /// </summary>
                    [NameInMap("orderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                }

                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AT-120N</para>
                /// </summary>
                [NameInMap("cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }

                /// <summary>
                /// <para>The time when the resource was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1688653978768</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that is used to create the quota plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>672863518</para>
                /// </summary>
                [NameInMap("creatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The role group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The ID of the level-2 quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000048</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the level-2 quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>subquotaA</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The nickname of the level-2 quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>subquotaA</para>
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>The quota description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;maxCU\&quot;: 10, \&quot;minCU\&quot;: 10, \&quot;adhocCU\&quot;: 0, \&quot;schedulerType\&quot;: \&quot;Fifo\&quot;}</para>
                /// </summary>
                [NameInMap("parameter")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameter { get; set; }

                /// <summary>
                /// <para>The parent resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("parentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

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
                /// <para>The identifiers of MaxCompute quota objects. The identifiers are the same as those in the Alibaba Cloud sales bill. This parameter is used for tags.</para>
                /// </summary>
                [NameInMap("saleTag")]
                [Validation(Required=false)]
                public QueryQuotaResponseBodyDataSubQuotaInfoListSaleTag SaleTag { get; set; }
                public class QueryQuotaResponseBodyDataSubQuotaInfoListSaleTag : TeaModel {
                    /// <summary>
                    /// <para>The identifier of a MaxCompute quota object. This identifier exists in the Alibaba Cloud sales bill. You can use this identifier to associate the cost of a quota object with a tag.</para>
                    /// </summary>
                    [NameInMap("resourceIds")]
                    [Validation(Required=false)]
                    public List<string> ResourceIds { get; set; }

                    /// <summary>
                    /// <para>The object type. Valid values: quota and project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;quota&quot;</para>
                    /// </summary>
                    [NameInMap("resourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                /// <summary>
                /// <para>The information about the scheduling plan.</para>
                /// </summary>
                [NameInMap("scheduleInfo")]
                [Validation(Required=false)]
                public QueryQuotaResponseBodyDataSubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                public class QueryQuotaResponseBodyDataSubQuotaInfoListScheduleInfo : TeaModel {
                    /// <summary>
                    /// <para>The current quota plan that has taken effect based on the scheduling plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planA</para>
                    /// </summary>
                    [NameInMap("currPlan")]
                    [Validation(Required=false)]
                    public string CurrPlan { get; set; }

                    /// <summary>
                    /// <para>The time when the plan specified by currPlan is scheduled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0800</para>
                    /// </summary>
                    [NameInMap("currTime")]
                    [Validation(Required=false)]
                    public string CurrTime { get; set; }

                    /// <summary>
                    /// <para>The quota plan that will take effect based on the scheduling plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planB</para>
                    /// </summary>
                    [NameInMap("nextPlan")]
                    [Validation(Required=false)]
                    public string NextPlan { get; set; }

                    /// <summary>
                    /// <para>The time when the plan specified by nextPlan is scheduled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1700</para>
                    /// </summary>
                    [NameInMap("nextTime")]
                    [Validation(Required=false)]
                    public string NextTime { get; set; }

                    /// <summary>
                    /// <para>The quota plan that immediately takes effect. If the quota plan specified by this parameter is triggered and the plan is different from the plan specified by currPlan, this parameter is not empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planC</para>
                    /// </summary>
                    [NameInMap("oncePlan")]
                    [Validation(Required=false)]
                    public string OncePlan { get; set; }

                    /// <summary>
                    /// <para>The time when the quota plan specified by oncePlan is scheduled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1500</para>
                    /// </summary>
                    [NameInMap("onceTime")]
                    [Validation(Required=false)]
                    public string OnceTime { get; set; }

                    /// <summary>
                    /// <para>The operator name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>userA</para>
                    /// </summary>
                    [NameInMap("operatorName")]
                    [Validation(Required=false)]
                    public string OperatorName { get; set; }

                    /// <summary>
                    /// <para>The time zone of the project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UTC+8</para>
                    /// </summary>
                    [NameInMap("timezone")]
                    [Validation(Required=false)]
                    public string Timezone { get; set; }

                }

                /// <summary>
                /// <para>The status of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The resource tag of a quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>478403690625249</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>This parameter corresponds to the resourceSystemType field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FUXI_ONLINE</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The resource tag of a quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>478403690625249</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>This parameter corresponds to the resourceSystemType field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FUXI_OFFLINE</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Exception information</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1eeed16675342848904412e08dd</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
