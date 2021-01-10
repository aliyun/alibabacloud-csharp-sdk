// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLDCCellgroupDisasterinfoRequest : TeaModel {
        [NameInMap("DisasterInfo")]
        [Validation(Required=false)]
        public List<UpdateLDCCellgroupDisasterinfoRequestDisasterInfo> DisasterInfo { get; set; }
        public class UpdateLDCCellgroupDisasterinfoRequestDisasterInfo : TeaModel {
            [NameInMap("DisasterRecoveryState")]
            [Validation(Required=false)]
            public string DisasterRecoveryState { get; set; }

            [NameInMap("LocalFailoverTarget")]
            [Validation(Required=false)]
            public string LocalFailoverTarget { get; set; }

            [NameInMap("PressDisasterRecoveryState")]
            [Validation(Required=false)]
            public string PressDisasterRecoveryState { get; set; }

            [NameInMap("RemoteFailoverTarget")]
            [Validation(Required=false)]
            public string RemoteFailoverTarget { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

    }

}
