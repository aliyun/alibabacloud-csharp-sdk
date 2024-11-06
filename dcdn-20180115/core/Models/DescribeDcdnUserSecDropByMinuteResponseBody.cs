// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserSecDropByMinuteResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of HTTP responses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Len")]
        [Validation(Required=false)]
        public int? Len { get; set; }

        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8143fA8A-B2B2-4915-538D-546B538D25FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array.</para>
        /// </summary>
        [NameInMap("Rows")]
        [Validation(Required=false)]
        public List<DescribeDcdnUserSecDropByMinuteResponseBodyRows> Rows { get; set; }
        public class DescribeDcdnUserSecDropByMinuteResponseBodyRows : TeaModel {
            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.aliyundoc.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The number of packets blocked within 5 minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>264</para>
            /// </summary>
            [NameInMap("Drops")]
            [Validation(Required=false)]
            public int? Drops { get; set; }

            /// <summary>
            /// <para>The object that triggered rate limiting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal Mode</para>
            /// </summary>
            [NameInMap("Object")]
            [Validation(Required=false)]
            public string Object { get; set; }

            /// <summary>
            /// <para>The rule that was triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal Mode</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The security feature that blocked the packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>robot</para>
            /// </summary>
            [NameInMap("SecFunc")]
            [Validation(Required=false)]
            public string SecFunc { get; set; }

            /// <summary>
            /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-31T15:04:04Z</para>
            /// </summary>
            [NameInMap("TmStr")]
            [Validation(Required=false)]
            public string TmStr { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5738</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
