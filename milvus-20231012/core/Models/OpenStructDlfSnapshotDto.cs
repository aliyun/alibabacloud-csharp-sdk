// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class OpenStructDlfSnapshotDto : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("changelogRecordCount")]
        [Validation(Required=false)]
        public long? ChangelogRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>APPEND</para>
        /// </summary>
        [NameInMap("commitKind")]
        [Validation(Required=false)]
        public string CommitKind { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("deltaRecordCount")]
        [Validation(Required=false)]
        public long? DeltaRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("schemaId")]
        [Validation(Required=false)]
        public long? SchemaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("snapshotId")]
        [Validation(Required=false)]
        public long? SnapshotId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1711334400000</para>
        /// </summary>
        [NameInMap("timeMillis")]
        [Validation(Required=false)]
        public long? TimeMillis { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("totalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
