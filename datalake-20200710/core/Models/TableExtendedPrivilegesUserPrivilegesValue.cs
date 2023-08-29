// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class TableExtendedPrivilegesUserPrivilegesValue : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        [NameInMap("GrantOption")]
        [Validation(Required=false)]
        public bool? GrantOption { get; set; }

        [NameInMap("Grantor")]
        [Validation(Required=false)]
        public string Grantor { get; set; }

        [NameInMap("GrantorType")]
        [Validation(Required=false)]
        public string GrantorType { get; set; }

        [NameInMap("Privilege")]
        [Validation(Required=false)]
        public string Privilege { get; set; }

    }

}
