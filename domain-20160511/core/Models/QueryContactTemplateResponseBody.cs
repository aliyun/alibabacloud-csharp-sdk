// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20160511.Models
{
    public class QueryContactTemplateResponseBody : TeaModel {
        [NameInMap("ContactTemplates")]
        [Validation(Required=false)]
        public QueryContactTemplateResponseBodyContactTemplates ContactTemplates { get; set; }
        public class QueryContactTemplateResponseBodyContactTemplates : TeaModel {
            [NameInMap("ContactTemplate")]
            [Validation(Required=false)]
            public List<QueryContactTemplateResponseBodyContactTemplatesContactTemplate> ContactTemplate { get; set; }
            public class QueryContactTemplateResponseBodyContactTemplatesContactTemplate : TeaModel {
                [NameInMap("AuditStatus")]
                [Validation(Required=false)]
                public string AuditStatus { get; set; }

                [NameInMap("CCity")]
                [Validation(Required=false)]
                public string CCity { get; set; }

                [NameInMap("CCompany")]
                [Validation(Required=false)]
                public string CCompany { get; set; }

                [NameInMap("CCountry")]
                [Validation(Required=false)]
                public string CCountry { get; set; }

                [NameInMap("CName")]
                [Validation(Required=false)]
                public string CName { get; set; }

                [NameInMap("CProvince")]
                [Validation(Required=false)]
                public string CProvince { get; set; }

                [NameInMap("CVenu")]
                [Validation(Required=false)]
                public string CVenu { get; set; }

                [NameInMap("ContactTemplateId")]
                [Validation(Required=false)]
                public long? ContactTemplateId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DefaultTemplate")]
                [Validation(Required=false)]
                public bool? DefaultTemplate { get; set; }

                [NameInMap("ECity")]
                [Validation(Required=false)]
                public string ECity { get; set; }

                [NameInMap("ECompany")]
                [Validation(Required=false)]
                public string ECompany { get; set; }

                [NameInMap("EName")]
                [Validation(Required=false)]
                public string EName { get; set; }

                [NameInMap("EProvince")]
                [Validation(Required=false)]
                public string EProvince { get; set; }

                [NameInMap("EVenu")]
                [Validation(Required=false)]
                public string EVenu { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("EmailVerificationStatus")]
                [Validation(Required=false)]
                public int? EmailVerificationStatus { get; set; }

                [NameInMap("PostalCode")]
                [Validation(Required=false)]
                public string PostalCode { get; set; }

                [NameInMap("RegType")]
                [Validation(Required=false)]
                public string RegType { get; set; }

                [NameInMap("TelArea")]
                [Validation(Required=false)]
                public string TelArea { get; set; }

                [NameInMap("TelExt")]
                [Validation(Required=false)]
                public string TelExt { get; set; }

                [NameInMap("TelMain")]
                [Validation(Required=false)]
                public string TelMain { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
