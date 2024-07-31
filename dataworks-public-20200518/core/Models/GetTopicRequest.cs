// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetTopicRequest : TeaModel {
        /// <summary>
        /// The event ID. You can call the [ListTopics](https://help.aliyun.com/document_detail/173973.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TopicId")]
        [Validation(Required=false)]
        public long? TopicId { get; set; }

    }

}
