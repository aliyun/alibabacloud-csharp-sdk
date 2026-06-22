// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileProtectClientEventDashboardResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileProtectClientEventDashboardResponseBodyData Data { get; set; }
        public class GetFileProtectClientEventDashboardResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The tamper-proofing event statistics grouped by file path.</para>
            /// </summary>
            [NameInMap("FilePathStats")]
            [Validation(Required=false)]
            public List<GetFileProtectClientEventDashboardResponseBodyDataFilePathStats> FilePathStats { get; set; }
            public class GetFileProtectClientEventDashboardResponseBodyDataFilePathStats : TeaModel {
                /// <summary>
                /// <para>The file path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/a</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The total number of events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Num")]
                [Validation(Required=false)]
                public long? Num { get; set; }

            }

            /// <summary>
            /// <para>The event statistics grouped by file type.</para>
            /// </summary>
            [NameInMap("FileTypeStats")]
            [Validation(Required=false)]
            public List<GetFileProtectClientEventDashboardResponseBodyDataFileTypeStats> FileTypeStats { get; set; }
            public class GetFileProtectClientEventDashboardResponseBodyDataFileTypeStats : TeaModel {
                /// <summary>
                /// <para>The file type name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>txt</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Num")]
                [Validation(Required=false)]
                public long? Num { get; set; }

            }

            /// <summary>
            /// <para>The number of file tamper-proofing events for today.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("OneDayFileChangeCount")]
            [Validation(Required=false)]
            public int? OneDayFileChangeCount { get; set; }

            /// <summary>
            /// <para>The event statistics grouped by process name.</para>
            /// </summary>
            [NameInMap("ProcessNameStats")]
            [Validation(Required=false)]
            public List<GetFileProtectClientEventDashboardResponseBodyDataProcessNameStats> ProcessNameStats { get; set; }
            public class GetFileProtectClientEventDashboardResponseBodyDataProcessNameStats : TeaModel {
                /// <summary>
                /// <para>The process name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The number of events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Num")]
                [Validation(Required=false)]
                public long? Num { get; set; }

            }

            /// <summary>
            /// <para>The number of file tamper-proofing events in the last 15 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33</para>
            /// </summary>
            [NameInMap("RecentFileChangeCount")]
            [Validation(Required=false)]
            public int? RecentFileChangeCount { get; set; }

            /// <summary>
            /// <para>The number of affected servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("ServerCount")]
            [Validation(Required=false)]
            public int? ServerCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5CF78A7-30AA-59DB-847F-13EE3AE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
