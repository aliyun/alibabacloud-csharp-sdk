// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListServiceEntriesRequest : TeaModel {
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

        [NameInMap("ServiceEntryIds")]
        [Validation(Required=false)]
        public List<string> ServiceEntryIds { get; set; }

        [NameInMap("ServiceEntryName")]
        [Validation(Required=false)]
        public List<string> ServiceEntryName { get; set; }

        [NameInMap("ServiceEntryStatus")]
        [Validation(Required=false)]
        public List<string> ServiceEntryStatus { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("Target")]
        [Validation(Required=false)]
        public List<string> Target { get; set; }

        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public List<string> TargetType { get; set; }

    }

}
