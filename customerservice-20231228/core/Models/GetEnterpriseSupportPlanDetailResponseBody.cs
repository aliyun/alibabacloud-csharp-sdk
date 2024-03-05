// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CustomerService20231228.Models
{
    public class GetEnterpriseSupportPlanDetailResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetEnterpriseSupportPlanDetailResponseBodyData Data { get; set; }
        public class GetEnterpriseSupportPlanDetailResponseBodyData : TeaModel {
            [NameInMap("canApplyFreeOrder")]
            [Validation(Required=false)]
            public bool? CanApplyFreeOrder { get; set; }

            [NameInMap("customerId")]
            [Validation(Required=false)]
            public long? CustomerId { get; set; }

            [NameInMap("dingGroups")]
            [Validation(Required=false)]
            public List<GetEnterpriseSupportPlanDetailResponseBodyDataDingGroups> DingGroups { get; set; }
            public class GetEnterpriseSupportPlanDetailResponseBodyDataDingGroups : TeaModel {
                [NameInMap("mainDingDepartmentId")]
                [Validation(Required=false)]
                public string MainDingDepartmentId { get; set; }

                [NameInMap("mainDingGroupId")]
                [Validation(Required=false)]
                public string MainDingGroupId { get; set; }

                [NameInMap("mainDingGroupName")]
                [Validation(Required=false)]
                public string MainDingGroupName { get; set; }

                [NameInMap("subDingDepartmentId")]
                [Validation(Required=false)]
                public string SubDingDepartmentId { get; set; }

                [NameInMap("subDingGroupId")]
                [Validation(Required=false)]
                public string SubDingGroupId { get; set; }

                [NameInMap("subDingGroupName")]
                [Validation(Required=false)]
                public string SubDingGroupName { get; set; }

            }

            [NameInMap("docs")]
            [Validation(Required=false)]
            public List<GetEnterpriseSupportPlanDetailResponseBodyDataDocs> Docs { get; set; }
            public class GetEnterpriseSupportPlanDetailResponseBodyDataDocs : TeaModel {
                [NameInMap("docId")]
                [Validation(Required=false)]
                public long? DocId { get; set; }

                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("freeOrderApplyCode")]
                [Validation(Required=false)]
                public string FreeOrderApplyCode { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("orderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("uploadTime")]
                [Validation(Required=false)]
                public string UploadTime { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("firstPayTime")]
            [Validation(Required=false)]
            public string FirstPayTime { get; set; }

            [NameInMap("freeOrderApplyCode")]
            [Validation(Required=false)]
            public string FreeOrderApplyCode { get; set; }

            [NameInMap("freeOrderApplyId")]
            [Validation(Required=false)]
            public long? FreeOrderApplyId { get; set; }

            [NameInMap("freeOrderApplyTime")]
            [Validation(Required=false)]
            public string FreeOrderApplyTime { get; set; }

            [NameInMap("freeOrderApprovedTime")]
            [Validation(Required=false)]
            public string FreeOrderApprovedTime { get; set; }

            [NameInMap("freeOrderExpectStartTime")]
            [Validation(Required=false)]
            public string FreeOrderExpectStartTime { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<GetEnterpriseSupportPlanDetailResponseBodyDataNodes> Nodes { get; set; }
            public class GetEnterpriseSupportPlanDetailResponseBodyDataNodes : TeaModel {
                [NameInMap("docNode")]
                [Validation(Required=false)]
                public GetEnterpriseSupportPlanDetailResponseBodyDataNodesDocNode DocNode { get; set; }
                public class GetEnterpriseSupportPlanDetailResponseBodyDataNodesDocNode : TeaModel {
                    [NameInMap("docId")]
                    [Validation(Required=false)]
                    public long? DocId { get; set; }

                    [NameInMap("docName")]
                    [Validation(Required=false)]
                    public string DocName { get; set; }

                    [NameInMap("docSubmitTime")]
                    [Validation(Required=false)]
                    public string DocSubmitTime { get; set; }

                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("freeOrderApplyCode")]
                    [Validation(Required=false)]
                    public string FreeOrderApplyCode { get; set; }

                    [NameInMap("orderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                }

                [NameInMap("finishNode")]
                [Validation(Required=false)]
                public GetEnterpriseSupportPlanDetailResponseBodyDataNodesFinishNode FinishNode { get; set; }
                public class GetEnterpriseSupportPlanDetailResponseBodyDataNodesFinishNode : TeaModel {
                    [NameInMap("finishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }

                }

                [NameInMap("freeOrderAuditNode")]
                [Validation(Required=false)]
                public GetEnterpriseSupportPlanDetailResponseBodyDataNodesFreeOrderAuditNode FreeOrderAuditNode { get; set; }
                public class GetEnterpriseSupportPlanDetailResponseBodyDataNodesFreeOrderAuditNode : TeaModel {
                    [NameInMap("auditTime")]
                    [Validation(Required=false)]
                    public string AuditTime { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("statusName")]
                    [Validation(Required=false)]
                    public string StatusName { get; set; }

                }

                [NameInMap("freeOrderNode")]
                [Validation(Required=false)]
                public GetEnterpriseSupportPlanDetailResponseBodyDataNodesFreeOrderNode FreeOrderNode { get; set; }
                public class GetEnterpriseSupportPlanDetailResponseBodyDataNodesFreeOrderNode : TeaModel {
                    [NameInMap("applyTime")]
                    [Validation(Required=false)]
                    public string ApplyTime { get; set; }

                    [NameInMap("uid")]
                    [Validation(Required=false)]
                    public long? Uid { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("orderDate")]
                [Validation(Required=false)]
                public long? OrderDate { get; set; }

                [NameInMap("orderNode")]
                [Validation(Required=false)]
                public GetEnterpriseSupportPlanDetailResponseBodyDataNodesOrderNode OrderNode { get; set; }
                public class GetEnterpriseSupportPlanDetailResponseBodyDataNodesOrderNode : TeaModel {
                    [NameInMap("payTime")]
                    [Validation(Required=false)]
                    public string PayTime { get; set; }

                    [NameInMap("uid")]
                    [Validation(Required=false)]
                    public long? Uid { get; set; }

                }

                [NameInMap("serviceImplementation")]
                [Validation(Required=false)]
                public GetEnterpriseSupportPlanDetailResponseBodyDataNodesServiceImplementation ServiceImplementation { get; set; }
                public class GetEnterpriseSupportPlanDetailResponseBodyDataNodesServiceImplementation : TeaModel {
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("orderIds")]
            [Validation(Required=false)]
            public List<long?> OrderIds { get; set; }

            [NameInMap("serviceItems")]
            [Validation(Required=false)]
            public List<GetEnterpriseSupportPlanDetailResponseBodyDataServiceItems> ServiceItems { get; set; }
            public class GetEnterpriseSupportPlanDetailResponseBodyDataServiceItems : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("operateList")]
                [Validation(Required=false)]
                public List<GetEnterpriseSupportPlanDetailResponseBodyDataServiceItemsOperateList> OperateList { get; set; }
                public class GetEnterpriseSupportPlanDetailResponseBodyDataServiceItemsOperateList : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("name1")]
                    [Validation(Required=false)]
                    public string Name1 { get; set; }

                }

            }

            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("serviceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

            [NameInMap("serviceStatusName")]
            [Validation(Required=false)]
            public string ServiceStatusName { get; set; }

            [NameInMap("serviceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            [NameInMap("sortTime")]
            [Validation(Required=false)]
            public string SortTime { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("taskNum")]
            [Validation(Required=false)]
            public long? TaskNum { get; set; }

        }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
