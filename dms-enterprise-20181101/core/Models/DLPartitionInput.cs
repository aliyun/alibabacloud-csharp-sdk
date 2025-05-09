// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DLPartitionInput : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        [NameInMap("LastAccessTime")]
        [Validation(Required=false)]
        public int? LastAccessTime { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        [NameInMap("StorageDescriptor")]
        [Validation(Required=false)]
        public DLStorageDescriptor StorageDescriptor { get; set; }

        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

    }

}
