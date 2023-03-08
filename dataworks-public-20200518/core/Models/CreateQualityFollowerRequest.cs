// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateQualityFollowerRequest : TeaModel {
        /// <summary>
        /// The notification method. Valid values: 1, 2, 4, and 5. 1 indicates that the notification is sent by email. 2 indicates that the notification is sent by email and text message. 4 indicates that the notification is sent by a DingTalk chatbot. 5 indicates that the notification is sent by a DingTalk chatbot to all members in a DingTalk group.
        /// </summary>
        [NameInMap("AlarmMode")]
        [Validation(Required=false)]
        public int? AlarmMode { get; set; }

        /// <summary>
        /// The ID of the partition filter expression.
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// The user ID of the subscriber.
        /// </summary>
        [NameInMap("Follower")]
        [Validation(Required=false)]
        public string Follower { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The name of the computing engine instance or data source.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
