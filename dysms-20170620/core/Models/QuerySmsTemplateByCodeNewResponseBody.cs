// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsTemplateByCodeNewResponseBody : TeaModel {
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("ApplicationScene")]
        [Validation(Required=false)]
        public QuerySmsTemplateByCodeNewResponseBodyApplicationScene ApplicationScene { get; set; }
        public class QuerySmsTemplateByCodeNewResponseBodyApplicationScene : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("AuditInfo")]
        [Validation(Required=false)]
        public string AuditInfo { get; set; }

        [NameInMap("AuditRemarkInfo")]
        [Validation(Required=false)]
        public string AuditRemarkInfo { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public QuerySmsTemplateByCodeNewResponseBodyFileIds FileIds { get; set; }
        public class QuerySmsTemplateByCodeNewResponseBodyFileIds : TeaModel {
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public List<long?> FileId { get; set; }

        }

        [NameInMap("FileUrlList")]
        [Validation(Required=false)]
        public QuerySmsTemplateByCodeNewResponseBodyFileUrlList FileUrlList { get; set; }
        public class QuerySmsTemplateByCodeNewResponseBodyFileUrlList : TeaModel {
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public List<string> FileUrl { get; set; }

        }

        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        [NameInMap("GmtCreateStr")]
        [Validation(Required=false)]
        public string GmtCreateStr { get; set; }

        [NameInMap("IntlType")]
        [Validation(Required=false)]
        public int? IntlType { get; set; }

        [NameInMap("MoreDataFileIds")]
        [Validation(Required=false)]
        public QuerySmsTemplateByCodeNewResponseBodyMoreDataFileIds MoreDataFileIds { get; set; }
        public class QuerySmsTemplateByCodeNewResponseBodyMoreDataFileIds : TeaModel {
            [NameInMap("MoreDataFileId")]
            [Validation(Required=false)]
            public List<long?> MoreDataFileId { get; set; }

        }

        [NameInMap("MoreDataFileUrls")]
        [Validation(Required=false)]
        public QuerySmsTemplateByCodeNewResponseBodyMoreDataFileUrls MoreDataFileUrls { get; set; }
        public class QuerySmsTemplateByCodeNewResponseBodyMoreDataFileUrls : TeaModel {
            [NameInMap("MoreDataFileUrl")]
            [Validation(Required=false)]
            public List<string> MoreDataFileUrl { get; set; }

        }

        [NameInMap("MoreDataOssKeys")]
        [Validation(Required=false)]
        public QuerySmsTemplateByCodeNewResponseBodyMoreDataOssKeys MoreDataOssKeys { get; set; }
        public class QuerySmsTemplateByCodeNewResponseBodyMoreDataOssKeys : TeaModel {
            [NameInMap("MoreDataOssKey")]
            [Validation(Required=false)]
            public List<string> MoreDataOssKey { get; set; }

        }

        [NameInMap("NeedAuthorized")]
        [Validation(Required=false)]
        public bool? NeedAuthorized { get; set; }

        [NameInMap("OpenTag")]
        [Validation(Required=false)]
        public bool? OpenTag { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("OssKeys")]
        [Validation(Required=false)]
        public QuerySmsTemplateByCodeNewResponseBodyOssKeys OssKeys { get; set; }
        public class QuerySmsTemplateByCodeNewResponseBodyOssKeys : TeaModel {
            [NameInMap("OssKey")]
            [Validation(Required=false)]
            public List<string> OssKey { get; set; }

        }

        [NameInMap("ProductUrl")]
        [Validation(Required=false)]
        public string ProductUrl { get; set; }

        [NameInMap("RelatedSignName")]
        [Validation(Required=false)]
        public string RelatedSignName { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RmdTemplateId")]
        [Validation(Required=false)]
        public int? RmdTemplateId { get; set; }

        [NameInMap("RmdTemplateVariableNum")]
        [Validation(Required=false)]
        public int? RmdTemplateVariableNum { get; set; }

        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        [NameInMap("SignType")]
        [Validation(Required=false)]
        public int? SignType { get; set; }

        [NameInMap("SmsContent")]
        [Validation(Required=false)]
        public string SmsContent { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public QuerySmsTemplateByCodeNewResponseBodyTags Tags { get; set; }
        public class QuerySmsTemplateByCodeNewResponseBodyTags : TeaModel {
            [NameInMap("TagInfo")]
            [Validation(Required=false)]
            public List<QuerySmsTemplateByCodeNewResponseBodyTagsTagInfo> TagInfo { get; set; }
            public class QuerySmsTemplateByCodeNewResponseBodyTagsTagInfo : TeaModel {
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

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TemplateRule")]
        [Validation(Required=false)]
        public string TemplateRule { get; set; }

    }

}
