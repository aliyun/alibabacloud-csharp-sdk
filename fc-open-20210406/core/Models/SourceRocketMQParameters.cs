// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class SourceRocketMQParameters : TeaModel {
        /// <summary>
        /// GroupID
        /// </summary>
        [NameInMap("GroupID")]
        [Validation(Required=false)]
        public string GroupID { get; set; }

        /// <summary>
        /// InstanceId
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Offset
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public string Offset { get; set; }

        /// <summary>
        /// RegionId
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Tag
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Timestamp
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Topic
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
