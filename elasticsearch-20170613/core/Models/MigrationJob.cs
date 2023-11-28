// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class MigrationJob : TeaModel {
        [NameInMap("currentState")]
        [Validation(Required=false)]
        public string CurrentState { get; set; }

        [NameInMap("disableSourceClusterAuth")]
        [Validation(Required=false)]
        public bool? DisableSourceClusterAuth { get; set; }

        [NameInMap("disableTargetClusterAuth")]
        [Validation(Required=false)]
        public bool? DisableTargetClusterAuth { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("migrationJobId")]
        [Validation(Required=false)]
        public string MigrationJobId { get; set; }

        [NameInMap("phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("sourceCluster")]
        [Validation(Required=false)]
        public MigrationJobSourceCluster SourceCluster { get; set; }
        public class MigrationJobSourceCluster : TeaModel {
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("statusResult")]
        [Validation(Required=false)]
        public List<MigrationJobStatusResult> StatusResult { get; set; }
        public class MigrationJobStatusResult : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("targetCluster")]
        [Validation(Required=false)]
        public MigrationJobTargetCluster TargetCluster { get; set; }
        public class MigrationJobTargetCluster : TeaModel {
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
