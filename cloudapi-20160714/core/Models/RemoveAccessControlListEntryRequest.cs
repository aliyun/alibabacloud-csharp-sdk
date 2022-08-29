// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class RemoveAccessControlListEntryRequest : TeaModel {
        [NameInMap("AclEntrys")]
        [Validation(Required=false)]
        public string AclEntrys { get; set; }

        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

    }

}
