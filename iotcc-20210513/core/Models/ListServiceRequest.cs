// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListServiceRequest : TeaModel {
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

        [NameInMap("ResourceStatuses")]
        [Validation(Required=false)]
        public List<string> ResourceStatuses { get; set; }

        [NameInMap("ServiceIds")]
        [Validation(Required=false)]
        public List<string> ServiceIds { get; set; }

        [NameInMap("ServiceNames")]
        [Validation(Required=false)]
        public List<string> ServiceNames { get; set; }

    }

}
