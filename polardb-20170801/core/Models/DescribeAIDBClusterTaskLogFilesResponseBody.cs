// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterTaskLogFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The end time of the query. The time is displayed in the ISO 8601 standard in the <c>YYYY-MM-DDTHH:mm:ssZ</c> format. The time is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-15T15:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The list of logs.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeAIDBClusterTaskLogFilesResponseBodyItems Items { get; set; }
        public class DescribeAIDBClusterTaskLogFilesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The SLS log information.</para>
            /// </summary>
            [NameInMap("SlsLogItems")]
            [Validation(Required=false)]
            public List<DescribeAIDBClusterTaskLogFilesResponseBodyItemsSlsLogItems> SlsLogItems { get; set; }
            public class DescribeAIDBClusterTaskLogFilesResponseBodyItemsSlsLogItems : TeaModel {
                /// <summary>
                /// <para>The log time. The time is displayed in the ISO 8601 standard in UTC. The seconds can contain a fractional part.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-15T14:13:50.830295892Z</para>
                /// </summary>
                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public string LogTime { get; set; }

                /// <summary>
                /// <para>The log message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The specific time point of the monitoring metrics. The format is a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1765677660</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the query conditions. This parameter is optional and may not be returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E2FE3BB-C677-5FF9-9FC5-9CF364BD6BE5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-15T14:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
