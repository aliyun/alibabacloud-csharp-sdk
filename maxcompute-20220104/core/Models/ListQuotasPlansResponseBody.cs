// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListQuotasPlansResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListQuotasPlansResponseBodyData Data { get; set; }
        public class ListQuotasPlansResponseBodyData : TeaModel {
            /// <summary>
            /// The list of quota plans.
            /// </summary>
            [NameInMap("planList")]
            [Validation(Required=false)]
            public List<ListQuotasPlansResponseBodyDataPlanList> PlanList { get; set; }
            public class ListQuotasPlansResponseBodyDataPlanList : TeaModel {
                /// <summary>
                /// The time when the quota plan was created.
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The name of the quota plan.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The details of the quota.
                /// </summary>
                [NameInMap("quota")]
                [Validation(Required=false)]
                public ListQuotasPlansResponseBodyDataPlanListQuota Quota { get; set; }
                public class ListQuotasPlansResponseBodyDataPlanListQuota : TeaModel {
                    /// <summary>
                    /// The information of the order.
                    /// </summary>
                    [NameInMap("billingPolicy")]
                    [Validation(Required=false)]
                    public ListQuotasPlansResponseBodyDataPlanListQuotaBillingPolicy BillingPolicy { get; set; }
                    public class ListQuotasPlansResponseBodyDataPlanListQuotaBillingPolicy : TeaModel {
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
                        /// The ID of the order.
                        /// </summary>
                        [NameInMap("orderId")]
                        [Validation(Required=false)]
                        public string OrderId { get; set; }

                    }

                    /// <summary>
                    /// The ID of the cluster.
                    /// </summary>
                    [NameInMap("cluster")]
                    [Validation(Required=false)]
                    public string Cluster { get; set; }

                    /// <summary>
                    /// The time when the quota plan was created.
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
                    /// The ID of the quota.
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
                    /// The ID of the region.
                    /// </summary>
                    [NameInMap("regionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// The information of the scheduling plan.
                    /// </summary>
                    [NameInMap("scheduleInfo")]
                    [Validation(Required=false)]
                    public ListQuotasPlansResponseBodyDataPlanListQuotaScheduleInfo ScheduleInfo { get; set; }
                    public class ListQuotasPlansResponseBodyDataPlanListQuotaScheduleInfo : TeaModel {
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
                        /// If the quota plan that immediately takes effect is different from the current quota plan, this parameter is not empty.
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

                    }

                    /// <summary>
                    /// The status of the resource.
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The information of the level-2 quota.
                    /// </summary>
                    [NameInMap("subQuotaInfoList")]
                    [Validation(Required=false)]
                    public List<ListQuotasPlansResponseBodyDataPlanListQuotaSubQuotaInfoList> SubQuotaInfoList { get; set; }
                    public class ListQuotasPlansResponseBodyDataPlanListQuotaSubQuotaInfoList : TeaModel {
                        /// <summary>
                        /// The information of the order.
                        /// </summary>
                        [NameInMap("billingPolicy")]
                        [Validation(Required=false)]
                        public ListQuotasPlansResponseBodyDataPlanListQuotaSubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                        public class ListQuotasPlansResponseBodyDataPlanListQuotaSubQuotaInfoListBillingPolicy : TeaModel {
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
                            /// The ID of the order.
                            /// </summary>
                            [NameInMap("orderId")]
                            [Validation(Required=false)]
                            public string OrderId { get; set; }

                        }

                        /// <summary>
                        /// The ID of the cluster.
                        /// </summary>
                        [NameInMap("cluster")]
                        [Validation(Required=false)]
                        public string Cluster { get; set; }

                        /// <summary>
                        /// The time when the quota plan was created.
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
                        /// The ID of the region.
                        /// </summary>
                        [NameInMap("regionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// The information of the scheduling plan.
                        /// </summary>
                        [NameInMap("scheduleInfo")]
                        [Validation(Required=false)]
                        public ListQuotasPlansResponseBodyDataPlanListQuotaSubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                        public class ListQuotasPlansResponseBodyDataPlanListQuotaSubQuotaInfoListScheduleInfo : TeaModel {
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
                            /// If the quota plan that immediately takes effect is different from the current quota plan, this parameter is not empty.
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

                        }

                        /// <summary>
                        /// The status of the resource.
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
                        /// The ID of the tenant.
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
                    /// The ID of the tenant.
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

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
