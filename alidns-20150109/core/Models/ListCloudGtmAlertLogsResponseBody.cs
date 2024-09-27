// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListCloudGtmAlertLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The alert logs.</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public ListCloudGtmAlertLogsResponseBodyLogs Logs { get; set; }
        public class ListCloudGtmAlertLogsResponseBodyLogs : TeaModel {
            [NameInMap("Log")]
            [Validation(Required=false)]
            public List<ListCloudGtmAlertLogsResponseBodyLogsLog> Log { get; set; }
            public class ListCloudGtmAlertLogsResponseBodyLogsLog : TeaModel {
                /// <summary>
                /// <para>Alert type:</para>
                /// <list type="bullet">
                /// <item><description>ALERT</description></item>
                /// <item><description>RESUME</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALERT</para>
                /// </summary>
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                /// <summary>
                /// <para>The alert content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The alert content.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Alarm object types:</para>
                /// <list type="bullet">
                /// <item><description>GTM_ADDRESS: Address</description></item>
                /// <item><description>GTM_ADDRESS_POOL: Address Pool</description></item>
                /// <item><description>GTM_INSTANCE: Instance</description></item>
                /// <item><description>GTM_MONITOR_TEMPLATE: Health Check Template</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GTM_ADDRESS</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <para>Alert log time (timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1711328826977</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>Current page number, starting from 1, default is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of rows per page when paginating queries, with a maximum value of 100 and a default of 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Unique request identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of alarm log entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
