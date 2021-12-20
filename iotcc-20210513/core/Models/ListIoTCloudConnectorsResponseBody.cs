// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListIoTCloudConnectorsResponseBody : TeaModel {
        [NameInMap("IoTCloudConnectors")]
        [Validation(Required=false)]
        public List<ListIoTCloudConnectorsResponseBodyIoTCloudConnectors> IoTCloudConnectors { get; set; }
        public class ListIoTCloudConnectorsResponseBodyIoTCloudConnectors : TeaModel {
            [NameInMap("APN")]
            [Validation(Required=false)]
            public string APN { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            [NameInMap("IoTCloudConnectorBusinessStatus")]
            [Validation(Required=false)]
            public string IoTCloudConnectorBusinessStatus { get; set; }

            [NameInMap("IoTCloudConnectorDescription")]
            [Validation(Required=false)]
            public string IoTCloudConnectorDescription { get; set; }

            [NameInMap("IoTCloudConnectorGroupId")]
            [Validation(Required=false)]
            public string IoTCloudConnectorGroupId { get; set; }

            [NameInMap("IoTCloudConnectorId")]
            [Validation(Required=false)]
            public string IoTCloudConnectorId { get; set; }

            [NameInMap("IoTCloudConnectorName")]
            [Validation(Required=false)]
            public string IoTCloudConnectorName { get; set; }

            [NameInMap("IoTCloudConnectorStatus")]
            [Validation(Required=false)]
            public string IoTCloudConnectorStatus { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            [NameInMap("RateLimit")]
            [Validation(Required=false)]
            public long? RateLimit { get; set; }

            [NameInMap("VSwitchList")]
            [Validation(Required=false)]
            public List<string> VSwitchList { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("WildcardDomainEnabled")]
            [Validation(Required=false)]
            public bool? WildcardDomainEnabled { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
