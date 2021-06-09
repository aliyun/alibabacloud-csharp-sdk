// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListAccessPointNetworkQualitiesResponseBody : TeaModel {
        [NameInMap("AccessPointNetworkQualities")]
        [Validation(Required=false)]
        public List<ListAccessPointNetworkQualitiesResponseBodyAccessPointNetworkQualities> AccessPointNetworkQualities { get; set; }
        public class ListAccessPointNetworkQualitiesResponseBodyAccessPointNetworkQualities : TeaModel {
            [NameInMap("Loss")]
            [Validation(Required=false)]
            public string Loss { get; set; }

            [NameInMap("Rtt")]
            [Validation(Required=false)]
            public string Rtt { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
