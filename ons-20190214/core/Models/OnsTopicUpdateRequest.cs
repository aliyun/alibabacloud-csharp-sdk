// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicUpdateRequest : TeaModel {
        /// <summary>
        /// The ID of the instance to which the topic belongs.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The read/write mode that you want to configure for the topic. Valid values:
        /// 
        /// *   **6:** Both read and write operations are allowed.
        /// *   **4:** Write operations are forbidden.
        /// *   **2:** Read operations are forbidden.
        /// </summary>
        [NameInMap("Perm")]
        [Validation(Required=false)]
        public int? Perm { get; set; }

        /// <summary>
        /// The name of the topic that you want to manage.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
