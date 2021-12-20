// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListIoTCloudConnectorGroupsRequest : TeaModel {
        [NameInMap("IoTCloudConnectorGroupIds")]
        [Validation(Required=false)]
        public List<string> IoTCloudConnectorGroupIds { get; set; }

        [NameInMap("IoTCloudConnectorGroupName")]
        [Validation(Required=false)]
        public List<string> IoTCloudConnectorGroupName { get; set; }

        [NameInMap("IoTCloudConnectorGroupStatus")]
        [Validation(Required=false)]
        public List<string> IoTCloudConnectorGroupStatus { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
