// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Snapshot : TeaModel {
        /// <summary>
        /// <para>The file name of the base manifest list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manifest-list-0c6fcaa1-b6bc-413d-9634-6471cce4f37e-2</para>
        /// </summary>
        [NameInMap("baseManifestList")]
        [Validation(Required=false)]
        public string BaseManifestList { get; set; }

        /// <summary>
        /// <para>The file name of the manifest list that records all changelogs generated for the snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manifest-list-0c6fcaa1-b6bc-413d-9634-6471cce4f37e-4</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("changelogManifestList")]
        [Validation(Required=false)]
        public string ChangelogManifestList { get; set; }

        /// <summary>
        /// <para>The number of changelog records generated for the snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("changelogRecordCount")]
        [Validation(Required=false)]
        public long? ChangelogRecordCount { get; set; }

        /// <summary>
        /// <para>The transaction ID of the streaming write.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9223372036854775807</para>
        /// </summary>
        [NameInMap("commitIdentifier")]
        [Validation(Required=false)]
        public long? CommitIdentifier { get; set; }

        /// <summary>
        /// <para>The streaming write type. Valid values: APPEND, COMPACT, OVERWRITE, and ANALYZE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPACT</para>
        /// </summary>
        [NameInMap("commitKind")]
        [Validation(Required=false)]
        public string CommitKind { get; set; }

        /// <summary>
        /// <para>The commit user, which is typically a UUID used to resume streaming writes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>446aac61-bd5c-4fa0-8b14-846fa8810651</para>
        /// </summary>
        [NameInMap("commitUser")]
        [Validation(Required=false)]
        public string CommitUser { get; set; }

        /// <summary>
        /// <para>The file name of the manifest list that records all new changes in the snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manifest-list-0c6fcaa1-b6bc-413d-9634-6471cce4f37e-3</para>
        /// </summary>
        [NameInMap("deltaManifestList")]
        [Validation(Required=false)]
        public string DeltaManifestList { get; set; }

        /// <summary>
        /// <para>The number of new change records in the snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("deltaRecordCount")]
        [Validation(Required=false)]
        public long? DeltaRecordCount { get; set; }

        /// <summary>
        /// <para>The snapshot ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The string representation of the snapshot ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("idString")]
        [Validation(Required=false)]
        public string IdString { get; set; }

        /// <summary>
        /// <para>The file name of the manifest that records all index files of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>index-manifest-7cbdaa47-9578-43ac-ae6e-a7ec0486bba8-0</para>
        /// </summary>
        [NameInMap("indexManifest")]
        [Validation(Required=false)]
        public string IndexManifest { get; set; }

        /// <summary>
        /// <para>The log offsets at the time of the commit.</para>
        /// </summary>
        [NameInMap("logOffsets")]
        [Validation(Required=false)]
        public Dictionary<string, long?> LogOffsets { get; set; }

        /// <summary>
        /// <para>The string representation of the parent snapshot ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("parentIdString")]
        [Validation(Required=false)]
        public string ParentIdString { get; set; }

        /// <summary>
        /// <para>The schema ID of the table when the snapshot was generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("schemaId")]
        [Validation(Required=false)]
        public long? SchemaId { get; set; }

        /// <summary>
        /// <para>The snapshot sequence number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("sequenceNumber")]
        [Validation(Required=false)]
        public long? SequenceNumber { get; set; }

        /// <summary>
        /// <para>The file name of the table statistics information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stat-82c50592-2179-447b-906b-6fdb10ef32c6-0</para>
        /// </summary>
        [NameInMap("statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        /// <summary>
        /// <para>The summary.</para>
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public Dictionary<string, string> Summary { get; set; }

        /// <summary>
        /// <para>The commit time, which is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741701564261</para>
        /// </summary>
        [NameInMap("timeMillis")]
        [Validation(Required=false)]
        public long? TimeMillis { get; set; }

        /// <summary>
        /// <para>The total number of records for all changes in the snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("totalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

        /// <summary>
        /// <para>The file format version of the snapshot. The current version is 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

        /// <summary>
        /// <para>The watermark value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-9223372036854775808</para>
        /// </summary>
        [NameInMap("watermark")]
        [Validation(Required=false)]
        public long? Watermark { get; set; }

    }

}
