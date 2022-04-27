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

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// 数组，返回示例目录。
        /// </summary>
        [NameInMap("WirelessCloudConnectors")]
        [Validation(Required=false)]
        public List<ListWirelessCloudConnectorsResponseBodyWirelessCloudConnectors> WirelessCloudConnectors { get; set; }
        public class ListWirelessCloudConnectorsResponseBodyWirelessCloudConnectors : TeaModel {
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
            /// 创建时间
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// 资源名称
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UseCase")]
            [Validation(Required=false)]
            public string UseCase { get; set; }

            /// <summary>
            /// 资源一级ID
            /// </summary>
            [NameInMap("WirelessCloudConnectorId")]
            [Validation(Required=false)]
            public string WirelessCloudConnectorId { get; set; }

        }

    }

}
