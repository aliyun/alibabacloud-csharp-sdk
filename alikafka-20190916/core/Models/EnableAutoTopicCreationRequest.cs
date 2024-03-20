// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class EnableAutoTopicCreationRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Valid values:
        /// 
        /// *   enable: enables the automatic topic creation feature.
        /// *   disable: disables the automatic topic creation feature.
        /// *   updatePartition: changes the number of partitions in topics that are automatically created.
        /// </summary>
        [NameInMap("Operate")]
        [Validation(Required=false)]
        public string Operate { get; set; }

        /// <summary>
        /// The changed number of partitions in topics that are automatically created.
        /// 
        /// This parameter takes effect only if you set Operate to updatePartition.
        /// </summary>
        [NameInMap("PartitionNum")]
        [Validation(Required=false)]
        public long? PartitionNum { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
