// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListAutoSnapshotPolicyAppliedDbfsResponseBody : TeaModel {
        [NameInMap("DbfsList")]
        [Validation(Required=false)]
        public List<ListAutoSnapshotPolicyAppliedDbfsResponseBodyDbfsList> DbfsList { get; set; }
        public class ListAutoSnapshotPolicyAppliedDbfsResponseBodyDbfsList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dbfs-ejdvesb0qvuywvg*******</para>
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
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("SizeG")]
            [Validation(Required=false)]
            public long? SizeG { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SnapshotCount")]
            [Validation(Required=false)]
            public int? SnapshotCount { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
