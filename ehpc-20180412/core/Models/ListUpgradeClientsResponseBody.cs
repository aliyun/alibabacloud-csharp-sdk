// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListUpgradeClientsResponseBody : TeaModel {
        [NameInMap("ClientRecords")]
        [Validation(Required=false)]
        public List<ListUpgradeClientsResponseBodyClientRecords> ClientRecords { get; set; }
        public class ListUpgradeClientsResponseBodyClientRecords : TeaModel {
            [NameInMap("NewVersion")]
            [Validation(Required=false)]
            public string NewVersion { get; set; }

            [NameInMap("OldVersion")]
            [Validation(Required=false)]
            public string OldVersion { get; set; }

            [NameInMap("SubUid")]
            [Validation(Required=false)]
            public string SubUid { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("CurrentVersion")]
        [Validation(Required=false)]
        public string CurrentVersion { get; set; }

        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public string LatestVersion { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
