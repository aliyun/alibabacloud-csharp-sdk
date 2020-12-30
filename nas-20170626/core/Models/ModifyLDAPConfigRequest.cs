// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyLDAPConfigRequest : TeaModel {
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

        [NameInMap("BindDN")]
        [Validation(Required=false)]
        public string BindDN { get; set; }

        [NameInMap("SearchBase")]
        [Validation(Required=false)]
        public string SearchBase { get; set; }

    }

}
