// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20160801.Models
{
    public class DescribeMigrationJobDetailRequest : TeaModel {
        [NameInMap("MigrationMode")]
        [Validation(Required=false)]
        public DescribeMigrationJobDetailRequestMigrationMode MigrationMode { get; set; }
        public class DescribeMigrationJobDetailRequestMigrationMode : TeaModel {
            [NameInMap("DataInitialization")]
            [Validation(Required=false)]
            public bool? DataInitialization { get; set; }

            [NameInMap("DataSynchronization")]
            [Validation(Required=false)]
            public bool? DataSynchronization { get; set; }

            [NameInMap("StructureInitialization")]
            [Validation(Required=false)]
            public bool? StructureInitialization { get; set; }

        }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("MigrationJobId")]
        [Validation(Required=false)]
        public string MigrationJobId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
