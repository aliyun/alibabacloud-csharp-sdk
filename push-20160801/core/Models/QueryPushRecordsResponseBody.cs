// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryPushRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>i91D***********kXIh/dVBEQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PushInfos")]
        [Validation(Required=false)]
        public QueryPushRecordsResponseBodyPushInfos PushInfos { get; set; }
        public class QueryPushRecordsResponseBodyPushInfos : TeaModel {
            [NameInMap("PushInfo")]
            [Validation(Required=false)]
            public List<QueryPushRecordsResponseBodyPushInfosPushInfo> PushInfo { get; set; }
            public class QueryPushRecordsResponseBodyPushInfosPushInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>333526247</para>
                /// </summary>
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public long? AppKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abcd</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public string Body { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ANDROID</para>
                /// </summary>
                [NameInMap("DeviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>510431</para>
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-09-15T02:05:24Z</para>
                /// </summary>
                [NameInMap("PushTime")]
                [Validation(Required=false)]
                public string PushTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NOTICE</para>
                /// </summary>
                [NameInMap("PushType")]
                [Validation(Required=false)]
                public string PushType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DEVICE</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SENT</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DEVICE</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sssss</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9B24B396-249D-55E4-8CA1-66C9B50BB734</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>193</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
