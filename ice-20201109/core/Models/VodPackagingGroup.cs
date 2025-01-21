// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class VodPackagingGroup : TeaModel {
        [NameInMap("ApproximateAssetCount")]
        [Validation(Required=false)]
        public long? ApproximateAssetCount { get; set; }

        [NameInMap("ConfigurationCount")]
        [Validation(Required=false)]
        public long? ConfigurationCount { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
