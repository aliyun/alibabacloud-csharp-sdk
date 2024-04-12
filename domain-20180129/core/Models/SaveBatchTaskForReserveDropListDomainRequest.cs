// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForReserveDropListDomainRequest : TeaModel {
        [NameInMap("ContactTemplateId")]
        [Validation(Required=false)]
        public string ContactTemplateId { get; set; }

        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<SaveBatchTaskForReserveDropListDomainRequestDomains> Domains { get; set; }
        public class SaveBatchTaskForReserveDropListDomainRequestDomains : TeaModel {
            [NameInMap("Dns1")]
            [Validation(Required=false)]
            public string Dns1 { get; set; }

            [NameInMap("Dns2")]
            [Validation(Required=false)]
            public string Dns2 { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

    }

}
