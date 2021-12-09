// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ReplicationRule : TeaModel {
        /// <summary>
        /// A short description of action
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Destination")]
        [Validation(Required=false)]
        public ReplicationDestination Destination { get; set; }

        /// <summary>
        /// A short description of EncryptionConfiguration
        /// </summary>
        [NameInMap("EncryptionConfiguration")]
        [Validation(Required=false)]
        public ReplicationRuleEncryptionConfiguration EncryptionConfiguration { get; set; }
        public class ReplicationRuleEncryptionConfiguration : TeaModel {
            [NameInMap("ReplicaKmsKeyID")]
            [Validation(Required=false)]
            public string ReplicaKmsKeyID { get; set; }
        };

        /// <summary>
        /// A short description of HistoricalObjectReplication
        /// </summary>
        [NameInMap("HistoricalObjectReplication")]
        [Validation(Required=false)]
        public string HistoricalObjectReplication { get; set; }

        /// <summary>
        /// rule id
        /// </summary>
        [NameInMap("ID")]
        [Validation(Required=false)]
        public string ID { get; set; }

        [NameInMap("PrefixSet")]
        [Validation(Required=false)]
        public ReplicationPrefixSet PrefixSet { get; set; }

        [NameInMap("SourceSelectionCriteria")]
        [Validation(Required=false)]
        public ReplicationSourceSelectionCriteria SourceSelectionCriteria { get; set; }

        /// <summary>
        /// A short description of action
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// A short description of SyncRole
        /// </summary>
        [NameInMap("SyncRole")]
        [Validation(Required=false)]
        public string SyncRole { get; set; }

    }

}
