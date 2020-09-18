// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class GetVersionResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("FlowId")]
        [Validation(Required=true)]
        public string FlowId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("VersionName")]
        [Validation(Required=true)]
        public string VersionName { get; set; }

        [NameInMap("VersionDescription")]
        [Validation(Required=true)]
        public string VersionDescription { get; set; }

        [NameInMap("Definition")]
        [Validation(Required=true)]
        public string Definition { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=true)]
        public string CreateTime { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=true)]
        public string UpdateTime { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=true)]
        public int? VersionId { get; set; }

        [NameInMap("VersionStatus")]
        [Validation(Required=true)]
        public string VersionStatus { get; set; }

    }

}
