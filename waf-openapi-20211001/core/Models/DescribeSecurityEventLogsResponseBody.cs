// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSecurityEventLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D827FCFE-90A7-4330-9326-******4C7726</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of detailed attack logs.</para>
        /// </summary>
        [NameInMap("SecurityEventLogs")]
        [Validation(Required=false)]
        public List<object> SecurityEventLogs { get; set; }

        /// <summary>
        /// <para>The total number of attack logs found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("SecurityEventLogsTotalCount")]
        [Validation(Required=false)]
        public long? SecurityEventLogsTotalCount { get; set; }

        /// <summary>
        /// <para>The metadata of the returned data.</para>
        /// </summary>
        [NameInMap("SecurityEventMetaData")]
        [Validation(Required=false)]
        public DescribeSecurityEventLogsResponseBodySecurityEventMetaData SecurityEventMetaData { get; set; }
        public class DescribeSecurityEventLogsResponseBodySecurityEventMetaData : TeaModel {
            /// <summary>
            /// <para>The time range used for the query.</para>
            /// </summary>
            [NameInMap("DateRange")]
            [Validation(Required=false)]
            public DescribeSecurityEventLogsResponseBodySecurityEventMetaDataDateRange DateRange { get; set; }
            public class DescribeSecurityEventLogsResponseBodySecurityEventMetaDataDateRange : TeaModel {
                /// <summary>
                /// <para>The end of the time range used for the query. The value is a UNIX timestamp. Unit: seconds. This value is the same as the \<c>EndDate\\</c> request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The start of the time range used for the query. The value is a UNIX timestamp. Unit: seconds. This value is the same as the \<c>StartDate\\</c> request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888000</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public long? StartDate { get; set; }

            }

            /// <summary>
            /// <para>The unit of the returned statistical data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>requests</para>
            /// </summary>
            [NameInMap("Units")]
            [Validation(Required=false)]
            public string Units { get; set; }

        }

    }

}
