// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribePreloadDetailByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9D3257A-1B7C-414C-90C1-8D07AC47BCAC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of queried tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The details of the task, including the task ID, start time, end time, domain name, success rate, status, returned error code, and completion details of all URL resources.</para>
        /// </summary>
        [NameInMap("UrlDetails")]
        [Validation(Required=false)]
        public List<DescribePreloadDetailByIdResponseBodyUrlDetails> UrlDetails { get; set; }
        public class DescribePreloadDetailByIdResponseBodyUrlDetails : TeaModel {
            /// <summary>
            /// <para>The time when the task was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-23T02:26:56Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The domain name for prefetching resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The time when the task ended. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-23T02:27:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The progress of the prefetch task, which indicates the number of points of presence (POPs) on which the prefetch task is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

            /// <summary>
            /// <para>The turned error code. A value of <c>0</c> indicates that the task succeeded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetCode")]
            [Validation(Required=false)]
            public string RetCode { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Complete</b></description></item>
            /// <item><description><b>Refreshing</b></description></item>
            /// <item><description><b>Failed</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Complete</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the task that you want to query.</para>
            /// <para>You can call the PushObjectCache operation to query task IDs. Then, you can use the task IDs to query task status.</para>
            /// <para>You can query one task ID at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14286878547</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The completion details of all URL resources in the task.</para>
            /// </summary>
            [NameInMap("Urls")]
            [Validation(Required=false)]
            public List<DescribePreloadDetailByIdResponseBodyUrlDetailsUrls> Urls { get; set; }
            public class DescribePreloadDetailByIdResponseBodyUrlDetailsUrls : TeaModel {
                /// <summary>
                /// <para>The details of resource prefetch.</para>
                /// <list type="bullet">
                /// <item><description>If the resource is prefetched on all POPs, &quot;Successfully preloaded&quot; is returned.</description></item>
                /// <item><description>If the resource fails to be prefetched on some POPs, the failure details separated by vertical bars (|) are returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Successfully preloaded</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The success percentage, which indicates the number of POPs on which the resource is prefetched.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47%</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public string Success { get; set; }

                /// <summary>
                /// <para>The URL of the prefetched resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/abc.jpg</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}
