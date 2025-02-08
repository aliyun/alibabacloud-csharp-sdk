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
            /// <para>The check details of the extension.</para>
            /// </summary>
            [NameInMap("CheckProcesses")]
            [Validation(Required=false)]
            public List<ListCheckProcessesResponseBodyPagingInfoCheckProcesses> CheckProcesses { get; set; }
            public class ListCheckProcessesResponseBodyPagingInfoCheckProcesses : TeaModel {
                /// <summary>
                /// <para>Extension point event encoding.</para>
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
                /// <para>DataWorks the message ID of the open message. After an extended point event is triggered, you can obtain the message ID from the received event message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b824a5de-4223-4315-af3e-c4449d236db4</para>
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                /// <summary>
                /// <para>The operator ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>297635</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The ID of the process instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rdk_generate_d395da25-b0d3-4114-b2a5-d0247444a661_none_3496903_365203</para>
                /// </summary>
                [NameInMap("ProcessId")]
                [Validation(Required=false)]
                public string ProcessId { get; set; }

                /// <summary>
                /// <para>The name of the check object, such as the file name or node name.</para>
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
                /// <para>The status of the extender check.</para>
                /// <list type="bullet">
                /// <item><description>CHECKING CHECKING</description></item>
                /// <item><description>PASSED the pass check</description></item>
                /// <item><description>BLOCKED check failed</description></item>
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
            /// <para>The number of entries displayed on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
