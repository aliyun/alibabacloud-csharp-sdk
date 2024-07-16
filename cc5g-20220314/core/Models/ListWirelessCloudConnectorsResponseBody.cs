// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class ListWirelessCloudConnectorsResponseBody : TeaModel {
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

        [NameInMap("WirelessCloudConnectors")]
        [Validation(Required=false)]
        public List<ListWirelessCloudConnectorsResponseBodyWirelessCloudConnectors> WirelessCloudConnectors { get; set; }
        public class ListWirelessCloudConnectorsResponseBodyWirelessCloudConnectors : TeaModel {
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

            /// <summary>
            /// 代表创建时间的资源属性字段
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// 代表资源名称的资源属性字段
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UseCase")]
            [Validation(Required=false)]
            public string UseCase { get; set; }

            [NameInMap("WirelessCloudConnectorGroupId")]
            [Validation(Required=false)]
            public string WirelessCloudConnectorGroupId { get; set; }

            /// <summary>
            /// 代表资源一级ID的资源属性字段
            /// </summary>
            [NameInMap("WirelessCloudConnectorId")]
            [Validation(Required=false)]
            public string WirelessCloudConnectorId { get; set; }

        }

    }

}
