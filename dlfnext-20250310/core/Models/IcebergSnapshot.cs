// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class IcebergSnapshot : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("addedRows")]
        [Validation(Required=false)]
        public long? AddedRows { get; set; }

        /// <summary>
        /// <para>id</para>
        /// 
        /// <b>Example:</b>
        /// <para>2443368274334000657</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("idString")]
        [Validation(Required=false)]
        public string IdString { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>append</para>
        /// </summary>
        [NameInMap("operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        [NameInMap("parentIdString")]
        [Validation(Required=false)]
        public string ParentIdString { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("schemaId")]
        [Validation(Required=false)]
        public long? SchemaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("sequenceNumber")]
        [Validation(Required=false)]
        public long? SequenceNumber { get; set; }

        [NameInMap("summary")]
        [Validation(Required=false)]
        public Dictionary<string, string> Summary { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1750313724369</para>
        /// </summary>
        [NameInMap("timestampMillis")]
        [Validation(Required=false)]
        public long? TimestampMillis { get; set; }

    }

}
