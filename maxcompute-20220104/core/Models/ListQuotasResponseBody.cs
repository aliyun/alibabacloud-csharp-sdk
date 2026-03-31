// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListQuotasResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. Only continuous page turning is supported. If NextToken is not empty, the next page exists. The value of NextToken can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2w6Olxc+cMPjUtUMo/CvPe4IK7f7kIQFrIZjyc</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListQuotasResponseBodyData Data { get; set; }
        public class ListQuotasResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A pagination token. Only continuous page turning is supported. If NextToken is not empty, the next page exists. The value of NextToken can be used in the next request to retrieve a new page of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;abcde&quot;</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>Indicates the marker after which the returned list begins.</para>
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
                    /// <para>a12351qHDP6YEQMt</para>
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                /// <summary>
                /// <para>The information of the order.</para>
                /// </summary>
                [NameInMap("billingPolicy")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyDataQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListBillingPolicy : TeaModel {
                    /// <summary>
                    /// <para>The billing method of the quota. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>subscription: a subscription quota.</description></item>
                    /// <item><description>payasyougo: a pay-as-you-go quota.</description></item>
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
                /// <para>The ID of the Alibaba Cloud account that is used to create the resource.</para>
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
                /// <para>The identifier of an object in a MaxCompute quota. This identifier is the same as the identifier in the sales bill of Alibaba Cloud. This parameter is used for tags.</para>
                /// </summary>
                [NameInMap("saleTag")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyDataQuotaInfoListSaleTag SaleTag { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListSaleTag : TeaModel {
                    /// <summary>
                    /// <para>The identifier of an object in a MaxCompute quota. This identifier exists in the sales bill of Alibaba Cloud. You can use this identifier to associate the cost of a quota object with a tag.</para>
                    /// </summary>
                    [NameInMap("resourceIds")]
                    [Validation(Required=false)]
                    public List<string> ResourceIds { get; set; }

                    /// <summary>
                    /// <para>The type of the object. Valid values: quota and project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;quota&quot;</para>
                    /// </summary>
                    [NameInMap("resourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                /// <summary>
                /// <para>The information of the scheduling plan.</para>
                /// </summary>
                [NameInMap("scheduleInfo")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyDataQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListScheduleInfo : TeaModel {
                    /// <summary>
                    /// <para>The quota plan that takes effect based on the scheduling plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planA</para>
                    /// </summary>
                    [NameInMap("currPlan")]
                    [Validation(Required=false)]
                    public string CurrPlan { get; set; }

                    /// <summary>
                    /// <para>The time when the current quota plan is scheduled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0800</para>
                    /// </summary>
                    [NameInMap("currTime")]
                    [Validation(Required=false)]
                    public string CurrTime { get; set; }

                    /// <summary>
                    /// <para>The next quota plan that will take effect based on the scheduling plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planB</para>
                    /// </summary>
                    [NameInMap("nextPlan")]
                    [Validation(Required=false)]
                    public string NextPlan { get; set; }

                    /// <summary>
                    /// <para>The time when the next quota plan is scheduled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1700</para>
                    /// </summary>
                    [NameInMap("nextTime")]
                    [Validation(Required=false)]
                    public string NextTime { get; set; }

                    /// <summary>
                    /// <para>The quota plan that immediately takes effect. If the quota plan that immediately takes effect is different from the current quota plan, this parameter is not empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planC</para>
                    /// </summary>
                    [NameInMap("oncePlan")]
                    [Validation(Required=false)]
                    public string OncePlan { get; set; }

                    /// <summary>
                    /// <para>The time when the quota plan immediately takes effect.</para>
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
                /// <para>The status of the endpoint group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The information of the level-2 quota.</para>
                /// </summary>
                [NameInMap("subQuotaInfoList")]
                [Validation(Required=false)]
                public List<ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoList> SubQuotaInfoList { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoList : TeaModel {
                    /// <summary>
                    /// <para>The information of the order.</para>
                    /// </summary>
                    [NameInMap("billingPolicy")]
                    [Validation(Required=false)]
                    public ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                    public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListBillingPolicy : TeaModel {
                        /// <summary>
                        /// <para>The billing method of the quota. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>subscription: a subscription quota.</description></item>
                        /// <item><description>payasyougo: a pay-as-you-go quota.</description></item>
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
                    /// <para>The ID of the Alibaba Cloud account that is used to create the resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>672863518</para>
                    /// </summary>
                    [NameInMap("creatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

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

                        [NameInMap("elasticReservedCU")]
                        [Validation(Required=false)]
                        public long? ElasticReservedCU { get; set; }

                        [NameInMap("enablePriority")]
                        [Validation(Required=false)]
                        public bool? EnablePriority { get; set; }

                        [NameInMap("forceReservedMin")]
                        [Validation(Required=false)]
                        public bool? ForceReservedMin { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("maxCU")]
                        [Validation(Required=false)]
                        public long? MaxCU { get; set; }

                        [NameInMap("maxGu")]
                        [Validation(Required=false)]
                        public long? MaxGu { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("minCU")]
                        [Validation(Required=false)]
                        public long? MinCU { get; set; }

                        [NameInMap("minGu")]
                        [Validation(Required=false)]
                        public long? MinGu { get; set; }

                        [NameInMap("schedulerType")]
                        [Validation(Required=false)]
                        public string SchedulerType { get; set; }

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
                    /// <para>The region ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-beijing</para>
                    /// </summary>
                    [NameInMap("regionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The identifier of an object in a MaxCompute quota. This identifier is the same as the identifier in the sales bill of Alibaba Cloud. This parameter is used for tags.</para>
                    /// </summary>
                    [NameInMap("saleTag")]
                    [Validation(Required=false)]
                    public ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListSaleTag SaleTag { get; set; }
                    public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListSaleTag : TeaModel {
                        /// <summary>
                        /// <para>The identifier of an object in a MaxCompute quota. This identifier exists in the sales bill of Alibaba Cloud. You can use this identifier to associate the cost of a quota object with a tag.</para>
                        /// </summary>
                        [NameInMap("resourceIds")]
                        [Validation(Required=false)]
                        public List<string> ResourceIds { get; set; }

                        /// <summary>
                        /// <para>The type of the object. Valid values: quota and project.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>&quot;quota&quot;</para>
                        /// </summary>
                        [NameInMap("resourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                    }

                    /// <summary>
                    /// <para>The information of the scheduling plan.</para>
                    /// </summary>
                    [NameInMap("scheduleInfo")]
                    [Validation(Required=false)]
                    public ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                    public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListScheduleInfo : TeaModel {
                        /// <summary>
                        /// <para>The quota plan that takes effect based on the scheduling plan.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>planA</para>
                        /// </summary>
                        [NameInMap("currPlan")]
                        [Validation(Required=false)]
                        public string CurrPlan { get; set; }

                        /// <summary>
                        /// <para>The time when the current quota plan is scheduled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0800</para>
                        /// </summary>
                        [NameInMap("currTime")]
                        [Validation(Required=false)]
                        public string CurrTime { get; set; }

                        /// <summary>
                        /// <para>The next quota plan that will take effect based on the scheduling plan.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>planB</para>
                        /// </summary>
                        [NameInMap("nextPlan")]
                        [Validation(Required=false)]
                        public string NextPlan { get; set; }

                        /// <summary>
                        /// <para>The time when the next quota plan is scheduled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1700</para>
                        /// </summary>
                        [NameInMap("nextTime")]
                        [Validation(Required=false)]
                        public string NextTime { get; set; }

                        /// <summary>
                        /// <para>The quota plan that immediately takes effect. If the quota plan that immediately takes effect is different from the current quota plan, this parameter is not empty.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>planC</para>
                        /// </summary>
                        [NameInMap("oncePlan")]
                        [Validation(Required=false)]
                        public string OncePlan { get; set; }

                        /// <summary>
                        /// <para>The time when the quota plan immediately takes effect.</para>
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
                    /// <para>The status of the endpoint group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ON</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The tag of the resource for the quota.</para>
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
                    /// <para>280747109771520</para>
                    /// </summary>
                    [NameInMap("tenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    /// <summary>
                    /// <para>The type of the resource system. This parameter corresponds to the resourceSystemType parameter of the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FUXI_ONLINE</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The version of the algorithm image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>The tag of the resource for the quota.</para>
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
                /// <para>280747109771520</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The type of the resource system. This parameter corresponds to the resourceSystemType parameter of the cluster.</para>
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
        /// <para>Indicates the marker after which the returned list begins.</para>
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
            /// <para>The information of the order.</para>
            /// </summary>
            [NameInMap("billingPolicy")]
            [Validation(Required=false)]
            public ListQuotasResponseBodyQuotaInfoListBillingPolicy BillingPolicy { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListBillingPolicy : TeaModel {
                /// <summary>
                /// <para>The billing method of the quota. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>subscription: a subscription quota.</description></item>
                /// <item><description>payasyougo: a pay-as-you-go quota.</description></item>
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
            /// <para>The ID of the Alibaba Cloud account that is used to create the resource.</para>
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
            /// <para>The identifier of an object in a MaxCompute quota. This identifier is the same as the identifier in the sales bill of Alibaba Cloud. This parameter is used for tags.</para>
            /// </summary>
            [NameInMap("saleTag")]
            [Validation(Required=false)]
            public ListQuotasResponseBodyQuotaInfoListSaleTag SaleTag { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListSaleTag : TeaModel {
                /// <summary>
                /// <para>The identifier of an object in a MaxCompute quota. This identifier exists in the sales bill of Alibaba Cloud. You can use this identifier to associate the cost of a quota object with a tag.</para>
                /// </summary>
                [NameInMap("resourceIds")]
                [Validation(Required=false)]
                public List<string> ResourceIds { get; set; }

                /// <summary>
                /// <para>The type of the object. Valid values: quota and project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;project&quot;</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The information of the scheduling plan.</para>
            /// </summary>
            [NameInMap("scheduleInfo")]
            [Validation(Required=false)]
            public ListQuotasResponseBodyQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListScheduleInfo : TeaModel {
                /// <summary>
                /// <para>The quota plan that takes effect based on the scheduling plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planA</para>
                /// </summary>
                [NameInMap("currPlan")]
                [Validation(Required=false)]
                public string CurrPlan { get; set; }

                /// <summary>
                /// <para>The time when the current quota plan is scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0800</para>
                /// </summary>
                [NameInMap("currTime")]
                [Validation(Required=false)]
                public string CurrTime { get; set; }

                /// <summary>
                /// <para>The next quota plan that will take effect based on the scheduling plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planB</para>
                /// </summary>
                [NameInMap("nextPlan")]
                [Validation(Required=false)]
                public string NextPlan { get; set; }

                /// <summary>
                /// <para>The time when the next quota plan is scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1700</para>
                /// </summary>
                [NameInMap("nextTime")]
                [Validation(Required=false)]
                public string NextTime { get; set; }

                /// <summary>
                /// <para>The quota plan that immediately takes effect. If the quota plan that immediately takes effect is different from the current quota plan, this parameter is not empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>planC</para>
                /// </summary>
                [NameInMap("oncePlan")]
                [Validation(Required=false)]
                public string OncePlan { get; set; }

                /// <summary>
                /// <para>The time when the quota plan immediately takes effect.</para>
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
            /// <para>The status of the endpoint group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The information of the level-2 quota.</para>
            /// </summary>
            [NameInMap("subQuotaInfoList")]
            [Validation(Required=false)]
            public List<ListQuotasResponseBodyQuotaInfoListSubQuotaInfoList> SubQuotaInfoList { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoList : TeaModel {
                /// <summary>
                /// <para>The information of the order.</para>
                /// </summary>
                [NameInMap("billingPolicy")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListBillingPolicy : TeaModel {
                    /// <summary>
                    /// <para>The billing method of the quota. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>subscription: a subscription quota.</description></item>
                    /// <item><description>payasyougo: a pay-as-you-go quota.</description></item>
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
                /// <para>The ID of the Alibaba Cloud account that is used to create the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>672863518</para>
                /// </summary>
                [NameInMap("creatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

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
                public ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListParameter Parameter { get; set; }
                public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListParameter : TeaModel {
                    [NameInMap("adhocSlot")]
                    [Validation(Required=false)]
                    public long? AdhocSlot { get; set; }

                    [NameInMap("autoScaleCPULimit")]
                    [Validation(Required=false)]
                    public long? AutoScaleCPULimit { get; set; }

                    [NameInMap("elasticReservedCU")]
                    [Validation(Required=false)]
                    public long? ElasticReservedCU { get; set; }

                    [NameInMap("enablePriority")]
                    [Validation(Required=false)]
                    public bool? EnablePriority { get; set; }

                    [NameInMap("forceReservedMin")]
                    [Validation(Required=false)]
                    public bool? ForceReservedMin { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("maxCU")]
                    [Validation(Required=false)]
                    public long? MaxCU { get; set; }

                    [NameInMap("maxGu")]
                    [Validation(Required=false)]
                    public long? MaxGu { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("minCU")]
                    [Validation(Required=false)]
                    public long? MinCU { get; set; }

                    [NameInMap("minGu")]
                    [Validation(Required=false)]
                    public long? MinGu { get; set; }

                    [NameInMap("schedulerType")]
                    [Validation(Required=false)]
                    public string SchedulerType { get; set; }

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
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The identifier of an object in a MaxCompute quota. This identifier is the same as the identifier in the sales bill of Alibaba Cloud. This parameter is used for tags.</para>
                /// </summary>
                [NameInMap("saleTag")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListSaleTag SaleTag { get; set; }
                public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListSaleTag : TeaModel {
                    /// <summary>
                    /// <para>The identifier of an object in a MaxCompute quota. This identifier exists in the sales bill of Alibaba Cloud. You can use this identifier to associate the cost of a quota object with a tag.</para>
                    /// </summary>
                    [NameInMap("resourceIds")]
                    [Validation(Required=false)]
                    public List<string> ResourceIds { get; set; }

                    /// <summary>
                    /// <para>The type of the object. Valid values: quota and project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;quota&quot;</para>
                    /// </summary>
                    [NameInMap("resourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                /// <summary>
                /// <para>The information of the scheduling plan.</para>
                /// </summary>
                [NameInMap("scheduleInfo")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListScheduleInfo : TeaModel {
                    /// <summary>
                    /// <para>The quota plan that takes effect based on the scheduling plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planA</para>
                    /// </summary>
                    [NameInMap("currPlan")]
                    [Validation(Required=false)]
                    public string CurrPlan { get; set; }

                    /// <summary>
                    /// <para>The time when the current quota plan is scheduled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0800</para>
                    /// </summary>
                    [NameInMap("currTime")]
                    [Validation(Required=false)]
                    public string CurrTime { get; set; }

                    /// <summary>
                    /// <para>The next quota plan that will take effect based on the scheduling plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planB</para>
                    /// </summary>
                    [NameInMap("nextPlan")]
                    [Validation(Required=false)]
                    public string NextPlan { get; set; }

                    /// <summary>
                    /// <para>The time when the next quota plan is scheduled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1700</para>
                    /// </summary>
                    [NameInMap("nextTime")]
                    [Validation(Required=false)]
                    public string NextTime { get; set; }

                    /// <summary>
                    /// <para>The quota plan that immediately takes effect. If the quota plan that immediately takes effect is different from the current quota plan, this parameter is not empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planC</para>
                    /// </summary>
                    [NameInMap("oncePlan")]
                    [Validation(Required=false)]
                    public string OncePlan { get; set; }

                    /// <summary>
                    /// <para>The time when the quota plan immediately takes effect.</para>
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
                /// <para>The status of the endpoint group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tag of the resource for the quota.</para>
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
                /// <para>280747109771520</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The type of the resource system. This parameter corresponds to the resourceSystemType parameter of the cluster.</para>
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
            /// <para>The tag of the resource for the quota.</para>
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
            /// <para>280747109771520</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The type of the resource system. This parameter corresponds to the resourceSystemType parameter of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FUXI_ONLINE</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version.</para>
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
