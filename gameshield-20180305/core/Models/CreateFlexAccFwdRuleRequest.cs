// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class CreateFlexAccFwdRuleRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public long? BizId { get; set; }

        [NameInMap("Identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        [NameInMap("IpList")]
        [Validation(Required=false)]
        public string IpList { get; set; }

        [NameInMap("ProtocolEx")]
        [Validation(Required=false)]
        public string ProtocolEx { get; set; }

        [NameInMap("DomainList")]
        [Validation(Required=false)]
        public string DomainList { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("MasterIpList")]
        [Validation(Required=false)]
        public string MasterIpList { get; set; }

        [NameInMap("SlaveIpList")]
        [Validation(Required=false)]
        public string SlaveIpList { get; set; }

        [NameInMap("AccType")]
        [Validation(Required=false)]
        public int? AccType { get; set; }

    }

}
