// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListSnapshotResponseBody : TeaModel {
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

        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<ListSnapshotResponseBodySnapshots> Snapshots { get; set; }
        public class ListSnapshotResponseBodySnapshots : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1609330367000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1609330367000</para>
            /// </summary>
            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>38</para>
            /// </summary>
            [NameInMap("RemainTime")]
            [Validation(Required=false)]
            public int? RemainTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("RetentionDays")]
            [Validation(Required=false)]
            public int? RetentionDays { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>s-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testSnapshotName</para>
            /// </summary>
            [NameInMap("SnapshotName")]
            [Validation(Required=false)]
            public string SnapshotName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("SnapshotType")]
            [Validation(Required=false)]
            public string SnapshotType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dbfs-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("SourceFsId")]
            [Validation(Required=false)]
            public string SourceFsId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("SourceFsSize")]
            [Validation(Required=false)]
            public int? SourceFsSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SourceFsStripeWidth")]
            [Validation(Required=false)]
            public int? SourceFsStripeWidth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>accomplished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
