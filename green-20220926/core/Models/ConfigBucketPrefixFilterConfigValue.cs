// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ConfigBucketPrefixFilterConfigValue : TeaModel {
        [NameInMap("PrefixFilterType")]
        [Validation(Required=false)]
        public string PrefixFilterType { get; set; }

        [NameInMap("PrefixFilters")]
        [Validation(Required=false)]
        public List<string> PrefixFilters { get; set; }

    }

}
