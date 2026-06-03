// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypns20170620.Models
{
    public class ListSmsTemplateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSmsTemplateResponseBodyData> Data { get; set; }
        public class ListSmsTemplateResponseBodyData : TeaModel {
            [NameInMap("AuditResult")]
            [Validation(Required=false)]
            public string AuditResult { get; set; }

            [NameInMap("BizUrl")]
            [Validation(Required=false)]
            public string BizUrl { get; set; }

            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public int? BusinessType { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public long? CreateDate { get; set; }

            [NameInMap("DefaultFlag")]
            [Validation(Required=false)]
            public bool? DefaultFlag { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("SmsTemplateCode")]
            [Validation(Required=false)]
            public string SmsTemplateCode { get; set; }

            [NameInMap("SmsTemplateContent")]
            [Validation(Required=false)]
            public string SmsTemplateContent { get; set; }

            [NameInMap("SmsTemplateName")]
            [Validation(Required=false)]
            public string SmsTemplateName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
