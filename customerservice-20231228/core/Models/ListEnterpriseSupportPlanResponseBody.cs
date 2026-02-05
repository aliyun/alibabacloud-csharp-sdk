// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CustomerService20231228.Models
{
    public class ListEnterpriseSupportPlanResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListEnterpriseSupportPlanResponseBodyData> Data { get; set; }
        public class ListEnterpriseSupportPlanResponseBodyData : TeaModel {
            [NameInMap("canApplyFreeOrder")]
            [Validation(Required=false)]
            public bool? CanApplyFreeOrder { get; set; }

            [NameInMap("customerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            [NameInMap("docs")]
            [Validation(Required=false)]
            public List<ListEnterpriseSupportPlanResponseBodyDataDocs> Docs { get; set; }
            public class ListEnterpriseSupportPlanResponseBodyDataDocs : TeaModel {
                [NameInMap("attachments")]
                [Validation(Required=false)]
                public List<ListEnterpriseSupportPlanResponseBodyDataDocsAttachments> Attachments { get; set; }
                public class ListEnterpriseSupportPlanResponseBodyDataDocsAttachments : TeaModel {
                    [NameInMap("docId")]
                    [Validation(Required=false)]
                    public long? DocId { get; set; }

                    [NameInMap("evaluated")]
                    [Validation(Required=false)]
                    public bool? Evaluated { get; set; }

                    [NameInMap("evaluationUrl")]
                    [Validation(Required=false)]
                    public string EvaluationUrl { get; set; }

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

                [NameInMap("docId")]
                [Validation(Required=false)]
                public long? DocId { get; set; }

                [NameInMap("evaluated")]
                [Validation(Required=false)]
                public bool? Evaluated { get; set; }

                [NameInMap("evaluationUrl")]
                [Validation(Required=false)]
                public string EvaluationUrl { get; set; }

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

            [NameInMap("gtspProjectId")]
            [Validation(Required=false)]
            public long? GtspProjectId { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<ListEnterpriseSupportPlanResponseBodyDataNodes> Nodes { get; set; }
            public class ListEnterpriseSupportPlanResponseBodyDataNodes : TeaModel {
                [NameInMap("docNode")]
                [Validation(Required=false)]
                public ListEnterpriseSupportPlanResponseBodyDataNodesDocNode DocNode { get; set; }
                public class ListEnterpriseSupportPlanResponseBodyDataNodesDocNode : TeaModel {
                    [NameInMap("attachments")]
                    [Validation(Required=false)]
                    public List<object> Attachments { get; set; }

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
                public ListEnterpriseSupportPlanResponseBodyDataNodesFinishNode FinishNode { get; set; }
                public class ListEnterpriseSupportPlanResponseBodyDataNodesFinishNode : TeaModel {
                    [NameInMap("finishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }

                }

                [NameInMap("freeOrderAuditNode")]
                [Validation(Required=false)]
                public ListEnterpriseSupportPlanResponseBodyDataNodesFreeOrderAuditNode FreeOrderAuditNode { get; set; }
                public class ListEnterpriseSupportPlanResponseBodyDataNodesFreeOrderAuditNode : TeaModel {
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
                public ListEnterpriseSupportPlanResponseBodyDataNodesFreeOrderNode FreeOrderNode { get; set; }
                public class ListEnterpriseSupportPlanResponseBodyDataNodesFreeOrderNode : TeaModel {
                    [NameInMap("applyTime")]
                    [Validation(Required=false)]
                    public string ApplyTime { get; set; }

                    [NameInMap("uid")]
                    [Validation(Required=false)]
                    public string Uid { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("orderDate")]
                [Validation(Required=false)]
                public long? OrderDate { get; set; }

                [NameInMap("orderNode")]
                [Validation(Required=false)]
                public ListEnterpriseSupportPlanResponseBodyDataNodesOrderNode OrderNode { get; set; }
                public class ListEnterpriseSupportPlanResponseBodyDataNodesOrderNode : TeaModel {
                    [NameInMap("payTime")]
                    [Validation(Required=false)]
                    public string PayTime { get; set; }

                    [NameInMap("uid")]
                    [Validation(Required=false)]
                    public string Uid { get; set; }

                }

                [NameInMap("serviceImplementation")]
                [Validation(Required=false)]
                public ListEnterpriseSupportPlanResponseBodyDataNodesServiceImplementation ServiceImplementation { get; set; }
                public class ListEnterpriseSupportPlanResponseBodyDataNodesServiceImplementation : TeaModel {
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

            [NameInMap("operateInfos")]
            [Validation(Required=false)]
            public List<ListEnterpriseSupportPlanResponseBodyDataOperateInfos> OperateInfos { get; set; }
            public class ListEnterpriseSupportPlanResponseBodyDataOperateInfos : TeaModel {
                [NameInMap("canClick")]
                [Validation(Required=false)]
                public bool? CanClick { get; set; }

                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("orderIds")]
            [Validation(Required=false)]
            public List<long?> OrderIds { get; set; }

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

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListEnterpriseSupportPlanResponseBodyDataTags> Tags { get; set; }
            public class ListEnterpriseSupportPlanResponseBodyDataTags : TeaModel {
                [NameInMap("extendInfos")]
                [Validation(Required=false)]
                public List<string> ExtendInfos { get; set; }

                [NameInMap("show")]
                [Validation(Required=false)]
                public bool? Show { get; set; }

                [NameInMap("tagCode")]
                [Validation(Required=false)]
                public string TagCode { get; set; }

                [NameInMap("tagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

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
