// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class FeatureViewConfigValue : TeaModel {
        [NameInMap("Partitions")]
        [Validation(Required=false)]
        public Dictionary<string, FeatureViewConfigValuePartitionsValue> Partitions { get; set; }

        [NameInMap("EventTime")]
        [Validation(Required=false)]
        public string EventTime { get; set; }

        [NameInMap("Equal")]
        [Validation(Required=false)]
        public bool? Equal { get; set; }

    }

}
