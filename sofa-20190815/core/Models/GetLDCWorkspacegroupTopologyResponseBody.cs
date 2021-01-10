// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLDCWorkspacegroupTopologyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("CellGroups")]
        [Validation(Required=false)]
        public List<GetLDCWorkspacegroupTopologyResponseBodyCellGroups> CellGroups { get; set; }
        public class GetLDCWorkspacegroupTopologyResponseBodyCellGroups : TeaModel {
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
            public List<GetLDCWorkspacegroupTopologyResponseBodyCellGroupsCells> Cells { get; set; }
            public class GetLDCWorkspacegroupTopologyResponseBodyCellGroupsCells : TeaModel {
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
            public List<GetLDCWorkspacegroupTopologyResponseBodyCellGroupsDisasterInfo> DisasterInfo { get; set; }
            public class GetLDCWorkspacegroupTopologyResponseBodyCellGroupsDisasterInfo : TeaModel {
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

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<GetLDCWorkspacegroupTopologyResponseBodyZones> Zones { get; set; }
        public class GetLDCWorkspacegroupTopologyResponseBodyZones : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

    }

}
