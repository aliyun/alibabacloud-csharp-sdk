// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListAKSNativeclusterResponseBody : TeaModel {
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
        public List<ListAKSNativeclusterResponseBodyData> Data { get; set; }
        public class ListAKSNativeclusterResponseBodyData : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("MasterClusterId")]
            [Validation(Required=false)]
            public string MasterClusterId { get; set; }

            [NameInMap("MinionClusterId")]
            [Validation(Required=false)]
            public string MinionClusterId { get; set; }

            [NameInMap("MinionClusterName")]
            [Validation(Required=false)]
            public string MinionClusterName { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("ZoneName")]
            [Validation(Required=false)]
            public string ZoneName { get; set; }

        }

    }

}
