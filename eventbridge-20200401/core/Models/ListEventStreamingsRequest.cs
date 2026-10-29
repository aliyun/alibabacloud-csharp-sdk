// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListEventStreamingsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the maximum number of entries to return per request. You can use this parameter together with NextToken to paginate results.&gt;Notice: The maximum number of entries returned per request cannot exceed 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The prefix of the event stream name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("NamePrefix")]
        [Validation(Required=false)]
        public string NamePrefix { get; set; }

        /// <summary>
        /// <para>The token that is returned when Limit is specified and additional results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ARN of the event target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:fc:cn-hangzhou:118609547428****:services/fw1.LATEST/functions/log1</para>
        /// </summary>
        [NameInMap("SinkArn")]
        [Validation(Required=false)]
        public string SinkArn { get; set; }

        /// <summary>
        /// <para>The ARN of the event source.</para>
        /// </summary>
        [NameInMap("SourceArn")]
        [Validation(Required=false)]
        public string SourceArn { get; set; }

        /// <summary>
        /// <para>The tags used to filter results.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListEventStreamingsRequestTags> Tags { get; set; }
        public class ListEventStreamingsRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mns</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mnstest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
