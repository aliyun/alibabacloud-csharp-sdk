// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListConnectionPoolsRequest : TeaModel {
        [NameInMap("ConnectionPoolIds")]
        [Validation(Required=false)]
        public List<string> ConnectionPoolIds { get; set; }

        [NameInMap("ConnectionPoolName")]
        [Validation(Required=false)]
        public List<string> ConnectionPoolName { get; set; }

        [NameInMap("ConnectionPoolStatus")]
        [Validation(Required=false)]
        public List<string> ConnectionPoolStatus { get; set; }

        [NameInMap("IoTCloudConnectorId")]
        [Validation(Required=false)]
        public string IoTCloudConnectorId { get; set; }

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
