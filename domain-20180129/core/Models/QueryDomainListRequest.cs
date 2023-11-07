// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainListRequest : TeaModel {
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public string DomainGroupId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndExpirationDate")]
        [Validation(Required=false)]
        public long? EndExpirationDate { get; set; }

        [NameInMap("EndRegistrationDate")]
        [Validation(Required=false)]
        public long? EndRegistrationDate { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("OrderByType")]
        [Validation(Required=false)]
        public string OrderByType { get; set; }

        [NameInMap("OrderKeyType")]
        [Validation(Required=false)]
        public string OrderKeyType { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProductDomainType")]
        [Validation(Required=false)]
        public string ProductDomainType { get; set; }

        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("StartExpirationDate")]
        [Validation(Required=false)]
        public long? StartExpirationDate { get; set; }

        [NameInMap("StartRegistrationDate")]
        [Validation(Required=false)]
        public long? StartRegistrationDate { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<QueryDomainListRequestTag> Tag { get; set; }
        public class QueryDomainListRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
