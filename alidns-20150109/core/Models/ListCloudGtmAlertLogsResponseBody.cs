// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListCloudGtmAlertLogsResponseBody : TeaModel {
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public ListCloudGtmAlertLogsResponseBodyLogs Logs { get; set; }
        public class ListCloudGtmAlertLogsResponseBodyLogs : TeaModel {
            [NameInMap("Log")]
            [Validation(Required=false)]
            public List<ListCloudGtmAlertLogsResponseBodyLogsLog> Log { get; set; }
            public class ListCloudGtmAlertLogsResponseBodyLogsLog : TeaModel {
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The current page number. The value starts from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page. The maximum value is 100. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of alert logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
