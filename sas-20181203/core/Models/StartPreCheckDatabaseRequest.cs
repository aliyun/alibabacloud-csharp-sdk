// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class StartPreCheckDatabaseRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("DatabaseType")]
        [Validation(Required=false)]
        public string DatabaseType { get; set; }

        [NameInMap("UniRegionId")]
        [Validation(Required=false)]
        public string UniRegionId { get; set; }

        [NameInMap("InstanceUuid")]
        [Validation(Required=false)]
        public string InstanceUuid { get; set; }

    }

}
