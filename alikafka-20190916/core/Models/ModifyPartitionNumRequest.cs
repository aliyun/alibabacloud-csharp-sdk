// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class ModifyPartitionNumRequest : TeaModel {
        /// <summary>
        /// The number of partitions that you want to add to the topic.
        /// 
        /// *   The value must be an integer that is greater than 0.
        /// *   To reduce the risk of data skew, we recommend that you set the value to a multiple of 6.
        /// *   The number of total partitions ranges from 1 to 360.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AddPartitionNum")]
        [Validation(Required=false)]
        public int? AddPartitionNum { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The topic name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
