// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class PrivilegeTransferResultEntrie : TeaModel {
        [NameInMap("Children")]
        [Validation(Required=false)]
        public List<PrivilegeTransferResultEntrie> Children { get; set; }

        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("IsLeaf")]
        [Validation(Required=false)]
        public bool? IsLeaf { get; set; }

        [NameInMap("Privilege")]
        [Validation(Required=false)]
        public string Privilege { get; set; }

        [NameInMap("PrivilegeDisplayName")]
        [Validation(Required=false)]
        public string PrivilegeDisplayName { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Test")]
        [Validation(Required=false)]
        public string Test { get; set; }

    }

}
