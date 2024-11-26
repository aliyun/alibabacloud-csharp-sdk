// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qianzhou20211111.Models
{
    public class GetClusterResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetClusterResponseBodyData Data { get; set; }
        public class GetClusterResponseBodyData : TeaModel {
            [NameInMap("clusterID")]
            [Validation(Required=false)]
            public string ClusterID { get; set; }

            [NameInMap("clusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            [NameInMap("currentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

            [NameInMap("regionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            [NameInMap("securityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("userID")]
            [Validation(Required=false)]
            public string UserID { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
