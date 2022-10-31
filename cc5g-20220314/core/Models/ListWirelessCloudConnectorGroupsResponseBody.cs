// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class ListWirelessCloudConnectorGroupsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("WirelessCloudConnectorGroups")]
        [Validation(Required=false)]
        public List<ListWirelessCloudConnectorGroupsResponseBodyWirelessCloudConnectorGroups> WirelessCloudConnectorGroups { get; set; }
        public class ListWirelessCloudConnectorGroupsResponseBodyWirelessCloudConnectorGroups : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("WirelessCloudConnectorGroupId")]
            [Validation(Required=false)]
            public string WirelessCloudConnectorGroupId { get; set; }

            [NameInMap("WirelessCloudConnectors")]
            [Validation(Required=false)]
            public List<ListWirelessCloudConnectorGroupsResponseBodyWirelessCloudConnectorGroupsWirelessCloudConnectors> WirelessCloudConnectors { get; set; }
            public class ListWirelessCloudConnectorGroupsResponseBodyWirelessCloudConnectorGroupsWirelessCloudConnectors : TeaModel {
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                [NameInMap("CardCount")]
                [Validation(Required=false)]
                public string CardCount { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DataPackageId")]
                [Validation(Required=false)]
                public string DataPackageId { get; set; }

                [NameInMap("DataPackageType")]
                [Validation(Required=false)]
                public string DataPackageType { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UseCase")]
                [Validation(Required=false)]
                public string UseCase { get; set; }

                [NameInMap("WirelessCloudConnectorId")]
                [Validation(Required=false)]
                public string WirelessCloudConnectorId { get; set; }

            }

        }

    }

}
