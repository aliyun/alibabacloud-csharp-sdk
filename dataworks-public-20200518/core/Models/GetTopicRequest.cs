// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetTopicRequest : TeaModel {
        /// <summary>
        /// <para>The event ID. You can call the <a href="https://help.aliyun.com/document_detail/173973.html">ListTopics</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("TopicId")]
        [Validation(Required=false)]
        public long? TopicId { get; set; }

    }

}
