// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsSaasTaskListNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public QuerySmsSaasTaskListNewResponseBodyList List { get; set; }
        public class QuerySmsSaasTaskListNewResponseBodyList : TeaModel {
            [NameInMap("FcSaasTaskDTO")]
            [Validation(Required=false)]
            public List<QuerySmsSaasTaskListNewResponseBodyListFcSaasTaskDTO> FcSaasTaskDTO { get; set; }
            public class QuerySmsSaasTaskListNewResponseBodyListFcSaasTaskDTO : TeaModel {
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("CommParams")]
                [Validation(Required=false)]
                public QuerySmsSaasTaskListNewResponseBodyListFcSaasTaskDTOCommParams CommParams { get; set; }
                public class QuerySmsSaasTaskListNewResponseBodyListFcSaasTaskDTOCommParams : TeaModel {
                    [NameInMap("AliyunUid")]
                    [Validation(Required=false)]
                    public long? AliyunUid { get; set; }

                    [NameInMap("CustId")]
                    [Validation(Required=false)]
                    public long? CustId { get; set; }

                    [NameInMap("CycleNum")]
                    [Validation(Required=false)]
                    public int? CycleNum { get; set; }

                    [NameInMap("PartnerId")]
                    [Validation(Required=false)]
                    public long? PartnerId { get; set; }

                }

                [NameInMap("DetailDownloadUrl")]
                [Validation(Required=false)]
                public string DetailDownloadUrl { get; set; }

                [NameInMap("DetailDownloadUrlForSuccess")]
                [Validation(Required=false)]
                public string DetailDownloadUrlForSuccess { get; set; }

                [NameInMap("ExtParams")]
                [Validation(Required=false)]
                public string ExtParams { get; set; }

                [NameInMap("FailCount")]
                [Validation(Required=false)]
                public int? FailCount { get; set; }

                [NameInMap("FireTime")]
                [Validation(Required=false)]
                public string FireTime { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("IsDeleted")]
                [Validation(Required=false)]
                public bool? IsDeleted { get; set; }

                [NameInMap("IsPermitOrder")]
                [Validation(Required=false)]
                public bool? IsPermitOrder { get; set; }

                [NameInMap("IsPermitOrderForSuccess")]
                [Validation(Required=false)]
                public bool? IsPermitOrderForSuccess { get; set; }

                [NameInMap("OssFilePath")]
                [Validation(Required=false)]
                public string OssFilePath { get; set; }

                [NameInMap("ScheduleType")]
                [Validation(Required=false)]
                public string ScheduleType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SuccessCount")]
                [Validation(Required=false)]
                public int? SuccessCount { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                [NameInMap("TaskInstanceId")]
                [Validation(Required=false)]
                public long? TaskInstanceId { get; set; }

                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
