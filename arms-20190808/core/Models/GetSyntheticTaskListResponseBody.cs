// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSyntheticTaskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The query results.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetSyntheticTaskListResponseBodyPageInfo PageInfo { get; set; }
        public class GetSyntheticTaskListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>Indicates whether the current page is followed by a page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasNextPage")]
            [Validation(Required=false)]
            public string HasNextPage { get; set; }

            /// <summary>
            /// <para>Indicates whether a previous page exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasPreviousPage")]
            [Validation(Required=false)]
            public bool? HasPreviousPage { get; set; }

            /// <summary>
            /// <para>Indicates whether the page is the first page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsFirstPage")]
            [Validation(Required=false)]
            public bool? IsFirstPage { get; set; }

            /// <summary>
            /// <para>Indicates whether the page is the last page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsLastPage")]
            [Validation(Required=false)]
            public bool? IsLastPage { get; set; }

            /// <summary>
            /// <para>The task information.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetSyntheticTaskListResponseBodyPageInfoList> List { get; set; }
            public class GetSyntheticTaskListResponseBodyPageInfoList : TeaModel {
                /// <summary>
                /// <para>The time when the task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1634005438000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The number of detection points.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MonitorNumber")]
                [Validation(Required=false)]
                public long? MonitorNumber { get; set; }

                /// <summary>
                /// <para>The ID of the synthetic monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2118709</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>net-test</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>The status of the task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The task is stopped.</description></item>
                /// <item><description><b>1</b>: The task is started.</description></item>
                /// <item><description><b>9</b>: The task is ended.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                /// <summary>
                /// <para>The type of the task. Valid values:</para>
                /// <ol>
                /// <item><description>3: web page performance - IE</description></item>
                /// <item><description>34: web page performance - Chrome</description></item>
                /// <item><description>0: network quality</description></item>
                /// <item><description>40: file download</description></item>
                /// <item><description>7: API performance</description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public long? TaskType { get; set; }

                /// <summary>
                /// <para>The name of the task type.</para>
                /// </summary>
                [NameInMap("TaskTypeName")]
                [Validation(Required=false)]
                public string TaskTypeName { get; set; }

                /// <summary>
                /// <para>The URL for synthetic monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The availability. Only the data of the last day is counted. If no data is available for the last day, an empty value is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.80</para>
                /// </summary>
                [NameInMap("Usable")]
                [Validation(Required=false)]
                public float? Usable { get; set; }

            }

            /// <summary>
            /// <para>The first page on the navigation bar.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NavigateFirstPage")]
            [Validation(Required=false)]
            public string NavigateFirstPage { get; set; }

            /// <summary>
            /// <para>The last page on the navigation bar.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("NavigateLastPage")]
            [Validation(Required=false)]
            public string NavigateLastPage { get; set; }

            /// <summary>
            /// <para>All navigation page numbers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1,2,3</para>
            /// </summary>
            [NameInMap("NavigatePageNums")]
            [Validation(Required=false)]
            public string NavigatePageNums { get; set; }

            /// <summary>
            /// <para>The next page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("NextPage")]
            [Validation(Required=false)]
            public string NextPage { get; set; }

            /// <summary>
            /// <para>The total number of pages returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Pages")]
            [Validation(Required=false)]
            public string Pages { get; set; }

            /// <summary>
            /// <para>The previous page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Prepage")]
            [Validation(Required=false)]
            public string Prepage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5EC8221-08F2-4C95-9AF1-49FD998C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
