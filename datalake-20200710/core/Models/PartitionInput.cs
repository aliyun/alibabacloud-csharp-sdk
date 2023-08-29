// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class PartitionInput : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("LastAccessTime")]
        [Validation(Required=false)]
        public int? LastAccessTime { get; set; }

        [NameInMap("LastAnalyzedTime")]
        [Validation(Required=false)]
        public int? LastAnalyzedTime { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        [NameInMap("Privileges")]
        [Validation(Required=false)]
        public PrincipalPrivilegeSet Privileges { get; set; }

        [NameInMap("Sd")]
        [Validation(Required=false)]
        public StorageDescriptor Sd { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

    }

}
