// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaApplicationsForTemplateRequest : TeaModel {
        [NameInMap("AliyunUids")]
        [Validation(Required=false)]
        public List<string> AliyunUids { get; set; }

        [NameInMap("DesireValue")]
        [Validation(Required=false)]
        public double? DesireValue { get; set; }

        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<CreateQuotaApplicationsForTemplateRequestDimensions> Dimensions { get; set; }
        public class CreateQuotaApplicationsForTemplateRequestDimensions : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        [NameInMap("EnvLanguage")]
        [Validation(Required=false)]
        public string EnvLanguage { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("NoticeType")]
        [Validation(Required=false)]
        public int? NoticeType { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
