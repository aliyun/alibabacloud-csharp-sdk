// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListSnapshotRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SnapshotId</para>
        /// </summary>
        [NameInMap("FilterKey")]
        [Validation(Required=false)]
        public string FilterKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>s-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("FilterValue")]
        [Validation(Required=false)]
        public string FilterValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dbfs-GOrr********Yd0VLOyBpg</para>
        /// </summary>
        [NameInMap("FsId")]
        [Validation(Required=false)]
        public string FsId { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;s-bp67acfmxazb4p****&quot;, &quot;s-bp67acfmxazb5p****&quot;, … &quot;s-bp67acfmxazb6p****&quot;]</para>
        /// </summary>
        [NameInMap("SnapshotIds")]
        [Validation(Required=false)]
        public string SnapshotIds { get; set; }

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
        /// <para>SnapshotSize</para>
        /// </summary>
        [NameInMap("SortKey")]
        [Validation(Required=false)]
        public string SortKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>accomplished</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
