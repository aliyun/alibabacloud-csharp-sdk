// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListQuotasPlansResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListQuotasPlansResponseBodyData Data { get; set; }
        public class ListQuotasPlansResponseBodyData : TeaModel {
            [NameInMap("planList")]
            [Validation(Required=false)]
            public List<ListQuotasPlansResponseBodyDataPlanList> PlanList { get; set; }
            public class ListQuotasPlansResponseBodyDataPlanList : TeaModel {
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("quota")]
                [Validation(Required=false)]
                public ListQuotasPlansResponseBodyDataPlanListQuota Quota { get; set; }
                public class ListQuotasPlansResponseBodyDataPlanListQuota : TeaModel {
                    [NameInMap("billingPolicy")]
                    [Validation(Required=false)]
                    public ListQuotasPlansResponseBodyDataPlanListQuotaBillingPolicy BillingPolicy { get; set; }
                    public class ListQuotasPlansResponseBodyDataPlanListQuotaBillingPolicy : TeaModel {
                        [NameInMap("billingMethod")]
                        [Validation(Required=false)]
                        public string BillingMethod { get; set; }

                        [NameInMap("odpsSpecCode")]
                        [Validation(Required=false)]
                        public string OdpsSpecCode { get; set; }

                        [NameInMap("orderId")]
                        [Validation(Required=false)]
                        public string OrderId { get; set; }

                    }

                    [NameInMap("cluster")]
                    [Validation(Required=false)]
                    public string Cluster { get; set; }

                    [NameInMap("createTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("creatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("nickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                    [NameInMap("parameter")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Parameter { get; set; }

                    [NameInMap("parentId")]
                    [Validation(Required=false)]
                    public string ParentId { get; set; }

                    [NameInMap("regionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("scheduleInfo")]
                    [Validation(Required=false)]
                    public ListQuotasPlansResponseBodyDataPlanListQuotaScheduleInfo ScheduleInfo { get; set; }
                    public class ListQuotasPlansResponseBodyDataPlanListQuotaScheduleInfo : TeaModel {
                        [NameInMap("currPlan")]
                        [Validation(Required=false)]
                        public string CurrPlan { get; set; }

                        [NameInMap("currTime")]
                        [Validation(Required=false)]
                        public string CurrTime { get; set; }

                        [NameInMap("nextPlan")]
                        [Validation(Required=false)]
                        public string NextPlan { get; set; }

                        [NameInMap("nextTime")]
                        [Validation(Required=false)]
                        public string NextTime { get; set; }

                        [NameInMap("oncePlan")]
                        [Validation(Required=false)]
                        public string OncePlan { get; set; }

                        [NameInMap("onceTime")]
                        [Validation(Required=false)]
                        public string OnceTime { get; set; }

                        [NameInMap("operatorName")]
                        [Validation(Required=false)]
                        public string OperatorName { get; set; }

                    }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("subQuotaInfoList")]
                    [Validation(Required=false)]
                    public List<ListQuotasPlansResponseBodyDataPlanListQuotaSubQuotaInfoList> SubQuotaInfoList { get; set; }
                    public class ListQuotasPlansResponseBodyDataPlanListQuotaSubQuotaInfoList : TeaModel {
                        [NameInMap("billingPolicy")]
                        [Validation(Required=false)]
                        public ListQuotasPlansResponseBodyDataPlanListQuotaSubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                        public class ListQuotasPlansResponseBodyDataPlanListQuotaSubQuotaInfoListBillingPolicy : TeaModel {
                            [NameInMap("billingMethod")]
                            [Validation(Required=false)]
                            public string BillingMethod { get; set; }

                            [NameInMap("odpsSpecCode")]
                            [Validation(Required=false)]
                            public string OdpsSpecCode { get; set; }

                            [NameInMap("orderId")]
                            [Validation(Required=false)]
                            public string OrderId { get; set; }

                        }

                        [NameInMap("cluster")]
                        [Validation(Required=false)]
                        public string Cluster { get; set; }

                        [NameInMap("createTime")]
                        [Validation(Required=false)]
                        public long? CreateTime { get; set; }

                        [NameInMap("creatorId")]
                        [Validation(Required=false)]
                        public string CreatorId { get; set; }

                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("nickName")]
                        [Validation(Required=false)]
                        public string NickName { get; set; }

                        [NameInMap("parameter")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Parameter { get; set; }

                        [NameInMap("parentId")]
                        [Validation(Required=false)]
                        public string ParentId { get; set; }

                        [NameInMap("regionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        [NameInMap("scheduleInfo")]
                        [Validation(Required=false)]
                        public ListQuotasPlansResponseBodyDataPlanListQuotaSubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                        public class ListQuotasPlansResponseBodyDataPlanListQuotaSubQuotaInfoListScheduleInfo : TeaModel {
                            [NameInMap("currPlan")]
                            [Validation(Required=false)]
                            public string CurrPlan { get; set; }

                            [NameInMap("currTime")]
                            [Validation(Required=false)]
                            public string CurrTime { get; set; }

                            [NameInMap("nextPlan")]
                            [Validation(Required=false)]
                            public string NextPlan { get; set; }

                            [NameInMap("nextTime")]
                            [Validation(Required=false)]
                            public string NextTime { get; set; }

                            [NameInMap("oncePlan")]
                            [Validation(Required=false)]
                            public string OncePlan { get; set; }

                            [NameInMap("onceTime")]
                            [Validation(Required=false)]
                            public string OnceTime { get; set; }

                            [NameInMap("operatorName")]
                            [Validation(Required=false)]
                            public string OperatorName { get; set; }

                        }

                        [NameInMap("status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                        [NameInMap("tenantId")]
                        [Validation(Required=false)]
                        public string TenantId { get; set; }

                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                    }

                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    [NameInMap("tenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
