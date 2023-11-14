// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListQuotasResponseBody : TeaModel {
        /// <summary>
        /// A pagination token. Only continuous page turning is supported. If NextToken is not empty, the next page exists. The value of NextToken can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListQuotasResponseBodyData Data { get; set; }
        public class ListQuotasResponseBodyData : TeaModel {
            /// <summary>
            /// A pagination token. Only continuous page turning is supported. If NextToken is not empty, the next page exists. The value of NextToken can be used in the next request to retrieve a new page of results.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// Indicates the marker after which the returned list begins.
            /// </summary>
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            /// <summary>
            /// The maximum number of entries returned per page.
            /// </summary>
            [NameInMap("maxItem")]
            [Validation(Required=false)]
            public long? MaxItem { get; set; }

            /// <summary>
            /// The list of quotas.
            /// </summary>
            [NameInMap("quotaInfoList")]
            [Validation(Required=false)]
            public List<ListQuotasResponseBodyDataQuotaInfoList> QuotaInfoList { get; set; }
            public class ListQuotasResponseBodyDataQuotaInfoList : TeaModel {
                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListQuotasResponseBodyDataQuotaInfoListTags> Tags { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListTags : TeaModel {
                    /// <summary>
                    /// The key of the tag.
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// The value of the tag.
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                /// <summary>
                /// The information of the order.
                /// </summary>
                [NameInMap("billingPolicy")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyDataQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListBillingPolicy : TeaModel {
                    /// <summary>
                    /// The billing method of the quota. Valid values:
                    /// 
                    /// *   subscription: a subscription quota.
                    /// *   payasyougo: a pay-as-you-go quota.
                    /// </summary>
                    [NameInMap("billingMethod")]
                    [Validation(Required=false)]
                    public string BillingMethod { get; set; }

                    /// <summary>
                    /// The specifications of the order.
                    /// </summary>
                    [NameInMap("odpsSpecCode")]
                    [Validation(Required=false)]
                    public string OdpsSpecCode { get; set; }

                    /// <summary>
                    /// The order ID.
                    /// </summary>
                    [NameInMap("orderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                }

                /// <summary>
                /// The cluster ID.
                /// </summary>
                [NameInMap("cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }

                /// <summary>
                /// The time when the resource was created.
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is used to create the resource.
                /// </summary>
                [NameInMap("creatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// The quota ID.
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The name of the quota.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The alias of the quota.
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// The description of the quota.
                /// </summary>
                [NameInMap("parameter")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameter { get; set; }

                /// <summary>
                /// The ID of the parent resource.
                /// </summary>
                [NameInMap("parentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The identifier of an object in a MaxCompute quota. This identifier is the same as the identifier in the sales bill of Alibaba Cloud. This parameter is used for tags.
                /// </summary>
                [NameInMap("saleTag")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyDataQuotaInfoListSaleTag SaleTag { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListSaleTag : TeaModel {
                    /// <summary>
                    /// The identifier of an object in a MaxCompute quota. This identifier exists in the sales bill of Alibaba Cloud. You can use this identifier to associate the cost of a quota object with a tag.
                    /// </summary>
                    [NameInMap("resourceIds")]
                    [Validation(Required=false)]
                    public List<string> ResourceIds { get; set; }

                    /// <summary>
                    /// The type of the object. Valid values: quota and project.
                    /// </summary>
                    [NameInMap("resourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                /// <summary>
                /// The information of the scheduling plan.
                /// </summary>
                [NameInMap("scheduleInfo")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyDataQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListScheduleInfo : TeaModel {
                    /// <summary>
                    /// The quota plan that takes effect based on the scheduling plan.
                    /// </summary>
                    [NameInMap("currPlan")]
                    [Validation(Required=false)]
                    public string CurrPlan { get; set; }

                    /// <summary>
                    /// The time when the current quota plan is scheduled.
                    /// </summary>
                    [NameInMap("currTime")]
                    [Validation(Required=false)]
                    public string CurrTime { get; set; }

                    /// <summary>
                    /// The next quota plan that will take effect based on the scheduling plan.
                    /// </summary>
                    [NameInMap("nextPlan")]
                    [Validation(Required=false)]
                    public string NextPlan { get; set; }

                    /// <summary>
                    /// The time when the next quota plan is scheduled.
                    /// </summary>
                    [NameInMap("nextTime")]
                    [Validation(Required=false)]
                    public string NextTime { get; set; }

                    /// <summary>
                    /// The quota plan that immediately takes effect. If the quota plan that immediately takes effect is different from the current quota plan, this parameter is not empty.
                    /// </summary>
                    [NameInMap("oncePlan")]
                    [Validation(Required=false)]
                    public string OncePlan { get; set; }

                    /// <summary>
                    /// The time when the quota plan immediately takes effect.
                    /// </summary>
                    [NameInMap("onceTime")]
                    [Validation(Required=false)]
                    public string OnceTime { get; set; }

                    /// <summary>
                    /// The name of the operator.
                    /// </summary>
                    [NameInMap("operatorName")]
                    [Validation(Required=false)]
                    public string OperatorName { get; set; }

                    /// <summary>
                    /// The time zone of the project.
                    /// </summary>
                    [NameInMap("timezone")]
                    [Validation(Required=false)]
                    public string Timezone { get; set; }

                }

                /// <summary>
                /// The status of the endpoint group.
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The information of the level-2 quota.
                /// </summary>
                [NameInMap("subQuotaInfoList")]
                [Validation(Required=false)]
                public List<ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoList> SubQuotaInfoList { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoList : TeaModel {
                    /// <summary>
                    /// The information of the order.
                    /// </summary>
                    [NameInMap("billingPolicy")]
                    [Validation(Required=false)]
                    public ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                    public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListBillingPolicy : TeaModel {
                        /// <summary>
                        /// The billing method of the quota. Valid values:
                        /// 
                        /// *   subscription: a subscription quota.
                        /// *   payasyougo: a pay-as-you-go quota.
                        /// </summary>
                        [NameInMap("billingMethod")]
                        [Validation(Required=false)]
                        public string BillingMethod { get; set; }

                        /// <summary>
                        /// The specifications of the order.
                        /// </summary>
                        [NameInMap("odpsSpecCode")]
                        [Validation(Required=false)]
                        public string OdpsSpecCode { get; set; }

                        /// <summary>
                        /// The order ID.
                        /// </summary>
                        [NameInMap("orderId")]
                        [Validation(Required=false)]
                        public string OrderId { get; set; }

                    }

                    /// <summary>
                    /// The cluster ID.
                    /// </summary>
                    [NameInMap("cluster")]
                    [Validation(Required=false)]
                    public string Cluster { get; set; }

                    /// <summary>
                    /// The time when the resource was created.
                    /// </summary>
                    [NameInMap("createTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// The ID of the Alibaba Cloud account that is used to create the resource.
                    /// </summary>
                    [NameInMap("creatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    /// <summary>
                    /// The ID of the level-2 quota.
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The name of the level-2 quota.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The nickname of the level-2 quota.
                    /// </summary>
                    [NameInMap("nickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                    /// <summary>
                    /// The description of the quota.
                    /// </summary>
                    [NameInMap("parameter")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Parameter { get; set; }

                    /// <summary>
                    /// The ID of the parent resource.
                    /// </summary>
                    [NameInMap("parentId")]
                    [Validation(Required=false)]
                    public string ParentId { get; set; }

                    /// <summary>
                    /// The region ID.
                    /// </summary>
                    [NameInMap("regionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// The identifier of an object in a MaxCompute quota. This identifier is the same as the identifier in the sales bill of Alibaba Cloud. This parameter is used for tags.
                    /// </summary>
                    [NameInMap("saleTag")]
                    [Validation(Required=false)]
                    public ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListSaleTag SaleTag { get; set; }
                    public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListSaleTag : TeaModel {
                        /// <summary>
                        /// The identifier of an object in a MaxCompute quota. This identifier exists in the sales bill of Alibaba Cloud. You can use this identifier to associate the cost of a quota object with a tag.
                        /// </summary>
                        [NameInMap("resourceIds")]
                        [Validation(Required=false)]
                        public List<string> ResourceIds { get; set; }

                        /// <summary>
                        /// The type of the object. Valid values: quota and project.
                        /// </summary>
                        [NameInMap("resourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                    }

                    /// <summary>
                    /// The information of the scheduling plan.
                    /// </summary>
                    [NameInMap("scheduleInfo")]
                    [Validation(Required=false)]
                    public ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                    public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListScheduleInfo : TeaModel {
                        /// <summary>
                        /// The quota plan that takes effect based on the scheduling plan.
                        /// </summary>
                        [NameInMap("currPlan")]
                        [Validation(Required=false)]
                        public string CurrPlan { get; set; }

                        /// <summary>
                        /// The time when the current quota plan is scheduled.
                        /// </summary>
                        [NameInMap("currTime")]
                        [Validation(Required=false)]
                        public string CurrTime { get; set; }

                        /// <summary>
                        /// The next quota plan that will take effect based on the scheduling plan.
                        /// </summary>
                        [NameInMap("nextPlan")]
                        [Validation(Required=false)]
                        public string NextPlan { get; set; }

                        /// <summary>
                        /// The time when the next quota plan is scheduled.
                        /// </summary>
                        [NameInMap("nextTime")]
                        [Validation(Required=false)]
                        public string NextTime { get; set; }

                        /// <summary>
                        /// The quota plan that immediately takes effect. If the quota plan that immediately takes effect is different from the current quota plan, this parameter is not empty.
                        /// </summary>
                        [NameInMap("oncePlan")]
                        [Validation(Required=false)]
                        public string OncePlan { get; set; }

                        /// <summary>
                        /// The time when the quota plan immediately takes effect.
                        /// </summary>
                        [NameInMap("onceTime")]
                        [Validation(Required=false)]
                        public string OnceTime { get; set; }

                        /// <summary>
                        /// The name of the operator.
                        /// </summary>
                        [NameInMap("operatorName")]
                        [Validation(Required=false)]
                        public string OperatorName { get; set; }

                        /// <summary>
                        /// The time zone of the project.
                        /// </summary>
                        [NameInMap("timezone")]
                        [Validation(Required=false)]
                        public string Timezone { get; set; }

                    }

                    /// <summary>
                    /// The status of the endpoint group.
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The tag of the resource for the quota.
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// The tenant ID.
                    /// </summary>
                    [NameInMap("tenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    /// <summary>
                    /// The type of the resource system. This parameter corresponds to the resourceSystemType parameter of the cluster.
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The version of the algorithm image.
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// The tag of the resource for the quota.
                /// </summary>
                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// The tenant ID.
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// The type of the resource system. This parameter corresponds to the resourceSystemType parameter of the cluster.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The version number.
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// Indicates the marker after which the returned list begins.
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The maximum number of entries returned per page.
        /// </summary>
        [NameInMap("maxItem")]
        [Validation(Required=false)]
        public long? MaxItem { get; set; }

        /// <summary>
        /// The list of quotas.
        /// </summary>
        [NameInMap("quotaInfoList")]
        [Validation(Required=false)]
        public List<ListQuotasResponseBodyQuotaInfoList> QuotaInfoList { get; set; }
        public class ListQuotasResponseBodyQuotaInfoList : TeaModel {
            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListQuotasResponseBodyQuotaInfoListTags> Tags { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListTags : TeaModel {
                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// The information of the order.
            /// </summary>
            [NameInMap("billingPolicy")]
            [Validation(Required=false)]
            public ListQuotasResponseBodyQuotaInfoListBillingPolicy BillingPolicy { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListBillingPolicy : TeaModel {
                /// <summary>
                /// The billing method of the quota. Valid values:
                /// 
                /// *   subscription: a subscription quota.
                /// *   payasyougo: a pay-as-you-go quota.
                /// </summary>
                [NameInMap("billingMethod")]
                [Validation(Required=false)]
                public string BillingMethod { get; set; }

                /// <summary>
                /// The specifications of the order.
                /// </summary>
                [NameInMap("odpsSpecCode")]
                [Validation(Required=false)]
                public string OdpsSpecCode { get; set; }

                /// <summary>
                /// The order ID.
                /// </summary>
                [NameInMap("orderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

            }

            /// <summary>
            /// The cluster ID.
            /// </summary>
            [NameInMap("cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            /// <summary>
            /// The time when the resource was created.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to create the resource.
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// The quota ID.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The name of the quota.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The alias of the quota.
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// The description of the quota.
            /// </summary>
            [NameInMap("parameter")]
            [Validation(Required=false)]
            public Dictionary<string, object> Parameter { get; set; }

            /// <summary>
            /// The ID of the parent resource.
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The identifier of an object in a MaxCompute quota. This identifier is the same as the identifier in the sales bill of Alibaba Cloud. This parameter is used for tags.
            /// </summary>
            [NameInMap("saleTag")]
            [Validation(Required=false)]
            public ListQuotasResponseBodyQuotaInfoListSaleTag SaleTag { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListSaleTag : TeaModel {
                /// <summary>
                /// The identifier of an object in a MaxCompute quota. This identifier exists in the sales bill of Alibaba Cloud. You can use this identifier to associate the cost of a quota object with a tag.
                /// </summary>
                [NameInMap("resourceIds")]
                [Validation(Required=false)]
                public List<string> ResourceIds { get; set; }

                /// <summary>
                /// The type of the object. Valid values: quota and project.
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// The information of the scheduling plan.
            /// </summary>
            [NameInMap("scheduleInfo")]
            [Validation(Required=false)]
            public ListQuotasResponseBodyQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListScheduleInfo : TeaModel {
                /// <summary>
                /// The quota plan that takes effect based on the scheduling plan.
                /// </summary>
                [NameInMap("currPlan")]
                [Validation(Required=false)]
                public string CurrPlan { get; set; }

                /// <summary>
                /// The time when the current quota plan is scheduled.
                /// </summary>
                [NameInMap("currTime")]
                [Validation(Required=false)]
                public string CurrTime { get; set; }

                /// <summary>
                /// The next quota plan that will take effect based on the scheduling plan.
                /// </summary>
                [NameInMap("nextPlan")]
                [Validation(Required=false)]
                public string NextPlan { get; set; }

                /// <summary>
                /// The time when the next quota plan is scheduled.
                /// </summary>
                [NameInMap("nextTime")]
                [Validation(Required=false)]
                public string NextTime { get; set; }

                /// <summary>
                /// The quota plan that immediately takes effect. If the quota plan that immediately takes effect is different from the current quota plan, this parameter is not empty.
                /// </summary>
                [NameInMap("oncePlan")]
                [Validation(Required=false)]
                public string OncePlan { get; set; }

                /// <summary>
                /// The time when the quota plan immediately takes effect.
                /// </summary>
                [NameInMap("onceTime")]
                [Validation(Required=false)]
                public string OnceTime { get; set; }

                /// <summary>
                /// The name of the operator.
                /// </summary>
                [NameInMap("operatorName")]
                [Validation(Required=false)]
                public string OperatorName { get; set; }

                /// <summary>
                /// The time zone of the project.
                /// </summary>
                [NameInMap("timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

            }

            /// <summary>
            /// The status of the endpoint group.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The information of the level-2 quota.
            /// </summary>
            [NameInMap("subQuotaInfoList")]
            [Validation(Required=false)]
            public List<ListQuotasResponseBodyQuotaInfoListSubQuotaInfoList> SubQuotaInfoList { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoList : TeaModel {
                /// <summary>
                /// The information of the order.
                /// </summary>
                [NameInMap("billingPolicy")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListBillingPolicy : TeaModel {
                    /// <summary>
                    /// The billing method of the quota. Valid values:
                    /// 
                    /// *   subscription: a subscription quota.
                    /// *   payasyougo: a pay-as-you-go quota.
                    /// </summary>
                    [NameInMap("billingMethod")]
                    [Validation(Required=false)]
                    public string BillingMethod { get; set; }

                    /// <summary>
                    /// The specifications of the order.
                    /// </summary>
                    [NameInMap("odpsSpecCode")]
                    [Validation(Required=false)]
                    public string OdpsSpecCode { get; set; }

                    /// <summary>
                    /// The order ID.
                    /// </summary>
                    [NameInMap("orderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                }

                /// <summary>
                /// The cluster ID.
                /// </summary>
                [NameInMap("cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }

                /// <summary>
                /// The time when the resource was created.
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is used to create the resource.
                /// </summary>
                [NameInMap("creatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// The ID of the level-2 quota.
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The name of the level-2 quota.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The alias of the level-2 quota.
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// The description of the quota.
                /// </summary>
                [NameInMap("parameter")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameter { get; set; }

                /// <summary>
                /// The ID of the parent resource.
                /// </summary>
                [NameInMap("parentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The identifier of an object in a MaxCompute quota. This identifier is the same as the identifier in the sales bill of Alibaba Cloud. This parameter is used for tags.
                /// </summary>
                [NameInMap("saleTag")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListSaleTag SaleTag { get; set; }
                public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListSaleTag : TeaModel {
                    /// <summary>
                    /// The identifier of an object in a MaxCompute quota. This identifier exists in the sales bill of Alibaba Cloud. You can use this identifier to associate the cost of a quota object with a tag.
                    /// </summary>
                    [NameInMap("resourceIds")]
                    [Validation(Required=false)]
                    public List<string> ResourceIds { get; set; }

                    /// <summary>
                    /// The type of the object. Valid values: quota and project.
                    /// </summary>
                    [NameInMap("resourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                /// <summary>
                /// The information of the scheduling plan.
                /// </summary>
                [NameInMap("scheduleInfo")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListScheduleInfo : TeaModel {
                    /// <summary>
                    /// The quota plan that takes effect based on the scheduling plan.
                    /// </summary>
                    [NameInMap("currPlan")]
                    [Validation(Required=false)]
                    public string CurrPlan { get; set; }

                    /// <summary>
                    /// The time when the current quota plan is scheduled.
                    /// </summary>
                    [NameInMap("currTime")]
                    [Validation(Required=false)]
                    public string CurrTime { get; set; }

                    /// <summary>
                    /// The next quota plan that will take effect based on the scheduling plan.
                    /// </summary>
                    [NameInMap("nextPlan")]
                    [Validation(Required=false)]
                    public string NextPlan { get; set; }

                    /// <summary>
                    /// The time when the next quota plan is scheduled.
                    /// </summary>
                    [NameInMap("nextTime")]
                    [Validation(Required=false)]
                    public string NextTime { get; set; }

                    /// <summary>
                    /// The quota plan that immediately takes effect. If the quota plan that immediately takes effect is different from the current quota plan, this parameter is not empty.
                    /// </summary>
                    [NameInMap("oncePlan")]
                    [Validation(Required=false)]
                    public string OncePlan { get; set; }

                    /// <summary>
                    /// The time when the quota plan immediately takes effect.
                    /// </summary>
                    [NameInMap("onceTime")]
                    [Validation(Required=false)]
                    public string OnceTime { get; set; }

                    /// <summary>
                    /// The name of the operator.
                    /// </summary>
                    [NameInMap("operatorName")]
                    [Validation(Required=false)]
                    public string OperatorName { get; set; }

                    /// <summary>
                    /// The time zone of the project.
                    /// </summary>
                    [NameInMap("timezone")]
                    [Validation(Required=false)]
                    public string Timezone { get; set; }

                }

                /// <summary>
                /// The status of the endpoint group.
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tag of the resource for the quota.
                /// </summary>
                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// The tenant ID.
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// The type of the resource system. This parameter corresponds to the resourceSystemType parameter of the cluster.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The version number.
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// The tag of the resource for the quota.
            /// </summary>
            [NameInMap("tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// The tenant ID.
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// The type of the resource system. This parameter corresponds to the resourceSystemType parameter of the cluster.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The version.
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
