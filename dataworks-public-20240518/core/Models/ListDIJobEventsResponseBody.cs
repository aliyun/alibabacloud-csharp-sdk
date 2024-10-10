// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDIJobEventsResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDIJobEventsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDIJobEventsResponseBodyPagingInfo : TeaModel {
            [NameInMap("DIJobEvent")]
            [Validation(Required=false)]
            public List<ListDIJobEventsResponseBodyPagingInfoDIJobEvent> DIJobEvent { get; set; }
            public class ListDIJobEventsResponseBodyPagingInfoDIJobEvent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Ignore</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Phone</para>
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public string Channels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1663573162</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alter table table2 ***</para>
                /// </summary>
                [NameInMap("DstSql")]
                [Validation(Required=false)]
                public string DstSql { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>table2</para>
                /// </summary>
                [NameInMap("DstTable")]
                [Validation(Required=false)]
                public string DstTable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-29 15:11:31,377 [main] INFO com.<em>.<b>.di.core.metrics.:21 []  {</b></em><em>} 
                /// 2024-05-29 15:11:31,384 [main] INFO <em>.aliyun.</em>.di.</em>.<em>.metrics.</em>:27 [] - Open MarioDiReporter 
                /// 2024-05-29 15:11:33,248 [flink-akka.<em>.</em>-dispatcher-17] INFO</para>
                /// </summary>
                [NameInMap("FailoverMessage")]
                [Validation(Required=false)]
                public string FailoverMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Warning</para>
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alter table table1 ***</para>
                /// </summary>
                [NameInMap("SrcSql")]
                [Validation(Required=false)]
                public string SrcSql { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>table1</para>
                /// </summary>
                [NameInMap("SrcTable")]
                [Validation(Required=false)]
                public string SrcTable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Delay</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2524</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>645F6D68-9C29-5961-80B1-BDD4B794C22D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
