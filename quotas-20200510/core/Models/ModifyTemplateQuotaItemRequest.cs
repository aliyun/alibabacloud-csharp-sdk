// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ModifyTemplateQuotaItemRequest : TeaModel {
        [NameInMap("DesireValue")]
        [Validation(Required=false)]
        public float? DesireValue { get; set; }

        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<ModifyTemplateQuotaItemRequestDimensions> Dimensions { get; set; }
        public class ModifyTemplateQuotaItemRequestDimensions : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("NoticeType")]
        [Validation(Required=false)]
        public long? NoticeType { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

    }

}
