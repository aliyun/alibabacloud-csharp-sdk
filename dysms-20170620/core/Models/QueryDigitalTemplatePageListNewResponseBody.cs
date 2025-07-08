// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryDigitalTemplatePageListNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public QueryDigitalTemplatePageListNewResponseBodyList List { get; set; }
        public class QueryDigitalTemplatePageListNewResponseBodyList : TeaModel {
            [NameInMap("SmsTemplate")]
            [Validation(Required=false)]
            public List<QueryDigitalTemplatePageListNewResponseBodyListSmsTemplate> SmsTemplate { get; set; }
            public class QueryDigitalTemplatePageListNewResponseBodyListSmsTemplate : TeaModel {
                [NameInMap("AuditInfo")]
                [Validation(Required=false)]
                public string AuditInfo { get; set; }

                [NameInMap("AuditRemarkInfo")]
                [Validation(Required=false)]
                public string AuditRemarkInfo { get; set; }

                [NameInMap("AuditState")]
                [Validation(Required=false)]
                public string AuditState { get; set; }

                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("ExpireDateStr")]
                [Validation(Required=false)]
                public string ExpireDateStr { get; set; }

                [NameInMap("GmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("IsAnyParam")]
                [Validation(Required=false)]
                public bool? IsAnyParam { get; set; }

                [NameInMap("IsDefaultTemplate")]
                [Validation(Required=false)]
                public bool? IsDefaultTemplate { get; set; }

                [NameInMap("IsRecently")]
                [Validation(Required=false)]
                public bool? IsRecently { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("PassErrType")]
                [Validation(Required=false)]
                public string PassErrType { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("SignType")]
                [Validation(Required=false)]
                public int? SignType { get; set; }

                [NameInMap("SmsContent")]
                [Validation(Required=false)]
                public string SmsContent { get; set; }

                [NameInMap("SupportVendor")]
                [Validation(Required=false)]
                public string SupportVendor { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public QueryDigitalTemplatePageListNewResponseBodyListSmsTemplateTags Tags { get; set; }
                public class QueryDigitalTemplatePageListNewResponseBodyListSmsTemplateTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<QueryDigitalTemplatePageListNewResponseBodyListSmsTemplateTagsTag> Tag { get; set; }
                    public class QueryDigitalTemplatePageListNewResponseBodyListSmsTemplateTagsTag : TeaModel {
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

                [NameInMap("TemplateContent")]
                [Validation(Required=false)]
                public string TemplateContent { get; set; }

                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                [NameInMap("TemplateRule")]
                [Validation(Required=false)]
                public string TemplateRule { get; set; }

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
