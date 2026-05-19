// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileProtectClientEventDashboardResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileProtectClientEventDashboardResponseBodyData Data { get; set; }
        public class GetFileProtectClientEventDashboardResponseBodyData : TeaModel {
            [NameInMap("FilePathStats")]
            [Validation(Required=false)]
            public List<GetFileProtectClientEventDashboardResponseBodyDataFilePathStats> FilePathStats { get; set; }
            public class GetFileProtectClientEventDashboardResponseBodyDataFilePathStats : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>/usr/a</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Num")]
                [Validation(Required=false)]
                public long? Num { get; set; }

            }

            [NameInMap("FileTypeStats")]
            [Validation(Required=false)]
            public List<GetFileProtectClientEventDashboardResponseBodyDataFileTypeStats> FileTypeStats { get; set; }
            public class GetFileProtectClientEventDashboardResponseBodyDataFileTypeStats : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>txt</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Num")]
                [Validation(Required=false)]
                public long? Num { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("OneDayFileChangeCount")]
            [Validation(Required=false)]
            public int? OneDayFileChangeCount { get; set; }

            [NameInMap("ProcessNameStats")]
            [Validation(Required=false)]
            public List<GetFileProtectClientEventDashboardResponseBodyDataProcessNameStats> ProcessNameStats { get; set; }
            public class GetFileProtectClientEventDashboardResponseBodyDataProcessNameStats : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Num")]
                [Validation(Required=false)]
                public long? Num { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>33</para>
            /// </summary>
            [NameInMap("RecentFileChangeCount")]
            [Validation(Required=false)]
            public int? RecentFileChangeCount { get; set; }

            /// <summary>
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
