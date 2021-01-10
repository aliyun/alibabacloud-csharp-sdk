// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLDCCellgroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CellGroupList")]
        [Validation(Required=false)]
        public List<ListLDCCellgroupResponseBodyCellGroupList> CellGroupList { get; set; }
        public class ListLDCCellgroupResponseBodyCellGroupList : TeaModel {
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
            public List<ListLDCCellgroupResponseBodyCellGroupListCells> Cells { get; set; }
            public class ListLDCCellgroupResponseBodyCellGroupListCells : TeaModel {
                [NameInMap("CellGroup")]
                [Validation(Required=false)]
                public string CellGroup { get; set; }

                [NameInMap("Cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }

                [NameInMap("Color")]
                [Validation(Required=false)]
                public string Color { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Identity")]
                [Validation(Required=false)]
                public string Identity { get; set; }

                [NameInMap("IsGray")]
                [Validation(Required=false)]
                public bool? IsGray { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PressWeight")]
                [Validation(Required=false)]
                public long? PressWeight { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Weight")]
                [Validation(Required=false)]
                public long? Weight { get; set; }

                [NameInMap("Workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

            }

            [NameInMap("DisasterInfo")]
            [Validation(Required=false)]
            public List<ListLDCCellgroupResponseBodyCellGroupListDisasterInfo> DisasterInfo { get; set; }
            public class ListLDCCellgroupResponseBodyCellGroupListDisasterInfo : TeaModel {
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

        }

    }

}
