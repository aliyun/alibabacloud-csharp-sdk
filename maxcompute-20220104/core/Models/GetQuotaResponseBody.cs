// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The order information.</para>
        /// </summary>
        [NameInMap("billingPolicy")]
        [Validation(Required=false)]
        public GetQuotaResponseBodyBillingPolicy BillingPolicy { get; set; }
        public class GetQuotaResponseBodyBillingPolicy : TeaModel {
            /// <summary>
            /// <para>The billing method.</para>
            /// <list type="bullet">
            /// <item><description><para>subscription: indicates a subscription quota.</para>
            /// </description></item>
            /// <item><description><para>payasyougo: indicates a pay-as-you-go quota.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>subscription</para>
            /// </summary>
            [NameInMap("billingMethod")]
            [Validation(Required=false)]
            public string BillingMethod { get; set; }

            /// <summary>
            /// <para>The specifications of the order.</para>
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
            /// <para>45245678</para>
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
        /// <para>2022-09-06T02:14:44Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The creator of the resource. This parameter is the UID of an Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>672863518</para>
        /// </summary>
        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetQuotaResponseBodyData Data { get; set; }
        public class GetQuotaResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The order information.</para>
            /// </summary>
            [NameInMap("billingPolicy")]
            [Validation(Required=false)]
            public GetQuotaResponseBodyDataBillingPolicy BillingPolicy { get; set; }
            public class GetQuotaResponseBodyDataBillingPolicy : TeaModel {
                /// <summary>
                /// <para>The billing method.</para>
                /// <list type="bullet">
                /// <item><description><para>subscription: indicates a subscription quota.</para>
                /// </description></item>
                /// <item><description><para>payasyougo: indicates a pay-as-you-go quota.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>subscription</para>
                /// </summary>
                [NameInMap("billingMethod")]
                [Validation(Required=false)]
                public string BillingMethod { get; set; }

                /// <summary>
                /// <para>The specifications of the order.</para>
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
                /// <para>45245678</para>
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
            /// <para>2022-09-06T02:14:44Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The creator of the resource. This parameter is the UID of an Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>672863518</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>The quota ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
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
            /// <para>The alias of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>quota_nickname</para>
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>The description of the quota.</para>
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
            /// <para>The ID of the parent resource.</para>
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
            /// <para>The identifier of the MaxCompute quota object. This identifier is the same as the identifier in the bill of Alibaba Cloud. This parameter is used in tagging scenarios.</para>
            /// </summary>
            [NameInMap("saleTag")]
            [Validation(Required=false)]
            public GetQuotaResponseBodyDataSaleTag SaleTag { get; set; }
            public class GetQuotaResponseBodyDataSaleTag : TeaModel {
                /// <summary>
                /// <para>The identifier of the MaxCompute quota object. This identifier also exists in the billing subsystem of Alibaba Cloud. You can use this identifier to associate the costs of a quota object with a tag.</para>
                /// </summary>
                [NameInMap("resourceIds")]
                [Validation(Required=false)]
                public List<string> ResourceIds { get; set; }

                /// <summary>
                /// <para>The type of the object. Currently, only quota and project are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;quota&quot;</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The time-sharing information.</para>
            /// </summary>
            [NameInMap("scheduleInfo")]
            [Validation(Required=false)]
            public GetQuotaResponseBodyDataScheduleInfo ScheduleInfo { get; set; }
            public class GetQuotaResponseBodyDataScheduleInfo : TeaModel {
                /// <summary>
                /// <para>The quota plan that is in effect based on the scheduling plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planA</para>
                /// </summary>
                [NameInMap("currPlan")]
                [Validation(Required=false)]
                public string CurrPlan { get; set; }

                /// <summary>
                /// <para>The time when the currPlan was scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0800</para>
                /// </summary>
                [NameInMap("currTime")]
                [Validation(Required=false)]
                public string CurrTime { get; set; }

                /// <summary>
                /// <para>The quota plan that is about to take effect based on the scheduling plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planB</para>
                /// </summary>
                [NameInMap("nextPlan")]
                [Validation(Required=false)]
                public string NextPlan { get; set; }

                /// <summary>
                /// <para>The time when the next_plan is scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1700</para>
                /// </summary>
                [NameInMap("nextTime")]
                [Validation(Required=false)]
                public string NextTime { get; set; }

                /// <summary>
                /// <para>The quota plan that takes effect immediately.
                /// This parameter is not empty if a user triggers a plan that is different from the curr_plan to take effect immediately.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planC</para>
                /// </summary>
                [NameInMap("oncePlan")]
                [Validation(Required=false)]
                public string OncePlan { get; set; }

                /// <summary>
                /// <para>The time when the immediate-effect plan was triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1500</para>
                /// </summary>
                [NameInMap("onceTime")]
                [Validation(Required=false)]
                public string OnceTime { get; set; }

                /// <summary>
                /// <para>The name of the operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userA</para>
                /// </summary>
                [NameInMap("operatorName")]
                [Validation(Required=false)]
                public string OperatorName { get; set; }

                /// <summary>
                /// <para>The time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UTC+8</para>
                /// </summary>
                [NameInMap("timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

            }

            /// <summary>
            /// <para>The resource status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The information about the level-2 quotas.</para>
            /// </summary>
            [NameInMap("subQuotaInfoList")]
            [Validation(Required=false)]
            public List<GetQuotaResponseBodyDataSubQuotaInfoList> SubQuotaInfoList { get; set; }
            public class GetQuotaResponseBodyDataSubQuotaInfoList : TeaModel {
                /// <summary>
                /// <para>The order information.</para>
                /// </summary>
                [NameInMap("billingPolicy")]
                [Validation(Required=false)]
                public GetQuotaResponseBodyDataSubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                public class GetQuotaResponseBodyDataSubQuotaInfoListBillingPolicy : TeaModel {
                    /// <summary>
                    /// <para>The billing method.</para>
                    /// <list type="bullet">
                    /// <item><description><para>subscription: indicates a subscription quota.</para>
                    /// </description></item>
                    /// <item><description><para>payasyougo: indicates a pay-as-you-go quota.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subscription</para>
                    /// </summary>
                    [NameInMap("billingMethod")]
                    [Validation(Required=false)]
                    public string BillingMethod { get; set; }

                    /// <summary>
                    /// <para>The specifications of the order.</para>
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
                    /// <para>45245678</para>
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
                /// <para>2022-09-06T02:14:44Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The creator of the resource. This parameter is the UID of an Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>672863518</para>
                /// </summary>
                [NameInMap("creatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The level-2 quota ID.</para>
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
                /// <para>The description of the quota.</para>
                /// </summary>
                [NameInMap("parameter")]
                [Validation(Required=false)]
                public GetQuotaResponseBodyDataSubQuotaInfoListParameter Parameter { get; set; }
                public class GetQuotaResponseBodyDataSubQuotaInfoListParameter : TeaModel {
                    /// <summary>
                    /// <para>The value of elastic reserved CUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("elasticReservedCU")]
                    [Validation(Required=false)]
                    public long? ElasticReservedCU { get; set; }

                    /// <summary>
                    /// <para>Enables the priority feature.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enablePriority")]
                    [Validation(Required=false)]
                    public bool? EnablePriority { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable exclusive use.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("forceReservedMin")]
                    [Validation(Required=false)]
                    public bool? ForceReservedMin { get; set; }

                    /// <summary>
                    /// <para>The upper limit of reserved computing units (CUs).</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("maxCU")]
                    [Validation(Required=false)]
                    public long? MaxCU { get; set; }

                    /// <summary>
                    /// <para>The guaranteed reserved CUs.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("minCU")]
                    [Validation(Required=false)]
                    public long? MinCU { get; set; }

                    /// <summary>
                    /// <para>The scheduling policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Fifo/Fair</para>
                    /// </summary>
                    [NameInMap("schedulerType")]
                    [Validation(Required=false)]
                    public string SchedulerType { get; set; }

                    /// <summary>
                    /// <para>The upper limit of CUs for a single job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("singleJobCULimit")]
                    [Validation(Required=false)]
                    public long? SingleJobCULimit { get; set; }

                }

                /// <summary>
                /// <para>The ID of the parent resource.</para>
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
                /// <para>The identifier of the MaxCompute quota object. This identifier is the same as the identifier in the bill of Alibaba Cloud. This parameter is used in tagging scenarios.</para>
                /// </summary>
                [NameInMap("saleTag")]
                [Validation(Required=false)]
                public GetQuotaResponseBodyDataSubQuotaInfoListSaleTag SaleTag { get; set; }
                public class GetQuotaResponseBodyDataSubQuotaInfoListSaleTag : TeaModel {
                    /// <summary>
                    /// <para>The identifier of the MaxCompute quota object. This identifier also exists in the billing subsystem of Alibaba Cloud. You can use this identifier to associate the costs of a quota object with a tag.</para>
                    /// </summary>
                    [NameInMap("resourceIds")]
                    [Validation(Required=false)]
                    public List<string> ResourceIds { get; set; }

                    /// <summary>
                    /// <para>The type of the object. Currently, only quota and project are supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;quota&quot;</para>
                    /// </summary>
                    [NameInMap("resourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                /// <summary>
                /// <para>The time-sharing information.</para>
                /// </summary>
                [NameInMap("scheduleInfo")]
                [Validation(Required=false)]
                public GetQuotaResponseBodyDataSubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                public class GetQuotaResponseBodyDataSubQuotaInfoListScheduleInfo : TeaModel {
                    /// <summary>
                    /// <para>The quota plan that is in effect based on the scheduling plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planA</para>
                    /// </summary>
                    [NameInMap("currPlan")]
                    [Validation(Required=false)]
                    public string CurrPlan { get; set; }

                    /// <summary>
                    /// <para>The time when the currPlan was scheduled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0800</para>
                    /// </summary>
                    [NameInMap("currTime")]
                    [Validation(Required=false)]
                    public string CurrTime { get; set; }

                    /// <summary>
                    /// <para>The quota plan that is about to take effect based on the scheduling plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planB</para>
                    /// </summary>
                    [NameInMap("nextPlan")]
                    [Validation(Required=false)]
                    public string NextPlan { get; set; }

                    /// <summary>
                    /// <para>The time when the next_plan is scheduled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1700</para>
                    /// </summary>
                    [NameInMap("nextTime")]
                    [Validation(Required=false)]
                    public string NextTime { get; set; }

                    /// <summary>
                    /// <para>The quota plan that takes effect immediately.
                    /// This parameter is not empty if a user triggers a plan that is different from the curr_plan to take effect immediately.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planC</para>
                    /// </summary>
                    [NameInMap("oncePlan")]
                    [Validation(Required=false)]
                    public string OncePlan { get; set; }

                    /// <summary>
                    /// <para>The time when the immediate-effect plan was triggered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1500</para>
                    /// </summary>
                    [NameInMap("onceTime")]
                    [Validation(Required=false)]
                    public string OnceTime { get; set; }

                    /// <summary>
                    /// <para>The name of the operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>userA</para>
                    /// </summary>
                    [NameInMap("operatorName")]
                    [Validation(Required=false)]
                    public string OperatorName { get; set; }

                    /// <summary>
                    /// <para>The time zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UTC+8</para>
                    /// </summary>
                    [NameInMap("timezone")]
                    [Validation(Required=false)]
                    public string Timezone { get; set; }

                }

                /// <summary>
                /// <para>The resource status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The resource tag of the quota.</para>
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
                /// <para>This parameter corresponds to the resourceSystemType field of the control cluster.</para>
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
            /// <para>The resource tag of the quota.</para>
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
            /// <para>This parameter corresponds to the resourceSystemType field of the control cluster.</para>
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
        /// <para>The quota ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
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
        /// <para>The alias of the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota_nickname</para>
        /// </summary>
        [NameInMap("nickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// <para>The description of the quota.</para>
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
        /// <para>The ID of the parent resource.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b87b7a316654730544735643e9200</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The identifier of the MaxCompute quota object. This identifier is the same as the identifier in the bill of Alibaba Cloud. This parameter is used in tagging scenarios.</para>
        /// </summary>
        [NameInMap("saleTag")]
        [Validation(Required=false)]
        public GetQuotaResponseBodySaleTag SaleTag { get; set; }
        public class GetQuotaResponseBodySaleTag : TeaModel {
            /// <summary>
            /// <para>The identifier of the MaxCompute quota object. This identifier also exists in the billing subsystem of Alibaba Cloud. You can use this identifier to associate the costs of a quota object with a tag.</para>
            /// </summary>
            [NameInMap("resourceIds")]
            [Validation(Required=false)]
            public List<string> ResourceIds { get; set; }

            /// <summary>
            /// <para>The type of the object. Currently, only quota and project are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;quota&quot;</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The time-sharing information.</para>
        /// </summary>
        [NameInMap("scheduleInfo")]
        [Validation(Required=false)]
        public GetQuotaResponseBodyScheduleInfo ScheduleInfo { get; set; }
        public class GetQuotaResponseBodyScheduleInfo : TeaModel {
            /// <summary>
            /// <para>The quota plan that is in effect based on the scheduling plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>planA</para>
            /// </summary>
            [NameInMap("currPlan")]
            [Validation(Required=false)]
            public string CurrPlan { get; set; }

            /// <summary>
            /// <para>The time when the currPlan was scheduled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0800</para>
            /// </summary>
            [NameInMap("currTime")]
            [Validation(Required=false)]
            public string CurrTime { get; set; }

            /// <summary>
            /// <para>The quota plan that is about to take effect based on the scheduling plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>planB</para>
            /// </summary>
            [NameInMap("nextPlan")]
            [Validation(Required=false)]
            public string NextPlan { get; set; }

            /// <summary>
            /// <para>The time when the next_plan is scheduled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700</para>
            /// </summary>
            [NameInMap("nextTime")]
            [Validation(Required=false)]
            public string NextTime { get; set; }

            /// <summary>
            /// <para>The quota plan that takes effect immediately.
            /// This parameter is not empty if a user triggers a plan that is different from the curr_plan to take effect immediately.</para>
            /// 
            /// <b>Example:</b>
            /// <para>planC</para>
            /// </summary>
            [NameInMap("oncePlan")]
            [Validation(Required=false)]
            public string OncePlan { get; set; }

            /// <summary>
            /// <para>The time when the immediate-effect plan was triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1500</para>
            /// </summary>
            [NameInMap("onceTime")]
            [Validation(Required=false)]
            public string OnceTime { get; set; }

            /// <summary>
            /// <para>The name of the operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>userA</para>
            /// </summary>
            [NameInMap("operatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// <para>The time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UTC+8</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

        }

        /// <summary>
        /// <para>The resource status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The information about the level-2 quotas.</para>
        /// </summary>
        [NameInMap("subQuotaInfoList")]
        [Validation(Required=false)]
        public List<GetQuotaResponseBodySubQuotaInfoList> SubQuotaInfoList { get; set; }
        public class GetQuotaResponseBodySubQuotaInfoList : TeaModel {
            /// <summary>
            /// <para>The order information.</para>
            /// </summary>
            [NameInMap("billingPolicy")]
            [Validation(Required=false)]
            public GetQuotaResponseBodySubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
            public class GetQuotaResponseBodySubQuotaInfoListBillingPolicy : TeaModel {
                /// <summary>
                /// <para>The billing method.</para>
                /// <list type="bullet">
                /// <item><description><para>subscription: indicates a subscription quota.</para>
                /// </description></item>
                /// <item><description><para>payasyougo: indicates a pay-as-you-go quota.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>subscription</para>
                /// </summary>
                [NameInMap("billingMethod")]
                [Validation(Required=false)]
                public string BillingMethod { get; set; }

                /// <summary>
                /// <para>The specifications of the order.</para>
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
                /// <para>45245678</para>
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
            /// <para>2022-09-06T02:14:44Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The creator of the resource. This parameter is the UID of an Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>672863518</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>The level-2 quota ID.</para>
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
            /// <para>The alias of the level-2 quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>subquotaA</para>
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>The description of the quota.</para>
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
            public GetQuotaResponseBodySubQuotaInfoListParameter Parameter { get; set; }
            public class GetQuotaResponseBodySubQuotaInfoListParameter : TeaModel {
                /// <summary>
                /// <para>The value of elastic reserved CUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("elasticReservedCU")]
                [Validation(Required=false)]
                public long? ElasticReservedCU { get; set; }

                /// <summary>
                /// <para>Enables the priority feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enablePriority")]
                [Validation(Required=false)]
                public bool? EnablePriority { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable exclusive use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("forceReservedMin")]
                [Validation(Required=false)]
                public bool? ForceReservedMin { get; set; }

                /// <summary>
                /// <para>The upper limit of reserved computing units (CUs).</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("maxCU")]
                [Validation(Required=false)]
                public long? MaxCU { get; set; }

                /// <summary>
                /// <para>The guaranteed reserved CUs.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("minCU")]
                [Validation(Required=false)]
                public long? MinCU { get; set; }

                /// <summary>
                /// <para>The scheduling policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Fifo/Fair</para>
                /// </summary>
                [NameInMap("schedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                /// <summary>
                /// <para>The upper limit of CUs for a single job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("singleJobCULimit")]
                [Validation(Required=false)]
                public long? SingleJobCULimit { get; set; }

            }

            /// <summary>
            /// <para>The ID of the parent resource.</para>
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
            /// <para>The identifier of the MaxCompute quota object. This identifier is the same as the identifier in the bill of Alibaba Cloud. This parameter is used in tagging scenarios.</para>
            /// </summary>
            [NameInMap("saleTag")]
            [Validation(Required=false)]
            public GetQuotaResponseBodySubQuotaInfoListSaleTag SaleTag { get; set; }
            public class GetQuotaResponseBodySubQuotaInfoListSaleTag : TeaModel {
                /// <summary>
                /// <para>The identifier of the MaxCompute quota object. This identifier also exists in the billing subsystem of Alibaba Cloud. You can use this identifier to associate the costs of a quota object with a tag.</para>
                /// </summary>
                [NameInMap("resourceIds")]
                [Validation(Required=false)]
                public List<string> ResourceIds { get; set; }

                /// <summary>
                /// <para>The type of the object. Currently, only quota and project are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;quota&quot;</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The time-sharing information.</para>
            /// </summary>
            [NameInMap("scheduleInfo")]
            [Validation(Required=false)]
            public GetQuotaResponseBodySubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
            public class GetQuotaResponseBodySubQuotaInfoListScheduleInfo : TeaModel {
                /// <summary>
                /// <para>The quota plan that is in effect based on the scheduling plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planA</para>
                /// </summary>
                [NameInMap("currPlan")]
                [Validation(Required=false)]
                public string CurrPlan { get; set; }

                /// <summary>
                /// <para>The time when the currPlan was scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0800</para>
                /// </summary>
                [NameInMap("currTime")]
                [Validation(Required=false)]
                public string CurrTime { get; set; }

                /// <summary>
                /// <para>The quota plan that is about to take effect based on the scheduling plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planB</para>
                /// </summary>
                [NameInMap("nextPlan")]
                [Validation(Required=false)]
                public string NextPlan { get; set; }

                /// <summary>
                /// <para>The time when the next_plan is scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1700</para>
                /// </summary>
                [NameInMap("nextTime")]
                [Validation(Required=false)]
                public string NextTime { get; set; }

                /// <summary>
                /// <para>The quota plan that takes effect immediately.
                /// This parameter is not empty if a user triggers a plan that is different from the curr_plan to take effect immediately.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planC</para>
                /// </summary>
                [NameInMap("oncePlan")]
                [Validation(Required=false)]
                public string OncePlan { get; set; }

                /// <summary>
                /// <para>The time when the immediate-effect plan was triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1500</para>
                /// </summary>
                [NameInMap("onceTime")]
                [Validation(Required=false)]
                public string OnceTime { get; set; }

                /// <summary>
                /// <para>The name of the operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userA</para>
                /// </summary>
                [NameInMap("operatorName")]
                [Validation(Required=false)]
                public string OperatorName { get; set; }

                /// <summary>
                /// <para>The time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UTC+8</para>
                /// </summary>
                [NameInMap("timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

            }

            /// <summary>
            /// <para>The resource status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The resource tag of the quota.</para>
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
            /// <para>This parameter corresponds to the resourceSystemType field of the control cluster.</para>
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
        /// <para>The resource tag of the quota.</para>
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
        /// <para>This parameter corresponds to the resourceSystemType field of the control cluster.</para>
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

}
