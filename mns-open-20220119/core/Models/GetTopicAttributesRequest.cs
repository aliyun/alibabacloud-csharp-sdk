// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetTopicAttributesRequest : TeaModel {
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<GetTopicAttributesRequestTag> Tag { get; set; }
        public class GetTopicAttributesRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-topic</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
