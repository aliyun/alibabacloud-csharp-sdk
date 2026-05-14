// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DataMountInfo : TeaModel {
        [NameInMap("MountFolderName")]
        [Validation(Required=false)]
        public string MountFolderName { get; set; }

        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        [NameInMap("ReadOnly")]
        [Validation(Required=false)]
        public bool? ReadOnly { get; set; }

    }

}
