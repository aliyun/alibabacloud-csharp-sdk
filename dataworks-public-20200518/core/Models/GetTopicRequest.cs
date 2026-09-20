// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetTopicRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the event. You can call <a href="https://help.aliyun.com/document_detail/173973.html">listTopics</a> to obtain the ID.</para>
        /// <para>The documentation example is for format demonstration only. Valid TopicId values can be obtained from Data.Topics[].TopicId in the ListTopics response.</para>
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
