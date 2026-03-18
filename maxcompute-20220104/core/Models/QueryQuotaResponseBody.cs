// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class QueryQuotaResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryQuotaResponseBodyData Data { get; set; }
        public class QueryQuotaResponseBodyData : TeaModel {
            [NameInMap("billingPolicy")]
            [Validation(Required=false)]
            public QueryQuotaResponseBodyDataBillingPolicy BillingPolicy { get; set; }
            public class QueryQuotaResponseBodyDataBillingPolicy : TeaModel {
                [NameInMap("billingMethod")]
                [Validation(Required=false)]
                public string BillingMethod { get; set; }

                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

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

            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

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
            public QueryQuotaResponseBodyDataSaleTag SaleTag { get; set; }
            public class QueryQuotaResponseBodyDataSaleTag : TeaModel {
                [NameInMap("resourceIds")]
                [Validation(Required=false)]
                public List<string> ResourceIds { get; set; }

                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            [NameInMap("scheduleInfo")]
            [Validation(Required=false)]
            public QueryQuotaResponseBodyDataScheduleInfo ScheduleInfo { get; set; }
            public class QueryQuotaResponseBodyDataScheduleInfo : TeaModel {
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
            public List<QueryQuotaResponseBodyDataSubQuotaInfoList> SubQuotaInfoList { get; set; }
            public class QueryQuotaResponseBodyDataSubQuotaInfoList : TeaModel {
                [NameInMap("billingPolicy")]
                [Validation(Required=false)]
                public QueryQuotaResponseBodyDataSubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                public class QueryQuotaResponseBodyDataSubQuotaInfoListBillingPolicy : TeaModel {
                    [NameInMap("billingMethod")]
                    [Validation(Required=false)]
                    public string BillingMethod { get; set; }

                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

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

                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

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
                public QueryQuotaResponseBodyDataSubQuotaInfoListSaleTag SaleTag { get; set; }
                public class QueryQuotaResponseBodyDataSubQuotaInfoListSaleTag : TeaModel {
                    [NameInMap("resourceIds")]
                    [Validation(Required=false)]
                    public List<string> ResourceIds { get; set; }

                    [NameInMap("resourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                [NameInMap("scheduleInfo")]
                [Validation(Required=false)]
                public QueryQuotaResponseBodyDataSubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                public class QueryQuotaResponseBodyDataSubQuotaInfoListScheduleInfo : TeaModel {
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

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
