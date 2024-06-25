// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetSmsTemplateResponseBody : TeaModel {
        [NameInMap("ApplyScene")]
        [Validation(Required=false)]
        public string ApplyScene { get; set; }

        [NameInMap("AuditInfo")]
        [Validation(Required=false)]
        public GetSmsTemplateResponseBodyAuditInfo AuditInfo { get; set; }
        public class GetSmsTemplateResponseBodyAuditInfo : TeaModel {
            [NameInMap("AuditDate")]
            [Validation(Required=false)]
            public string AuditDate { get; set; }

            [NameInMap("RejectInfo")]
            [Validation(Required=false)]
            public string RejectInfo { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CreateDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        [NameInMap("FileUrlList")]
        [Validation(Required=false)]
        public GetSmsTemplateResponseBodyFileUrlList FileUrlList { get; set; }
        public class GetSmsTemplateResponseBodyFileUrlList : TeaModel {
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public List<string> FileUrl { get; set; }

        }

        [NameInMap("IntlType")]
        [Validation(Required=false)]
        public int? IntlType { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("MoreDataFileUrlList")]
        [Validation(Required=false)]
        public GetSmsTemplateResponseBodyMoreDataFileUrlList MoreDataFileUrlList { get; set; }
        public class GetSmsTemplateResponseBodyMoreDataFileUrlList : TeaModel {
            [NameInMap("MoreDataFileUrl")]
            [Validation(Required=false)]
            public List<string> MoreDataFileUrl { get; set; }

        }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("RelatedSignName")]
        [Validation(Required=false)]
        public string RelatedSignName { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TemplateStatus")]
        [Validation(Required=false)]
        public string TemplateStatus { get; set; }

        [NameInMap("TemplateTag")]
        [Validation(Required=false)]
        public int? TemplateTag { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        [NameInMap("VariableAttribute")]
        [Validation(Required=false)]
        public string VariableAttribute { get; set; }

    }

}
