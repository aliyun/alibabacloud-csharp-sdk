// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListTopicsShrinkRequest : TeaModel {
        /// <summary>
        /// The condition that you want to use to filter topics in the instance. If you leave this parameter empty, all topics in the instance are queried.
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// The message types of the topics.
        /// </summary>
        [NameInMap("messageTypes")]
        [Validation(Required=false)]
        public string MessageTypesShrink { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
