// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerAccumulateRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query the details of each topic to which the consumer group subscribes. Valid values:
        /// 
        /// *   **true**: The details of each topic are queried. You can obtain the details from the **DetailInTopicList** response parameter.
        /// *   **false**: The details of each topic are not queried. This is the default value. If you use this value, the value of the **DetailInTopicList** response parameter is empty.
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public bool? Detail { get; set; }

        /// <summary>
        /// The ID of the consumer group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
