// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryAdvancedDomainListRequest : TeaModel {
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

        [NameInMap("DomainNameSort")]
        [Validation(Required=false)]
        public bool? DomainNameSort { get; set; }

        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public int? DomainStatus { get; set; }

        [NameInMap("EndExpirationDate")]
        [Validation(Required=false)]
        public long? EndExpirationDate { get; set; }

        [NameInMap("EndLength")]
        [Validation(Required=false)]
        public int? EndLength { get; set; }

        [NameInMap("EndRegistrationDate")]
        [Validation(Required=false)]
        public long? EndRegistrationDate { get; set; }

        [NameInMap("Excluded")]
        [Validation(Required=false)]
        public string Excluded { get; set; }

        [NameInMap("ExcludedPrefix")]
        [Validation(Required=false)]
        public bool? ExcludedPrefix { get; set; }

        [NameInMap("ExcludedSuffix")]
        [Validation(Required=false)]
        public bool? ExcludedSuffix { get; set; }

        [NameInMap("ExpirationDateSort")]
        [Validation(Required=false)]
        public bool? ExpirationDateSort { get; set; }

        [NameInMap("Form")]
        [Validation(Required=false)]
        public int? Form { get; set; }

        [NameInMap("IsPremiumDomain")]
        [Validation(Required=false)]
        public bool? IsPremiumDomain { get; set; }

        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        [NameInMap("KeyWordPrefix")]
        [Validation(Required=false)]
        public bool? KeyWordPrefix { get; set; }

        [NameInMap("KeyWordSuffix")]
        [Validation(Required=false)]
        public bool? KeyWordSuffix { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProductDomainType")]
        [Validation(Required=false)]
        public string ProductDomainType { get; set; }

        [NameInMap("ProductDomainTypeSort")]
        [Validation(Required=false)]
        public bool? ProductDomainTypeSort { get; set; }

        [NameInMap("RegistrationDateSort")]
        [Validation(Required=false)]
        public bool? RegistrationDateSort { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("StartExpirationDate")]
        [Validation(Required=false)]
        public long? StartExpirationDate { get; set; }

        [NameInMap("StartLength")]
        [Validation(Required=false)]
        public int? StartLength { get; set; }

        [NameInMap("StartRegistrationDate")]
        [Validation(Required=false)]
        public long? StartRegistrationDate { get; set; }

        [NameInMap("Suffixs")]
        [Validation(Required=false)]
        public string Suffixs { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<QueryAdvancedDomainListRequestTag> Tag { get; set; }
        public class QueryAdvancedDomainListRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TradeType")]
        [Validation(Required=false)]
        public int? TradeType { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
