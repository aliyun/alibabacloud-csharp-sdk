// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryPushRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>Deprecated. This parameter is no longer used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i91D***********kXIh/dVBEQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
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
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public long? AppKey { get; set; }

                [NameInMap("Body")]
                [Validation(Required=false)]
                public string Body { get; set; }

                [NameInMap("DeviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                [NameInMap("PushTime")]
                [Validation(Required=false)]
                public string PushTime { get; set; }

                [NameInMap("PushType")]
                [Validation(Required=false)]
                public string PushType { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B24B396-249D-55E4-8CA1-66C9B50BB734</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>193</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
