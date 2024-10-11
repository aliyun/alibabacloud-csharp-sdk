// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListSnapshotLinksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotLinks")]
        [Validation(Required=false)]
        public List<ListSnapshotLinksResponseBodySnapshotLinks> SnapshotLinks { get; set; }
        public class ListSnapshotLinksResponseBodySnapshotLinks : TeaModel {
            [NameInMap("EcsList")]
            [Validation(Required=false)]
            public List<ListSnapshotLinksResponseBodySnapshotLinksEcsList> EcsList { get; set; }
            public class ListSnapshotLinksResponseBodySnapshotLinksEcsList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>i-bp1f4eo2biro*******</para>
                /// </summary>
                [NameInMap("EcsId")]
                [Validation(Required=false)]
                public string EcsId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dbfs-q7qsgyqptjk******</para>
            /// </summary>
            [NameInMap("FsId")]
            [Validation(Required=false)]
            public string FsId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("FsName")]
            [Validation(Required=false)]
            public string FsName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sl-b3zlgraysgcs9jy*******</para>
            /// </summary>
            [NameInMap("LinkId")]
            [Validation(Required=false)]
            public string LinkId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SnapshotCount")]
            [Validation(Required=false)]
            public int? SnapshotCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("SourceSize")]
            [Validation(Required=false)]
            public int? SourceSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>attached</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50331648</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
