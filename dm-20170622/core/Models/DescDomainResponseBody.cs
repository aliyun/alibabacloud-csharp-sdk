// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20170622.Models
{
    public class DescDomainResponseBody : TeaModel {
        [NameInMap("CnameAuthStatus")]
        [Validation(Required=false)]
        public string CnameAuthStatus { get; set; }

        [NameInMap("CnameConfirmStatus")]
        [Validation(Required=false)]
        public string CnameConfirmStatus { get; set; }

        [NameInMap("CnameRecord")]
        [Validation(Required=false)]
        public string CnameRecord { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DefaultDomain")]
        [Validation(Required=false)]
        public string DefaultDomain { get; set; }

        [NameInMap("DkimAuthStatus")]
        [Validation(Required=false)]
        public string DkimAuthStatus { get; set; }

        [NameInMap("DkimPublicKey")]
        [Validation(Required=false)]
        public string DkimPublicKey { get; set; }

        [NameInMap("DkimRR")]
        [Validation(Required=false)]
        public string DkimRR { get; set; }

        [NameInMap("DmarcAuthStatus")]
        [Validation(Required=false)]
        public int? DmarcAuthStatus { get; set; }

        [NameInMap("DmarcHostRecord")]
        [Validation(Required=false)]
        public string DmarcHostRecord { get; set; }

        [NameInMap("DmarcRecord")]
        [Validation(Required=false)]
        public string DmarcRecord { get; set; }

        [NameInMap("DnsDmarc")]
        [Validation(Required=false)]
        public string DnsDmarc { get; set; }

        [NameInMap("DnsMx")]
        [Validation(Required=false)]
        public string DnsMx { get; set; }

        [NameInMap("DnsSpf")]
        [Validation(Required=false)]
        public string DnsSpf { get; set; }

        [NameInMap("DnsTxt")]
        [Validation(Required=false)]
        public string DnsTxt { get; set; }

        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        [NameInMap("HostRecord")]
        [Validation(Required=false)]
        public string HostRecord { get; set; }

        [NameInMap("IcpStatus")]
        [Validation(Required=false)]
        public string IcpStatus { get; set; }

        [NameInMap("MxAuthStatus")]
        [Validation(Required=false)]
        public string MxAuthStatus { get; set; }

        [NameInMap("MxRecord")]
        [Validation(Required=false)]
        public string MxRecord { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SpfAuthStatus")]
        [Validation(Required=false)]
        public string SpfAuthStatus { get; set; }

        [NameInMap("SpfRecord")]
        [Validation(Required=false)]
        public string SpfRecord { get; set; }

        [NameInMap("SpfRecordV2")]
        [Validation(Required=false)]
        public string SpfRecordV2 { get; set; }

        [NameInMap("TlDomainName")]
        [Validation(Required=false)]
        public string TlDomainName { get; set; }

        [NameInMap("TracefRecord")]
        [Validation(Required=false)]
        public string TracefRecord { get; set; }

    }

}
