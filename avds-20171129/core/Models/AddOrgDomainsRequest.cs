// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avds20171129.Models
{
    public class AddOrgDomainsRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public int? OrgId { get; set; }

        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<string> Domains { get; set; }

    }

}
