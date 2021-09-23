// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetDirectoryOrFilePropertiesResponseBody : TeaModel {
        [NameInMap("Entry")]
        [Validation(Required=false)]
        public GetDirectoryOrFilePropertiesResponseBodyEntry Entry { get; set; }
        public class GetDirectoryOrFilePropertiesResponseBodyEntry : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("HasInfrequentAccessFile")]
            [Validation(Required=false)]
            public bool? HasInfrequentAccessFile { get; set; }
            [NameInMap("MTime")]
            [Validation(Required=false)]
            public string MTime { get; set; }
            [NameInMap("ATime")]
            [Validation(Required=false)]
            public string ATime { get; set; }
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }
            [NameInMap("CTime")]
            [Validation(Required=false)]
            public string CTime { get; set; }
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("RetrieveTime")]
            [Validation(Required=false)]
            public string RetrieveTime { get; set; }
            [NameInMap("Inode")]
            [Validation(Required=false)]
            public string Inode { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
