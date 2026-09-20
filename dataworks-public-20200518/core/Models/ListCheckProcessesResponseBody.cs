// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListCheckProcessesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListCheckProcessesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListCheckProcessesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The details of the extension check processes.</para>
            /// </summary>
            [NameInMap("CheckProcesses")]
            [Validation(Required=false)]
            public List<ListCheckProcessesResponseBodyPagingInfoCheckProcesses> CheckProcesses { get; set; }
            public class ListCheckProcessesResponseBodyPagingInfoCheckProcesses : TeaModel {
                /// <summary>
                /// <para>The event code of the extension point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>commit-file</para>
                /// </summary>
                [NameInMap("EventCode")]
                [Validation(Required=false)]
                public string EventCode { get; set; }

                /// <summary>
                /// <para>The name of the extension point event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DnsEvent</para>
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// <para>The English name of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Pre-event for Node Commit</para>
                /// </summary>
                [NameInMap("EventNameEn")]
                [Validation(Required=false)]
                public string EventNameEn { get; set; }

                /// <summary>
                /// <para>The message ID of the DataWorks open message. After an extension point event is triggered, you can obtain the message ID from the received event message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b824a5de-4223-4315-af3e-c4449d236db4</para>
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                /// <summary>
                /// <para>The ID of the operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>297635</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The process instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rdk_generate_d395da25-b0d3-4114-b2a5-d0247444a661_none_3496903_365203</para>
                /// </summary>
                [NameInMap("ProcessId")]
                [Validation(Required=false)]
                public string ProcessId { get; set; }

                /// <summary>
                /// <para>The name of the operation object, such as the file name or node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_sql_test</para>
                /// </summary>
                [NameInMap("ProcessName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

                /// <summary>
                /// <para>The ID of the DataWorks workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32563</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The check status of the extension. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CHECKING: The check is in progress.</description></item>
                /// <item><description>PASSED: The check is passed.</description></item>
                /// <item><description>BLOCKED: The check is not passed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CHECKING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
