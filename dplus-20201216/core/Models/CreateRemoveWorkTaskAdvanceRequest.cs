// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dplus20201216.Models
{
    public class CreateRemoveWorkTaskAdvanceRequest : TeaModel {
        [NameInMap("PicUrlObject")]
        [Validation(Required=true)]
        public Stream PicUrlObject { get; set; }

        [NameInMap("ItemIdentity")]
        [Validation(Required=false)]
        public string ItemIdentity { get; set; }

    }

}
