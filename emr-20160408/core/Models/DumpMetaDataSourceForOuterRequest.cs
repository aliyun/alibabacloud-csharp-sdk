// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DumpMetaDataSourceForOuterRequest : TeaModel {
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DumpAllDatabase")]
        [Validation(Required=false)]
        public bool? DumpAllDatabase { get; set; }

        [NameInMap("DatabaseId")]
        [Validation(Required=false)]
        public string DatabaseId { get; set; }

        [NameInMap("DumpAllTable")]
        [Validation(Required=false)]
        public bool? DumpAllTable { get; set; }

        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        [NameInMap("DumpAllPartition")]
        [Validation(Required=false)]
        public bool? DumpAllPartition { get; set; }

        [NameInMap("DumpLimit")]
        [Validation(Required=false)]
        public int? DumpLimit { get; set; }

        [NameInMap("PartitionValues")]
        [Validation(Required=false)]
        public List<string> PartitionValues { get; set; }

    }

}
