// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20160511.Models
{
    public class SaveTaskForModifyingDomainDnsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AliyunDns")]
        [Validation(Required=false)]
        public bool? AliyunDns { get; set; }

        [NameInMap("DnsList")]
        [Validation(Required=false)]
        public List<string> DnsList { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("SaleId")]
        [Validation(Required=false)]
        public string SaleId { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
