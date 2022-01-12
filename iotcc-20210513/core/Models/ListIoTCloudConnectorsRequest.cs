// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListIoTCloudConnectorsRequest : TeaModel {
        [NameInMap("APN")]
        [Validation(Required=false)]
        public List<string> APN { get; set; }

        [NameInMap("ISP")]
        [Validation(Required=false)]
        public List<string> ISP { get; set; }

        [NameInMap("IoTCloudConnectorGroupId")]
        [Validation(Required=false)]
        public string IoTCloudConnectorGroupId { get; set; }

        [NameInMap("IoTCloudConnectorIds")]
        [Validation(Required=false)]
        public List<string> IoTCloudConnectorIds { get; set; }

        [NameInMap("IoTCloudConnectorName")]
        [Validation(Required=false)]
        public List<string> IoTCloudConnectorName { get; set; }

        [NameInMap("IoTCloudConnectorStatus")]
        [Validation(Required=false)]
        public List<string> IoTCloudConnectorStatus { get; set; }

        [NameInMap("IsInGroup")]
        [Validation(Required=false)]
        public bool? IsInGroup { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public List<string> VpcId { get; set; }

    }

}
