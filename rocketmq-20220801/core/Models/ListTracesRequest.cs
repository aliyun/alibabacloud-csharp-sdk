// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListTracesRequest : TeaModel {
        /// <summary>
        /// <para>The end time in YYYY-MM-DD HH:mm:ss format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-19 10:10:09</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The lightweight topic name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("liteTopicName")]
        [Validation(Required=false)]
        public string LiteTopicName { get; set; }

        /// <summary>
        /// <para>The message ID.</para>
        /// <para>Required if queryType is set to MESSAGE_ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0100163E0EC1F1965C04C7906700000000</para>
        /// </summary>
        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The message key.</para>
        /// <para>Required if queryType is set to MESSAGE_KEY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_ceating</para>
        /// </summary>
        [NameInMap("messageKey")]
        [Validation(Required=false)]
        public string MessageKey { get; set; }

        /// <summary>
        /// <para>The page number of the returned results.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of results to display per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MESSAGE_ID</para>
        /// </summary>
        [NameInMap("queryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The start time in YYYY-MM-DD HH:mm:ss format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-10 10:42:11</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
