// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListQuotasResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListQuotasResponseBodyData Data { get; set; }
        public class ListQuotasResponseBodyData : TeaModel {
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            [NameInMap("maxItem")]
            [Validation(Required=false)]
            public long? MaxItem { get; set; }

            [NameInMap("quotaInfoList")]
            [Validation(Required=false)]
            public List<ListQuotasResponseBodyDataQuotaInfoList> QuotaInfoList { get; set; }
            public class ListQuotasResponseBodyDataQuotaInfoList : TeaModel {
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListQuotasResponseBodyDataQuotaInfoListTags> Tags { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListTags : TeaModel {
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                [NameInMap("billingPolicy")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyDataQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListBillingPolicy : TeaModel {
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
                public ListQuotasResponseBodyDataQuotaInfoListSaleTag SaleTag { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListSaleTag : TeaModel {
                    [NameInMap("resourceIds")]
                    [Validation(Required=false)]
                    public List<string> ResourceIds { get; set; }

                    [NameInMap("resourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                [NameInMap("scheduleInfo")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyDataQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListScheduleInfo : TeaModel {
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
                public List<ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoList> SubQuotaInfoList { get; set; }
                public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoList : TeaModel {
                    [NameInMap("billingPolicy")]
                    [Validation(Required=false)]
                    public ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                    public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListBillingPolicy : TeaModel {
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
                    public ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListSaleTag SaleTag { get; set; }
                    public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListSaleTag : TeaModel {
                        [NameInMap("resourceIds")]
                        [Validation(Required=false)]
                        public List<string> ResourceIds { get; set; }

                        [NameInMap("resourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                    }

                    [NameInMap("scheduleInfo")]
                    [Validation(Required=false)]
                    public ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                    public class ListQuotasResponseBodyDataQuotaInfoListSubQuotaInfoListScheduleInfo : TeaModel {
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

        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("maxItem")]
        [Validation(Required=false)]
        public long? MaxItem { get; set; }

        [NameInMap("quotaInfoList")]
        [Validation(Required=false)]
        public List<ListQuotasResponseBodyQuotaInfoList> QuotaInfoList { get; set; }
        public class ListQuotasResponseBodyQuotaInfoList : TeaModel {
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListQuotasResponseBodyQuotaInfoListTags> Tags { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListTags : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            [NameInMap("billingPolicy")]
            [Validation(Required=false)]
            public ListQuotasResponseBodyQuotaInfoListBillingPolicy BillingPolicy { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListBillingPolicy : TeaModel {
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
            public ListQuotasResponseBodyQuotaInfoListSaleTag SaleTag { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListSaleTag : TeaModel {
                [NameInMap("resourceIds")]
                [Validation(Required=false)]
                public List<string> ResourceIds { get; set; }

                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            [NameInMap("scheduleInfo")]
            [Validation(Required=false)]
            public ListQuotasResponseBodyQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListScheduleInfo : TeaModel {
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
            public List<ListQuotasResponseBodyQuotaInfoListSubQuotaInfoList> SubQuotaInfoList { get; set; }
            public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoList : TeaModel {
                [NameInMap("billingPolicy")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListBillingPolicy : TeaModel {
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
                public ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListSaleTag SaleTag { get; set; }
                public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListSaleTag : TeaModel {
                    [NameInMap("resourceIds")]
                    [Validation(Required=false)]
                    public List<string> ResourceIds { get; set; }

                    [NameInMap("resourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                [NameInMap("scheduleInfo")]
                [Validation(Required=false)]
                public ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                public class ListQuotasResponseBodyQuotaInfoListSubQuotaInfoListScheduleInfo : TeaModel {
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

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
