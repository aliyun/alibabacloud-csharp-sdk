// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryStandarTemplateCollectionsNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public QueryStandarTemplateCollectionsNewResponseBodyList List { get; set; }
        public class QueryStandarTemplateCollectionsNewResponseBodyList : TeaModel {
            [NameInMap("FcPartnerTemplateDTO")]
            [Validation(Required=false)]
            public List<QueryStandarTemplateCollectionsNewResponseBodyListFcPartnerTemplateDTO> FcPartnerTemplateDTO { get; set; }
            public class QueryStandarTemplateCollectionsNewResponseBodyListFcPartnerTemplateDTO : TeaModel {
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public int? BusinessType { get; set; }

                [NameInMap("FcTag")]
                [Validation(Required=false)]
                public long? FcTag { get; set; }

                [NameInMap("I18n")]
                [Validation(Required=false)]
                public string I18n { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IsDeleted")]
                [Validation(Required=false)]
                public int? IsDeleted { get; set; }

                [NameInMap("McBusinessType")]
                [Validation(Required=false)]
                public int? McBusinessType { get; set; }

                [NameInMap("McCategory")]
                [Validation(Required=false)]
                public int? McCategory { get; set; }

                [NameInMap("McSignature")]
                [Validation(Required=false)]
                public string McSignature { get; set; }

                [NameInMap("MessageTypeId")]
                [Validation(Required=false)]
                public long? MessageTypeId { get; set; }

                [NameInMap("OpNick")]
                [Validation(Required=false)]
                public string OpNick { get; set; }

                [NameInMap("PartnerId")]
                [Validation(Required=false)]
                public long? PartnerId { get; set; }

                [NameInMap("QualificationId")]
                [Validation(Required=false)]
                public long? QualificationId { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("SignTemplateId")]
                [Validation(Required=false)]
                public long? SignTemplateId { get; set; }

                [NameInMap("SignType")]
                [Validation(Required=false)]
                public int? SignType { get; set; }

                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                [NameInMap("SpeedLevel")]
                [Validation(Required=false)]
                public int? SpeedLevel { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public int? State { get; set; }

                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

                [NameInMap("TemplateContent")]
                [Validation(Required=false)]
                public string TemplateContent { get; set; }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                [NameInMap("TemplateParamRule")]
                [Validation(Required=false)]
                public string TemplateParamRule { get; set; }

                [NameInMap("TemplateSenderType")]
                [Validation(Required=false)]
                public int? TemplateSenderType { get; set; }

                [NameInMap("TemplateType")]
                [Validation(Required=false)]
                public int? TemplateType { get; set; }

                [NameInMap("TotalCountLimit")]
                [Validation(Required=false)]
                public long? TotalCountLimit { get; set; }

                [NameInMap("VoiceType")]
                [Validation(Required=false)]
                public int? VoiceType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
