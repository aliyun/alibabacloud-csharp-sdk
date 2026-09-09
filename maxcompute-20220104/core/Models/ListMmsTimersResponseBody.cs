// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListMmsTimersResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMmsTimersResponseBodyData Data { get; set; }
        public class ListMmsTimersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of timers.</para>
            /// </summary>
            [NameInMap("objectList")]
            [Validation(Required=false)]
            public List<ListMmsTimersResponseBodyDataObjectList> ObjectList { get; set; }
            public class ListMmsTimersResponseBodyDataObjectList : TeaModel {
                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-17 09:29:58</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The source database ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>196</para>
                /// </summary>
                [NameInMap("dbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>The timer ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The timer name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>migrate_db_1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The schedule type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Daily</para>
                /// </summary>
                [NameInMap("scheduleType")]
                [Validation(Required=false)]
                public string ScheduleType { get; set; }

                /// <summary>
                /// <para>The data source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000015</para>
                /// </summary>
                [NameInMap("sourceId")]
                [Validation(Required=false)]
                public long? SourceId { get; set; }

                /// <summary>
                /// <para>The source database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db_1</para>
                /// </summary>
                [NameInMap("srcDbName")]
                [Validation(Required=false)]
                public string SrcDbName { get; set; }

                /// <summary>
                /// <para>Indicates whether the timer is stopped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("stopped")]
                [Validation(Required=false)]
                public bool? Stopped { get; set; }

                /// <summary>
                /// <para>The job type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TABLES</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The schedule time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b87b7e716665825896565060e87a4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
