// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterAvailableResourceResponseBody : TeaModel {
        [NameInMap("MasterZones")]
        [Validation(Required=false)]
        public List<string> MasterZones { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SlaveZones")]
        [Validation(Required=false)]
        public List<string> SlaveZones { get; set; }

    }

}
