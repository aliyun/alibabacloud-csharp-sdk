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
        /// <para>D827FCFE-90A7-4330-9326-D33C8B4C7726</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The attack logs returned.</para>
        /// </summary>
        [NameInMap("SecurityEventLogs")]
        [Validation(Required=false)]
        public List<object> SecurityEventLogs { get; set; }

        /// <summary>
        /// <para>The total number of logs returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("SecurityEventLogsTotalCount")]
        [Validation(Required=false)]
        public long? SecurityEventLogsTotalCount { get; set; }

        /// <summary>
        /// <para>The metadata of the time series data returned.</para>
        /// </summary>
        [NameInMap("SecurityEventMetaData")]
        [Validation(Required=false)]
        public DescribeSecurityEventLogsResponseBodySecurityEventMetaData SecurityEventMetaData { get; set; }
        public class DescribeSecurityEventLogsResponseBodySecurityEventMetaData : TeaModel {
            /// <summary>
            /// <para>The time range that is used for the query.</para>
            /// </summary>
            [NameInMap("DateRange")]
            [Validation(Required=false)]
            public DescribeSecurityEventLogsResponseBodySecurityEventMetaDataDateRange DateRange { get; set; }
            public class DescribeSecurityEventLogsResponseBodySecurityEventMetaDataDateRange : TeaModel {
                /// <summary>
                /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: seconds. This value is the same as the value of EndDate in the request parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds. This value is the same as the value of StartDate in the request parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888000</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public long? StartDate { get; set; }

            }

            /// <summary>
            /// <para>The unit of the statistics returned. The value is fixed as requests.</para>
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
