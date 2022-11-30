// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class ListVoiceTtsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListVoiceTtsResponseBodyList> List { get; set; }
        public class ListVoiceTtsResponseBodyList : TeaModel {
            [NameInMap("AuditBy")]
            [Validation(Required=false)]
            public string AuditBy { get; set; }

            [NameInMap("AuditRemark")]
            [Validation(Required=false)]
            public string AuditRemark { get; set; }

            [NameInMap("AuditTs")]
            [Validation(Required=false)]
            public string AuditTs { get; set; }

            [NameInMap("CommitTs")]
            [Validation(Required=false)]
            public string CommitTs { get; set; }

            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("QualificationId")]
            [Validation(Required=false)]
            public string QualificationId { get; set; }

            [NameInMap("Speed")]
            [Validation(Required=false)]
            public int? Speed { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("TemplateText")]
            [Validation(Required=false)]
            public string TemplateText { get; set; }

            [NameInMap("UpdateTs")]
            [Validation(Required=false)]
            public string UpdateTs { get; set; }

            [NameInMap("UserUuid")]
            [Validation(Required=false)]
            public string UserUuid { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
