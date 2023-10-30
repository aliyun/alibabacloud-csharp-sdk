// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class PublishFeatureViewTableRequest : TeaModel {
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("EventTime")]
        [Validation(Required=false)]
        public string EventTime { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("OfflineToOnline")]
        [Validation(Required=false)]
        public bool? OfflineToOnline { get; set; }

        [NameInMap("Partitions")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> Partitions { get; set; }

    }

}
