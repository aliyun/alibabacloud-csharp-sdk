// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class QueryDomainListRequest : TeaModel {
        [NameInMap("Ccompany")]
        [Validation(Required=false)]
        public string Ccompany { get; set; }

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

        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("StartExpirationDate")]
        [Validation(Required=false)]
        public long? StartExpirationDate { get; set; }

        [NameInMap("StartRegistrationDate")]
        [Validation(Required=false)]
        public long? StartRegistrationDate { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
