// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListEventStreamingsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to be returned in a call. You can use this parameter and NextToken to implement paging. A maximum of 100 entries can be returned in a call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The name of the event stream that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("NamePrefix")]
        [Validation(Required=false)]
        public string NamePrefix { get; set; }

        /// <summary>
        /// <para>If you configure Limit and excess return values exist, this parameter is returned.</para>
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
        /// <para>The Alibaba Cloud Resource Name (ARN) of the event source.</para>
        /// </summary>
        [NameInMap("SourceArn")]
        [Validation(Required=false)]
        public string SourceArn { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListEventStreamingsRequestTags> Tags { get; set; }
        public class ListEventStreamingsRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
