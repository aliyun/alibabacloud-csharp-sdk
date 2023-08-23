// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerStatusRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query the details of the consumer group. Valid values:
        /// 
        /// *   **true**: The details of the consumer group are queried. You can obtain details from the **ConsumerConnectionInfoList** and **DetailInTopicList** response parameters.
        /// *   **false**: The details of the consumer group are not queried. The values of the **ConsumerConnectionInfoList** and **DetailInTopicList** response parameters are empty. This value is the default value of the Detail parameter.
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public bool? Detail { get; set; }

        /// <summary>
        /// The ID of the consumer group whose details you want to query.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The ID of the instance to which the consumer group belongs.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies whether to query the information about thread stack traces. Valid values:
        /// 
        /// *   **true**: The information about thread stack traces is queried. You can obtain the information from the **Jstack** response parameter.
        /// 
        /// > If you want to obtain the information about thread stack traces, make sure that the **Detail** parameter in the request is set to **true**.
        /// 
        /// *   **false**: The information about thread stack traces is not queried. The value of the **Jstack** response parameter is empty. This value is the default value of the NeedJstack parameter.
        /// </summary>
        [NameInMap("NeedJstack")]
        [Validation(Required=false)]
        public bool? NeedJstack { get; set; }

    }

}
