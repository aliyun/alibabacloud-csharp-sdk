// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListDisasterRecoveryItemsRequest : TeaModel {
        /// <summary>
        /// <para>The filter condition. Topics are filtered by topic name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic_test</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The topic name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic-test920</para>
        /// </summary>
        [NameInMap("topicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
