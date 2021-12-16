// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpaUserDomainsRequest : TeaModel {
        [NameInMap("CheckDomainShow")]
        [Validation(Required=false)]
        public bool? CheckDomainShow { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomainSearchType")]
        [Validation(Required=false)]
        public string DomainSearchType { get; set; }

        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        [NameInMap("FuncFilter")]
        [Validation(Required=false)]
        public string FuncFilter { get; set; }

        [NameInMap("FuncId")]
        [Validation(Required=false)]
        public string FuncId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDcdnIpaUserDomainsRequestTag> Tag { get; set; }
        public class DescribeDcdnIpaUserDomainsRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
