// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetQuotaResponseBody : TeaModel {
        [NameInMap("billingPolicy")]
        [Validation(Required=false)]
        public GetQuotaResponseBodyBillingPolicy BillingPolicy { get; set; }
        public class GetQuotaResponseBodyBillingPolicy : TeaModel {
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

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetQuotaResponseBodyData Data { get; set; }
        public class GetQuotaResponseBodyData : TeaModel {
            [NameInMap("billingPolicy")]
            [Validation(Required=false)]
            public GetQuotaResponseBodyDataBillingPolicy BillingPolicy { get; set; }
            public class GetQuotaResponseBodyDataBillingPolicy : TeaModel {
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

            [NameInMap("saleTag")]
            [Validation(Required=false)]
            public GetQuotaResponseBodyDataSaleTag SaleTag { get; set; }
            public class GetQuotaResponseBodyDataSaleTag : TeaModel {
                [NameInMap("resourceIds")]
                [Validation(Required=false)]
                public List<string> ResourceIds { get; set; }

                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            [NameInMap("scheduleInfo")]
            [Validation(Required=false)]
            public GetQuotaResponseBodyDataScheduleInfo ScheduleInfo { get; set; }
            public class GetQuotaResponseBodyDataScheduleInfo : TeaModel {
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

                [NameInMap("timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("subQuotaInfoList")]
            [Validation(Required=false)]
            public List<GetQuotaResponseBodyDataSubQuotaInfoList> SubQuotaInfoList { get; set; }
            public class GetQuotaResponseBodyDataSubQuotaInfoList : TeaModel {
                [NameInMap("billingPolicy")]
                [Validation(Required=false)]
                public GetQuotaResponseBodyDataSubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                public class GetQuotaResponseBodyDataSubQuotaInfoListBillingPolicy : TeaModel {
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

                [NameInMap("saleTag")]
                [Validation(Required=false)]
                public GetQuotaResponseBodyDataSubQuotaInfoListSaleTag SaleTag { get; set; }
                public class GetQuotaResponseBodyDataSubQuotaInfoListSaleTag : TeaModel {
                    [NameInMap("resourceIds")]
                    [Validation(Required=false)]
                    public List<string> ResourceIds { get; set; }

                    [NameInMap("resourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                [NameInMap("scheduleInfo")]
                [Validation(Required=false)]
                public GetQuotaResponseBodyDataSubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                public class GetQuotaResponseBodyDataSubQuotaInfoListScheduleInfo : TeaModel {
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

                    [NameInMap("timezone")]
                    [Validation(Required=false)]
                    public string Timezone { get; set; }

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

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("saleTag")]
        [Validation(Required=false)]
        public GetQuotaResponseBodySaleTag SaleTag { get; set; }
        public class GetQuotaResponseBodySaleTag : TeaModel {
            [NameInMap("resourceIds")]
            [Validation(Required=false)]
            public List<string> ResourceIds { get; set; }

            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("scheduleInfo")]
        [Validation(Required=false)]
        public GetQuotaResponseBodyScheduleInfo ScheduleInfo { get; set; }
        public class GetQuotaResponseBodyScheduleInfo : TeaModel {
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

            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

        }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("subQuotaInfoList")]
        [Validation(Required=false)]
        public List<GetQuotaResponseBodySubQuotaInfoList> SubQuotaInfoList { get; set; }
        public class GetQuotaResponseBodySubQuotaInfoList : TeaModel {
            [NameInMap("billingPolicy")]
            [Validation(Required=false)]
            public GetQuotaResponseBodySubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
            public class GetQuotaResponseBodySubQuotaInfoListBillingPolicy : TeaModel {
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

            [NameInMap("saleTag")]
            [Validation(Required=false)]
            public GetQuotaResponseBodySubQuotaInfoListSaleTag SaleTag { get; set; }
            public class GetQuotaResponseBodySubQuotaInfoListSaleTag : TeaModel {
                [NameInMap("resourceIds")]
                [Validation(Required=false)]
                public List<string> ResourceIds { get; set; }

                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            [NameInMap("scheduleInfo")]
            [Validation(Required=false)]
            public GetQuotaResponseBodySubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
            public class GetQuotaResponseBodySubQuotaInfoListScheduleInfo : TeaModel {
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

                [NameInMap("timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

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
