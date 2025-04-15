// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListTopicsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The filter condition for the query. If not provided, all topics under the instance will be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic_test</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The message type of the topic.</para>
        /// </summary>
        [NameInMap("messageTypes")]
        [Validation(Required=false)]
        public string MessageTypesShrink { get; set; }

        /// <summary>
        /// <para>Page number, indicating which page of results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, the maximum number of results to display per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
