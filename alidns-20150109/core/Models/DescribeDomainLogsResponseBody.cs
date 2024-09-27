// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation logs.</para>
        /// </summary>
        [NameInMap("DomainLogs")]
        [Validation(Required=false)]
        public DescribeDomainLogsResponseBodyDomainLogs DomainLogs { get; set; }
        public class DescribeDomainLogsResponseBodyDomainLogs : TeaModel {
            [NameInMap("DomainLog")]
            [Validation(Required=false)]
            public List<DescribeDomainLogsResponseBodyDomainLogsDomainLog> DomainLog { get; set; }
            public class DescribeDomainLogsResponseBodyDomainLogsDomainLog : TeaModel {
                /// <summary>
                /// <para>The operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Add</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The time when the operation is performed. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-12T09:23Z</para>
                /// </summary>
                [NameInMap("ActionTime")]
                [Validation(Required=false)]
                public string ActionTime { get; set; }

                /// <summary>
                /// <para>The time when the operation was performed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>143562300000</para>
                /// </summary>
                [NameInMap("ActionTimestamp")]
                [Validation(Required=false)]
                public long? ActionTimestamp { get; set; }

                /// <summary>
                /// <para>The IP address of the operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>182.92.253.20</para>
                /// </summary>
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The message for the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>To the DNS record list</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The ID of the private zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cxfd345sd234</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
