// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SetDomainRequest : TeaModel {
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("BindStageName")]
        [Validation(Required=false)]
        public string BindStageName { get; set; }

        [NameInMap("CustomDomainType")]
        [Validation(Required=false)]
        public string CustomDomainType { get; set; }

        [NameInMap("IsForce")]
        [Validation(Required=false)]
        public bool? IsForce { get; set; }

    }

}
