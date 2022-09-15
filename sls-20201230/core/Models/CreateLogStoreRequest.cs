// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateLogStoreRequest : TeaModel {
        [NameInMap("appendMeta")]
        [Validation(Required=false)]
        public bool? AppendMeta { get; set; }

        [NameInMap("autoSplit")]
        [Validation(Required=false)]
        public bool? AutoSplit { get; set; }

        [NameInMap("enable_tracking")]
        [Validation(Required=false)]
        public bool? EnableTracking { get; set; }

        [NameInMap("encrypt_conf")]
        [Validation(Required=false)]
        public EncryptConf EncryptConf { get; set; }

        [NameInMap("hot_ttl")]
        [Validation(Required=false)]
        public int? HotTtl { get; set; }

        [NameInMap("logstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        [NameInMap("maxSplitShard")]
        [Validation(Required=false)]
        public int? MaxSplitShard { get; set; }

        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("shardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        [NameInMap("telemetryType")]
        [Validation(Required=false)]
        public string TelemetryType { get; set; }

        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
