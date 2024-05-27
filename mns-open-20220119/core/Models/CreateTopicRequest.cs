// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class CreateTopicRequest : TeaModel {
        [NameInMap("EnableLogging")]
        [Validation(Required=false)]
        public bool? EnableLogging { get; set; }

        [NameInMap("MaxMessageSize")]
        [Validation(Required=false)]
        public long? MaxMessageSize { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTopicRequestTag> Tag { get; set; }
        public class CreateTopicRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
