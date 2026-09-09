// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListQuotasResponseBody : TeaModel {
        /// <summary>
        /// <para>The token for the next page of results. This operation supports only consecutive paging. If the returned value is not empty, more data is available. To get the next page, use the returned value in your next request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2w6Olxc+cMPjUtUMo/CvPe4IK7f7kIQFrIZjyc</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListQuotasResponseBodyData Data { get; set; }
        public class ListQuotasResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The token for the next page of results. If this parameter has a value, more results are available. To get the next page, include this value in the \<c>NextToken\\</c> parameter of the next request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;abcde&quot;</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The results are returned in alphabetical order, starting from the entry after the marker.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cHlvZHBzX3VkZl8xMDExNV8xNDU3NDI4NDkzKg==</para>
            /// </summary>
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            /// <summary>
            /// <para>The maximum number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("maxItem")]
            [Validation(Required=false)]
            public long? MaxItem { get; set; }

            /// <summary>
            /// <para>The list of quotas.</para>
            /// </summary>
            [NameInMap("quotaInfoList")]
            [Validation(Required=false)]
            public List<ListQuotasResponseBodyDataQuotaInfoList> QuotaInfoList { get; set; }
            public class ListQuotasResponseBodyDataQuotaInfoList : TeaModel {
                /// <summary>
                /// <para>The tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListQuotasResponseBodyDataQuotaInfoListTags> Tags { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Department</para>
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a12351qHDP6YEQMt</para>
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                /// <summary>
                /// <para>The billing information.</para>
                /// </summary>
                [NameInMap("billingPolicy")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyDataQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListBillingPolicy : TeaModel {
                    /// <summary>
                    /// <para>The billing method.</para>
                    /// <list type="bullet">
                    /// <item><description><para>subscription: The subscription billing method.</para>
                    /// </description></item>
                    /// <item><description><para>payasyougo: The pay-as-you-go billing method.</para>
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
                    /// <para>The ID of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>45245678</para>
                    /// </summary>
                    [NameInMap("orderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AT-120N</para>
                /// </summary>
                [NameInMap("cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }

                /// <summary>
                /// <para>The time when the quota was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-06T02:14:44Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the account that created the quota. This ID is an Alibaba Cloud account UID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>672863518</para>
                /// </summary>
                [NameInMap("creatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The ID of the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the quota.</para>
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
                /// <para>The ID of the parent resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("parentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The sales tag of the quota. This tag is the same as the billing identifier and is used for cost allocation.</para>
                /// </summary>
                [NameInMap("saleTag")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyDataQuotaInfoListSaleTag SaleTag { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListSaleTag : TeaModel {
                    /// <summary>
                    /// <para>The IDs of the resources. This ID is also used in the billing system. You can use this ID to associate the costs of a quota with a tag.</para>
                    /// </summary>
                    [NameInMap("resourceIds")]
                    [Validation(Required=false)]
                    public List<string> ResourceIds { get; set; }

                    /// <summary>
                    /// <para>The type of the resource. Valid values: quota and project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;quota&quot;</para>
                    /// </summary>
                    [NameInMap("resourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                /// <summary>
                /// <para>The time-based scheduling information.</para>
                /// </summary>
                [NameInMap("scheduleInfo")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyDataQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListScheduleInfo : TeaModel {
                    /// <summary>
                    /// <para>The quota plan that is currently in effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planA</para>
                    /// </summary>
                    [NameInMap("currPlan")]
                    [Validation(Required=false)]
                    public string CurrPlan { get; set; }

                    /// <summary>
                    /// <para>The time when the current plan took effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0800</para>
                    /// </summary>
                    [NameInMap("currTime")]
                    [Validation(Required=false)]
                    public string CurrTime { get; set; }

                    /// <summary>
                    /// <para>The next quota plan that is scheduled to take effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planB</para>
                    /// </summary>
                    [NameInMap("nextPlan")]
                    [Validation(Required=false)]
                    public string NextPlan { get; set; }

                    /// <summary>
                    /// <para>The time when the next plan is scheduled to take effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1700</para>
                    /// </summary>
                    [NameInMap("nextTime")]
                    [Validation(Required=false)]
                    public string NextTime { get; set; }

                    /// <summary>
                    /// <para>The quota plan that takes effect immediately. This parameter is returned only when a user triggers an immediate plan that is different from the current plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planC</para>
                    /// </summary>
                    [NameInMap("oncePlan")]
                    [Validation(Required=false)]
                    public string OncePlan { get; set; }

                    /// <summary>
                    /// <para>The time when the immediate plan was triggered.</para>
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
                /// <para>The status of the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The information about the sub-quotas.</para>
                /// </summary>
                [NameInMap("subQuotaInfoList")]
                [Validation(Required=false)]
                public List<ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoList> SubQuotaInfoList { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoList : TeaModel {
                    /// <summary>
                    /// <para>The billing information.</para>
                    /// </summary>
                    [NameInMap("billingPolicy")]
                    [Validation(Required=false)]
                    public ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                    public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListBillingPolicy : TeaModel {
                        /// <summary>
                        /// <para>The billing method.</para>
                        /// <list type="bullet">
                        /// <item><description><para>subscription: The subscription billing method.</para>
                        /// </description></item>
                        /// <item><description><para>payasyougo: The pay-as-you-go billing method.</para>
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
                        /// <para>The ID of the order.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>45245678</para>
                        /// </summary>
                        [NameInMap("orderId")]
                        [Validation(Required=false)]
                        public string OrderId { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the cluster.</para>
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
                    /// <para>The creator of the resource. This is the UID of an Alibaba Cloud account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>672863518</para>
                    /// </summary>
                    [NameInMap("creatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    /// <summary>
                    /// <para>The ID of the sub-quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000048</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the sub-quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subquotaA</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The alias of the sub-quota.</para>
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
                    public ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListParameter Parameter { get; set; }
                    public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListParameter : TeaModel {
                        [NameInMap("adhocSlot")]
                        [Validation(Required=false)]
                        public long? AdhocSlot { get; set; }

                        [NameInMap("autoScaleCPULimit")]
                        [Validation(Required=false)]
                        public long? AutoScaleCPULimit { get; set; }

                        /// <summary>
                        /// <para>The value of elastically reserved CUs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("elasticReservedCU")]
                        [Validation(Required=false)]
                        public long? ElasticReservedCU { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to enable priority-based scheduling.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("enablePriority")]
                        [Validation(Required=false)]
                        public bool? EnablePriority { get; set; }

                        /// <summary>
                        /// <para>Specifies whether the resource is exclusive.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("forceReservedMin")]
                        [Validation(Required=false)]
                        public bool? ForceReservedMin { get; set; }

                        /// <summary>
                        /// <para>The upper limit of reserved CUs.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("maxCU")]
                        [Validation(Required=false)]
                        public long? MaxCU { get; set; }

                        [NameInMap("maxGu")]
                        [Validation(Required=false)]
                        public long? MaxGu { get; set; }

                        /// <summary>
                        /// <para>The minimum number of guaranteed reserved CUs.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("minCU")]
                        [Validation(Required=false)]
                        public long? MinCU { get; set; }

                        [NameInMap("minGu")]
                        [Validation(Required=false)]
                        public long? MinGu { get; set; }

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

                        [NameInMap("slotNum")]
                        [Validation(Required=false)]
                        public long? SlotNum { get; set; }

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
                    /// <para>The ID of the region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-beijing</para>
                    /// </summary>
                    [NameInMap("regionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The identifier of the MaxCompute quota object. This identifier is the same as the one in the Alibaba Cloud bill and is used in tagging scenarios.</para>
                    /// </summary>
                    [NameInMap("saleTag")]
                    [Validation(Required=false)]
                    public ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListSaleTag SaleTag { get; set; }
                    public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListSaleTag : TeaModel {
                        /// <summary>
                        /// <para>The identifier of the MaxCompute quota object. This identifier also exists in the Alibaba Cloud sales subsystem. It associates the costs of the quota object with a tag.</para>
                        /// </summary>
                        [NameInMap("resourceIds")]
                        [Validation(Required=false)]
                        public List<string> ResourceIds { get; set; }

                        /// <summary>
                        /// <para>The type of the object. Only \<c>quota\\</c> and \<c>project\\</c> are supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>&quot;quota&quot;</para>
                        /// </summary>
                        [NameInMap("resourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                    }

                    /// <summary>
                    /// <para>The time-based scheduling information.</para>
                    /// </summary>
                    [NameInMap("scheduleInfo")]
                    [Validation(Required=false)]
                    public ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                    public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListScheduleInfo : TeaModel {
                        /// <summary>
                        /// <para>The quota plan that is currently in effect.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>planA</para>
                        /// </summary>
                        [NameInMap("currPlan")]
                        [Validation(Required=false)]
                        public string CurrPlan { get; set; }

                        /// <summary>
                        /// <para>The time when the current plan took effect.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0800</para>
                        /// </summary>
                        [NameInMap("currTime")]
                        [Validation(Required=false)]
                        public string CurrTime { get; set; }

                        /// <summary>
                        /// <para>The next quota plan that is scheduled to take effect.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>planB</para>
                        /// </summary>
                        [NameInMap("nextPlan")]
                        [Validation(Required=false)]
                        public string NextPlan { get; set; }

                        /// <summary>
                        /// <para>The time when the next plan is scheduled to take effect.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1700</para>
                        /// </summary>
                        [NameInMap("nextTime")]
                        [Validation(Required=false)]
                        public string NextTime { get; set; }

                        /// <summary>
                        /// <para>The quota plan that takes effect immediately. This parameter is returned only if a user triggers an immediate plan that is different from <c>currPlan</c>.</para>
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
                    /// <para>The status of the quota.</para>
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
                    /// <para>The ID of the tenant.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>280747109771520</para>
                    /// </summary>
                    [NameInMap("tenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    /// <summary>
                    /// <para>The type of the resource system. This parameter corresponds to the resourceSystemType parameter of the control cluster.</para>
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
                /// <para>The tag of the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>280747109771520</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The type of the resource system. This parameter corresponds to the resourceSystemType parameter of the control cluster.</para>
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

        /// <summary>
        /// <para>The token that specifies the position from which to start returning results. The results are sorted in alphabetical order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cHlvZHBzX3VkZl8xMDExNV8xNDU3NDI4NDkzKg==</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxItem")]
        [Validation(Required=false)]
        public long? MaxItem { get; set; }

        /// <summary>
        /// <para>The list of quotas.</para>
        /// </summary>
        [NameInMap("quotaInfoList")]
        [Validation(Required=false)]
        public List<ListQuotasResponseBodyQuotaInfoList> QuotaInfoList { get; set; }
        public class ListQuotasResponseBodyQuotaInfoList : TeaModel {
            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListQuotasResponseBodyQuotaInfoListTags> Tags { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Department</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The billing information.</para>
            /// </summary>
            [NameInMap("billingPolicy")]
            [Validation(Required=false)]
            public ListQuotasResponseBodyQuotaInfoListBillingPolicy BillingPolicy { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListBillingPolicy : TeaModel {
                /// <summary>
                /// <para>The billing method.</para>
                /// <list type="bullet">
                /// <item><description><para>subscription: The subscription billing method.</para>
                /// </description></item>
                /// <item><description><para>payasyougo: The pay-as-you-go billing method.</para>
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
                /// <para>The ID of the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>45245678</para>
                /// </summary>
                [NameInMap("orderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AT-120N</para>
            /// </summary>
            [NameInMap("cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            /// <summary>
            /// <para>The time when the quota was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-06T02:14:44Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the account that created the quota. This ID is an Alibaba Cloud account UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>672863518</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>The ID of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the quota.</para>
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
            /// <para>The parameters of the quota.</para>
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
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The sales tag of the quota. This tag is the same as the billing identifier and is used for cost allocation.</para>
            /// </summary>
            [NameInMap("saleTag")]
            [Validation(Required=false)]
            public ListQuotasResponseBodyQuotaInfoListSaleTag SaleTag { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListSaleTag : TeaModel {
                /// <summary>
                /// <para>The IDs of the resources. This ID is also used in the billing system. You can use this ID to associate the costs of a quota with a tag.</para>
                /// </summary>
                [NameInMap("resourceIds")]
                [Validation(Required=false)]
                public List<string> ResourceIds { get; set; }

                /// <summary>
                /// <para>The type of the resource. Valid values: quota and project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;project&quot;</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The time-based scheduling information.</para>
            /// </summary>
            [NameInMap("scheduleInfo")]
            [Validation(Required=false)]
            public ListQuotasResponseBodyQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListScheduleInfo : TeaModel {
                /// <summary>
                /// <para>The quota plan that is currently in effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planA</para>
                /// </summary>
                [NameInMap("currPlan")]
                [Validation(Required=false)]
                public string CurrPlan { get; set; }

                /// <summary>
                /// <para>The time when the current plan took effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0800</para>
                /// </summary>
                [NameInMap("currTime")]
                [Validation(Required=false)]
                public string CurrTime { get; set; }

                /// <summary>
                /// <para>The next quota plan that is scheduled to take effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planB</para>
                /// </summary>
                [NameInMap("nextPlan")]
                [Validation(Required=false)]
                public string NextPlan { get; set; }

                /// <summary>
                /// <para>The time when the next plan is scheduled to take effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1700</para>
                /// </summary>
                [NameInMap("nextTime")]
                [Validation(Required=false)]
                public string NextTime { get; set; }

                /// <summary>
                /// <para>The quota plan that takes effect immediately. This parameter is returned only when a user triggers an immediate plan that is different from the current plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planC</para>
                /// </summary>
                [NameInMap("oncePlan")]
                [Validation(Required=false)]
                public string OncePlan { get; set; }

                /// <summary>
                /// <para>The time when the immediate plan was triggered.</para>
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
            /// <para>The status of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The information about the sub-quotas.</para>
            /// </summary>
            [NameInMap("subQuotaInfoList")]
            [Validation(Required=false)]
            public List<ListQuotasResponseBodyQuotaInfoListSubQuotaInfoList> SubQuotaInfoList { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoList : TeaModel {
                /// <summary>
                /// <para>The billing information.</para>
                /// </summary>
                [NameInMap("billingPolicy")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListBillingPolicy : TeaModel {
                    /// <summary>
                    /// <para>The billing method.</para>
                    /// <list type="bullet">
                    /// <item><description><para>subscription: The subscription billing method.</para>
                    /// </description></item>
                    /// <item><description><para>payasyougo: The pay-as-you-go billing method.</para>
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
                    /// <para>The ID of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>45245678</para>
                    /// </summary>
                    [NameInMap("orderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AT-120N</para>
                /// </summary>
                [NameInMap("cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }

                /// <summary>
                /// <para>The time when the quota was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-06T02:14:44Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the account that created the quota. This ID is an Alibaba Cloud account UID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>672863518</para>
                /// </summary>
                [NameInMap("creatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The ID of the sub-quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000048</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the sub-quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>subquotaA</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The alias of the sub-quota.</para>
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
                /// <para>{&quot;minCU&quot;:10,	
                /// &quot;adhocCU&quot;:0,
                /// &quot;maxCU&quot;:10,
                /// &quot;schedulerType&quot;:&quot;Fair&quot;,
                /// }</para>
                /// </summary>
                [NameInMap("parameter")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListParameter Parameter { get; set; }
                public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListParameter : TeaModel {
                    [NameInMap("adhocSlot")]
                    [Validation(Required=false)]
                    public long? AdhocSlot { get; set; }

                    [NameInMap("autoScaleCPULimit")]
                    [Validation(Required=false)]
                    public long? AutoScaleCPULimit { get; set; }

                    /// <summary>
                    /// <para>The elastically reserved CUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("elasticReservedCU")]
                    [Validation(Required=false)]
                    public long? ElasticReservedCU { get; set; }

                    /// <summary>
                    /// <para>Indicates whether to enable priority-based scheduling.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enablePriority")]
                    [Validation(Required=false)]
                    public bool? EnablePriority { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the resource is exclusive.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("forceReservedMin")]
                    [Validation(Required=false)]
                    public bool? ForceReservedMin { get; set; }

                    /// <summary>
                    /// <para>The maximum reserved computing units (CUs).</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("maxCU")]
                    [Validation(Required=false)]
                    public long? MaxCU { get; set; }

                    [NameInMap("maxGu")]
                    [Validation(Required=false)]
                    public long? MaxGu { get; set; }

                    /// <summary>
                    /// <para>The minimum reserved CUs.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("minCU")]
                    [Validation(Required=false)]
                    public long? MinCU { get; set; }

                    [NameInMap("minGu")]
                    [Validation(Required=false)]
                    public long? MinGu { get; set; }

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
                    /// <para>The maximum CUs for a single job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("singleJobCULimit")]
                    [Validation(Required=false)]
                    public long? SingleJobCULimit { get; set; }

                    [NameInMap("slotNum")]
                    [Validation(Required=false)]
                    public long? SlotNum { get; set; }

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
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The sales tag of the quota. This tag is the same as the billing identifier and is used for cost allocation.</para>
                /// </summary>
                [NameInMap("saleTag")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListSaleTag SaleTag { get; set; }
                public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListSaleTag : TeaModel {
                    /// <summary>
                    /// <para>The IDs of the resources. This ID is also used in the billing system. You can use this ID to associate the costs of a quota with a tag.</para>
                    /// </summary>
                    [NameInMap("resourceIds")]
                    [Validation(Required=false)]
                    public List<string> ResourceIds { get; set; }

                    /// <summary>
                    /// <para>The type of the resource. Valid values: quota and project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;quota&quot;</para>
                    /// </summary>
                    [NameInMap("resourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                /// <summary>
                /// <para>The time-based scheduling information.</para>
                /// </summary>
                [NameInMap("scheduleInfo")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListScheduleInfo : TeaModel {
                    /// <summary>
                    /// <para>The quota plan that is currently in effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planA</para>
                    /// </summary>
                    [NameInMap("currPlan")]
                    [Validation(Required=false)]
                    public string CurrPlan { get; set; }

                    /// <summary>
                    /// <para>The time when the current plan took effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0800</para>
                    /// </summary>
                    [NameInMap("currTime")]
                    [Validation(Required=false)]
                    public string CurrTime { get; set; }

                    /// <summary>
                    /// <para>The next quota plan that is scheduled to take effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planB</para>
                    /// </summary>
                    [NameInMap("nextPlan")]
                    [Validation(Required=false)]
                    public string NextPlan { get; set; }

                    /// <summary>
                    /// <para>The time when the next plan is scheduled to take effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1700</para>
                    /// </summary>
                    [NameInMap("nextTime")]
                    [Validation(Required=false)]
                    public string NextTime { get; set; }

                    /// <summary>
                    /// <para>The quota plan that takes effect immediately. This parameter is returned only when a user triggers an immediate plan that is different from the current plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planC</para>
                    /// </summary>
                    [NameInMap("oncePlan")]
                    [Validation(Required=false)]
                    public string OncePlan { get; set; }

                    /// <summary>
                    /// <para>The time when the immediate plan was triggered.</para>
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
                /// <para>The status of the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tag of the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>280747109771520</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The type of the resource system. This parameter corresponds to the resourceSystemType parameter of the control cluster.</para>
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
            /// <para>The tag of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The ID of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>280747109771520</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The type of the resource system. This parameter corresponds to the resourceSystemType parameter of the control cluster.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc12e6f16677875480593081d2956</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
