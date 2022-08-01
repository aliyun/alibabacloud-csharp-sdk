// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateOdpsShipperRequest : TeaModel {
        [NameInMap("shipperName")]
        [Validation(Required=false)]
        public string ShipperName { get; set; }

        [NameInMap("targetConfiguration")]
        [Validation(Required=false)]
        public UpdateOdpsShipperRequestTargetConfiguration TargetConfiguration { get; set; }
        public class UpdateOdpsShipperRequestTargetConfiguration : TeaModel {
            [NameInMap("bufferInterval")]
            [Validation(Required=false)]
            public int? BufferInterval { get; set; }
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }
            [NameInMap("fields")]
            [Validation(Required=false)]
            public List<string> Fields { get; set; }
            [NameInMap("odpsEndpoint")]
            [Validation(Required=false)]
            public string OdpsEndpoint { get; set; }
            [NameInMap("odpsProject")]
            [Validation(Required=false)]
            public string OdpsProject { get; set; }
            [NameInMap("odpsTable")]
            [Validation(Required=false)]
            public string OdpsTable { get; set; }
            [NameInMap("partitionColumn")]
            [Validation(Required=false)]
            public List<string> PartitionColumn { get; set; }
            [NameInMap("partitionTimeFormat")]
            [Validation(Required=false)]
            public string PartitionTimeFormat { get; set; }
        };

        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
