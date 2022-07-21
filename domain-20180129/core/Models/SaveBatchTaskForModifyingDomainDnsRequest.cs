// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForModifyingDomainDnsRequest : TeaModel {
        [NameInMap("AliyunDns")]
        [Validation(Required=false)]
        public bool? AliyunDns { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public List<string> DomainName { get; set; }

        [NameInMap("DomainNameServer")]
        [Validation(Required=false)]
        public List<string> DomainNameServer { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
