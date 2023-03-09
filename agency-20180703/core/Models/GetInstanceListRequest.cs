// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetInstanceListRequest : TeaModel {
        [NameInMap("Ak")]
        [Validation(Required=false)]
        public string Ak { get; set; }

        [NameInMap("AliyunPk")]
        [Validation(Required=false)]
        public long? AliyunPk { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PublicIpAddresse")]
        [Validation(Required=false)]
        public string PublicIpAddresse { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Sk")]
        [Validation(Required=false)]
        public string Sk { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public int? Tag { get; set; }

    }

}
