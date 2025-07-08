// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsSaasTaskDetailNewResponseBody : TeaModel {
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

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

        [NameInMap("PhoneList")]
        [Validation(Required=false)]
        public QuerySmsSaasTaskDetailNewResponseBodyPhoneList PhoneList { get; set; }
        public class QuerySmsSaasTaskDetailNewResponseBodyPhoneList : TeaModel {
            [NameInMap("phoneNum")]
            [Validation(Required=false)]
            public List<string> PhoneNum { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SaasBaseCommParam")]
        [Validation(Required=false)]
        public QuerySmsSaasTaskDetailNewResponseBodySaasBaseCommParam SaasBaseCommParam { get; set; }
        public class QuerySmsSaasTaskDetailNewResponseBodySaasBaseCommParam : TeaModel {
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public long? AliyunUid { get; set; }

            [NameInMap("BillCount")]
            [Validation(Required=false)]
            public int? BillCount { get; set; }

            [NameInMap("ByteCount")]
            [Validation(Required=false)]
            public int? ByteCount { get; set; }

            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            [NameInMap("CustId")]
            [Validation(Required=false)]
            public long? CustId { get; set; }

            [NameInMap("CycleNum")]
            [Validation(Required=false)]
            public int? CycleNum { get; set; }

            [NameInMap("ParamList")]
            [Validation(Required=false)]
            public QuerySmsSaasTaskDetailNewResponseBodySaasBaseCommParamParamList ParamList { get; set; }
            public class QuerySmsSaasTaskDetailNewResponseBodySaasBaseCommParamParamList : TeaModel {
                [NameInMap("Param")]
                [Validation(Required=false)]
                public List<string> Param { get; set; }

            }

            [NameInMap("PartnerId")]
            [Validation(Required=false)]
            public long? PartnerId { get; set; }

            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            [NameInMap("SmsContent")]
            [Validation(Required=false)]
            public string SmsContent { get; set; }

            [NameInMap("SmsTemplateCode")]
            [Validation(Required=false)]
            public string SmsTemplateCode { get; set; }

            [NameInMap("TaskErrorCase")]
            [Validation(Required=false)]
            public string TaskErrorCase { get; set; }

            [NameInMap("TaskErrorSuggestion")]
            [Validation(Required=false)]
            public string TaskErrorSuggestion { get; set; }

        }

        [NameInMap("SaasFileUrl")]
        [Validation(Required=false)]
        public string SaasFileUrl { get; set; }

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
