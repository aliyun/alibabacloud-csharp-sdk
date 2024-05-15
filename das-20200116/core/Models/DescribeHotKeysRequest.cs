// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeHotKeysRequest : TeaModel {
        /// <summary>
        /// The ID of the ApsaraDB for Redis instance. You can call the [DescribeInstances](https://help.aliyun.com/document_detail/60933.html) operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the data shard on the ApsaraDB for Redis instance. You can call the [DescribeRoleZoneInfo](https://help.aliyun.com/document_detail/190794.html) operation to query the data shard ID.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
