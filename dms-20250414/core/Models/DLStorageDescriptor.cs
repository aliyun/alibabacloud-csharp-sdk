// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DLStorageDescriptor : TeaModel {
        [NameInMap("BucketCols")]
        [Validation(Required=false)]
        public List<string> BucketCols { get; set; }

        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<DLColumn> Columns { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>org.apache.hadoop.mapred.SequenceFileInputFormat</para>
        /// </summary>
        [NameInMap("InputFormat")]
        [Validation(Required=false)]
        public string InputFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsCompressed")]
        [Validation(Required=false)]
        public bool? IsCompressed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://xxx</para>
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("NumBuckets")]
        [Validation(Required=false)]
        public int? NumBuckets { get; set; }

        [NameInMap("OriginalColumns")]
        [Validation(Required=false)]
        public List<DLColumn> OriginalColumns { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>org.apache.hadoop.hive.ql.io.HiveSequenceFileOutputFormat</para>
        /// </summary>
        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>key/value</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        [NameInMap("SerdeInfo")]
        [Validation(Required=false)]
        public DLSerdeInfo SerdeInfo { get; set; }

        [NameInMap("SkewedInfo")]
        [Validation(Required=false)]
        public DLSkewedInfo SkewedInfo { get; set; }

        [NameInMap("SortCols")]
        [Validation(Required=false)]
        public List<DLOrder> SortCols { get; set; }

    }

}
