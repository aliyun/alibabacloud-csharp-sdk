// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class GetWirelessCloudConnectorResponseBody : TeaModel {
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

        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<string> Features { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NetLinks")]
        [Validation(Required=false)]
        public List<GetWirelessCloudConnectorResponseBodyNetLinks> NetLinks { get; set; }
        public class GetWirelessCloudConnectorResponseBodyNetLinks : TeaModel {
            [NameInMap("APN")]
            [Validation(Required=false)]
            public string APN { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GrantAliUid")]
            [Validation(Required=false)]
            public string GrantAliUid { get; set; }

            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NetLinkId")]
            [Validation(Required=false)]
            public string NetLinkId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VSwitchs")]
            [Validation(Required=false)]
            public List<string> VSwitchs { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UseCase")]
        [Validation(Required=false)]
        public string UseCase { get; set; }

        [NameInMap("WirelessCloudConnectorGroupId")]
        [Validation(Required=false)]
        public string WirelessCloudConnectorGroupId { get; set; }

        [NameInMap("WirelessCloudConnectorId")]
        [Validation(Required=false)]
        public string WirelessCloudConnectorId { get; set; }

    }

}
