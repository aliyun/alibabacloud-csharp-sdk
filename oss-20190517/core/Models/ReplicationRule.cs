// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ReplicationRule : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Destination")]
        [Validation(Required=false)]
        public ReplicationDestination Destination { get; set; }

        [NameInMap("EncryptionConfiguration")]
        [Validation(Required=false)]
        public ReplicationRuleEncryptionConfiguration EncryptionConfiguration { get; set; }
        public class ReplicationRuleEncryptionConfiguration : TeaModel {
            [NameInMap("ReplicaKmsKeyID")]
            [Validation(Required=false)]
            public string ReplicaKmsKeyID { get; set; }
        };

        [NameInMap("HistoricalObjectReplication")]
        [Validation(Required=false)]
        public string HistoricalObjectReplication { get; set; }

        [NameInMap("ID")]
        [Validation(Required=false)]
        public string ID { get; set; }

        [NameInMap("PrefixSet")]
        [Validation(Required=false)]
        public ReplicationPrefixSet PrefixSet { get; set; }

        [NameInMap("SourceSelectionCriteria")]
        [Validation(Required=false)]
        public ReplicationSourceSelectionCriteria SourceSelectionCriteria { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SyncRole")]
        [Validation(Required=false)]
        public string SyncRole { get; set; }

    }

}
