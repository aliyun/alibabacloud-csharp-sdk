// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class IcebergPartitionField : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("fieldId")]
        [Validation(Required=false)]
        public long? FieldId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ts_day</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public long? SourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("transform")]
        [Validation(Required=false)]
        public string Transform { get; set; }

    }

}
