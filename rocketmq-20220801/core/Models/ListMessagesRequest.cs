// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListMessagesRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query time range. Format: YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-09 09:00:00</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The lite topic name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("liteTopicName")]
        [Validation(Required=false)]
        public string LiteTopicName { get; set; }

        /// <summary>
        /// <para>The message ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F00000100207A4F0F294A938F7807AE</para>
        /// </summary>
        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The message key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XSCBillResult</para>
        /// </summary>
        [NameInMap("messageKey")]
        [Validation(Required=false)]
        public string MessageKey { get; set; }

        /// <summary>
        /// <para>The current page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size. The maximum number of results to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The scroll ID for the request.</para>
        /// <para>You do not need to specify this parameter for the first page request. For subsequent page requests, specify this parameter based on the value returned from the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B13D0B07-F24B-4790-88D8-D47A38063D00</para>
        /// </summary>
        [NameInMap("scrollId")]
        [Validation(Required=false)]
        public string ScrollId { get; set; }

        /// <summary>
        /// <para>The start time of the query time range. Format: YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-09 08:00:00</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
