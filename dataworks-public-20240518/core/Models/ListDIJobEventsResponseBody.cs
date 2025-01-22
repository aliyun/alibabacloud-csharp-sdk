// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDIJobEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDIJobEventsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDIJobEventsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The events returned. The value of this parameter is an array.</para>
            /// </summary>
            [NameInMap("DIJobEvent")]
            [Validation(Required=false)]
            public List<ListDIJobEventsResponseBodyPagingInfoDIJobEvent> DIJobEvent { get; set; }
            public class ListDIJobEventsResponseBodyPagingInfoDIJobEvent : TeaModel {
                /// <summary>
                /// <para>The processing result of the DDL event. Valid values: Critical, Ignore, Normal, and Warning.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ignore</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The alert notification method. Valid values: Phone, Mail, Sms, Ding, and Webhook.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Phone</para>
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public string Channels { get; set; }

                /// <summary>
                /// <para>The time when the event was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1663573162</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The alert details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aggregator:avg [**] for 5 minutes, service maybe abnormal</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>The DDL statement of the destination table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alter table table2 ***</para>
                /// </summary>
                [NameInMap("DstSql")]
                [Validation(Required=false)]
                public string DstSql { get; set; }

                /// <summary>
                /// <para>The name of the destination table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table2</para>
                /// </summary>
                [NameInMap("DstTable")]
                [Validation(Required=false)]
                public string DstTable { get; set; }

                /// <summary>
                /// <para>The error logs for failovers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-29 15:11:31,377 [main] INFO com.<em>.<b>.di.core.metrics.:21 []  {</b></em><em>} 
                /// 2024-05-29 15:11:31,384 [main] INFO <em>.aliyun.</em>.di.</em>.<em>.metrics.</em>:27 [] - Open MarioDiReporter 
                /// 2024-05-29 15:11:33,248 [flink-akka.<em>.</em>-dispatcher-17] INFO</para>
                /// </summary>
                [NameInMap("FailoverMessage")]
                [Validation(Required=false)]
                public string FailoverMessage { get; set; }

                /// <summary>
                /// <para>The event ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The severity level of the alert. Valid values: Warning and Critical.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Warning</para>
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// <para>The DDL statement of the source table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alter table table1 ***</para>
                /// </summary>
                [NameInMap("SrcSql")]
                [Validation(Required=false)]
                public string SrcSql { get; set; }

                /// <summary>
                /// <para>The name of the source table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table1</para>
                /// </summary>
                [NameInMap("SrcTable")]
                [Validation(Required=false)]
                public string SrcTable { get; set; }

                /// <summary>
                /// <para>The sending status of an alert notification. Valid values: Success, Fail, and Silence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the alert event.</para>
                /// <list type="bullet">
                /// <item><description>Heartbeat</description></item>
                /// <item><description>Delay</description></item>
                /// <item><description>FailoverCount</description></item>
                /// <item><description>DdlReport</description></item>
                /// <item><description>ResourceUtilization</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Delay</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

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
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2524</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can locate logs and troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>645F6D68-9C29-5961-80B1-BDD4B794C22D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
