// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class SaveBatchTaskForReserveDropListDomainRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactTemplateId")]
        [Validation(Required=false)]
        public string ContactTemplateId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
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

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

    }

}
