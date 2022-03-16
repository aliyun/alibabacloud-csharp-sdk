// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class RelateDbForHBaseHaRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("HaActive")]
        [Validation(Required=false)]
        public string HaActive { get; set; }

        [NameInMap("HaActiveClusterKey")]
        [Validation(Required=false)]
        public string HaActiveClusterKey { get; set; }

        [NameInMap("HaActiveDBType")]
        [Validation(Required=false)]
        public string HaActiveDBType { get; set; }

        [NameInMap("HaActiveHbaseFsDir")]
        [Validation(Required=false)]
        public string HaActiveHbaseFsDir { get; set; }

        [NameInMap("HaActiveHdfsUri")]
        [Validation(Required=false)]
        public string HaActiveHdfsUri { get; set; }

        [NameInMap("HaActivePassword")]
        [Validation(Required=false)]
        public string HaActivePassword { get; set; }

        [NameInMap("HaActiveUser")]
        [Validation(Required=false)]
        public string HaActiveUser { get; set; }

        [NameInMap("HaActiveVersion")]
        [Validation(Required=false)]
        public string HaActiveVersion { get; set; }

        [NameInMap("HaMigrateType")]
        [Validation(Required=false)]
        public string HaMigrateType { get; set; }

        [NameInMap("HaStandby")]
        [Validation(Required=false)]
        public string HaStandby { get; set; }

        [NameInMap("HaStandbyClusterKey")]
        [Validation(Required=false)]
        public string HaStandbyClusterKey { get; set; }

        [NameInMap("HaStandbyDBType")]
        [Validation(Required=false)]
        public string HaStandbyDBType { get; set; }

        [NameInMap("HaStandbyHbaseFsDir")]
        [Validation(Required=false)]
        public string HaStandbyHbaseFsDir { get; set; }

        [NameInMap("HaStandbyHdfsUri")]
        [Validation(Required=false)]
        public string HaStandbyHdfsUri { get; set; }

        [NameInMap("HaStandbyPassword")]
        [Validation(Required=false)]
        public string HaStandbyPassword { get; set; }

        [NameInMap("HaStandbyUser")]
        [Validation(Required=false)]
        public string HaStandbyUser { get; set; }

        [NameInMap("HaStandbyVersion")]
        [Validation(Required=false)]
        public string HaStandbyVersion { get; set; }

        [NameInMap("HaTables")]
        [Validation(Required=false)]
        public string HaTables { get; set; }

        [NameInMap("IsActiveStandard")]
        [Validation(Required=false)]
        public bool? IsActiveStandard { get; set; }

        [NameInMap("IsStandbyStandard")]
        [Validation(Required=false)]
        public bool? IsStandbyStandard { get; set; }

    }

}
