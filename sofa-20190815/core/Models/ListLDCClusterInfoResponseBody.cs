// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLDCClusterInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListLDCClusterInfoResponseBodyData> Data { get; set; }
        public class ListLDCClusterInfoResponseBodyData : TeaModel {
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            [NameInMap("IsHealthy")]
            [Validation(Required=false)]
            public bool? IsHealthy { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

            [NameInMap("ZoneName")]
            [Validation(Required=false)]
            public string ZoneName { get; set; }

        }

    }

}
