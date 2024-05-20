// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListReleaseVersionsRequest : TeaModel {
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("releaseType")]
        [Validation(Required=false)]
        public string ReleaseType { get; set; }

        [NameInMap("releaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        [NameInMap("releaseVersionStatus")]
        [Validation(Required=false)]
        public string ReleaseVersionStatus { get; set; }

    }

}
