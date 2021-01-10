// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLDCCellgroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CellGroup")]
        [Validation(Required=false)]
        public GetLDCCellgroupResponseBodyCellGroup CellGroup { get; set; }
        public class GetLDCCellgroupResponseBodyCellGroup : TeaModel {
            [NameInMap("Datacenter")]
            [Validation(Required=false)]
            public string Datacenter { get; set; }
            [NameInMap("DefaultGzone")]
            [Validation(Required=false)]
            public string DefaultGzone { get; set; }
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Cells")]
            [Validation(Required=false)]
            public List<GetLDCCellgroupResponseBodyCellGroupCells> Cells { get; set; }
            public class GetLDCCellgroupResponseBodyCellGroupCells : TeaModel {
                public string CellGroup { get; set; }
                public string Cluster { get; set; }
                public string Color { get; set; }
                public string CreatedTime { get; set; }
                public string DisplayName { get; set; }
                public string Identity { get; set; }
                public bool? IsGray { get; set; }
                public string Name { get; set; }
                public long? PressWeight { get; set; }
                public string Type { get; set; }
                public long? Weight { get; set; }
                public string Workspace { get; set; }
                public string Zone { get; set; }
            }
            [NameInMap("DisasterInfo")]
            [Validation(Required=false)]
            public List<GetLDCCellgroupResponseBodyCellGroupDisasterInfo> DisasterInfo { get; set; }
            public class GetLDCCellgroupResponseBodyCellGroupDisasterInfo : TeaModel {
                public string DisasterRecoveryState { get; set; }
                public string LocalFailoverTarget { get; set; }
                public string PressDisasterRecoveryState { get; set; }
                public string RemoteFailoverTarget { get; set; }
                public string Source { get; set; }
                public string Type { get; set; }
            }
        };

    }

}
