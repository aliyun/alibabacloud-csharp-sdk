// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeMigrationPreferencesResponseBody : TeaModel {
        [NameInMap("MigrationNetworkType")]
        [Validation(Required=false)]
        public string MigrationNetworkType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TargetZoneIdSet")]
        [Validation(Required=false)]
        public DescribeMigrationPreferencesResponseBodyTargetZoneIdSet TargetZoneIdSet { get; set; }
        public class DescribeMigrationPreferencesResponseBodyTargetZoneIdSet : TeaModel {
            [NameInMap("TargetZoneId")]
            [Validation(Required=false)]
            public List<string> TargetZoneId { get; set; }

        }

    }

}
