// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DLStorageDescriptor : TeaModel {
        /// <summary>
        /// <para>A list of bucket column names that determine the hash distribution of the data.</para>
        /// </summary>
        [NameInMap("BucketCols")]
        [Validation(Required=false)]
        public List<string> BucketCols { get; set; }

        /// <summary>
        /// <para>The description of the data columns in the table.</para>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<DLColumn> Columns { get; set; }

        /// <summary>
        /// <para>The name of the input format class used to read data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org.apache.hadoop.mapred.SequenceFileInputFormat</para>
        /// </summary>
        [NameInMap("InputFormat")]
        [Validation(Required=false)]
        public string InputFormat { get; set; }

        /// <summary>
        /// <para>Specifies whether the data is compressed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsCompressed")]
        [Validation(Required=false)]
        public bool? IsCompressed { get; set; }

        /// <summary>
        /// <para>The specific location of the data storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://xxx</para>
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <para>The number of buckets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("NumBuckets")]
        [Validation(Required=false)]
        public int? NumBuckets { get; set; }

        /// <summary>
        /// <para>The description of the original columns.</para>
        /// </summary>
        [NameInMap("OriginalColumns")]
        [Validation(Required=false)]
        public List<DLColumn> OriginalColumns { get; set; }

        /// <summary>
        /// <para>The name of the output format class used to write data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org.apache.hadoop.hive.ql.io.HiveSequenceFileOutputFormat</para>
        /// </summary>
        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// <para>Other parameter mappings for data storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key/value</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>The serialization and deserialization information.</para>
        /// </summary>
        [NameInMap("SerdeInfo")]
        [Validation(Required=false)]
        public DLSerdeInfo SerdeInfo { get; set; }

        /// <summary>
        /// <para>The data structure that stores information about skewed columns.</para>
        /// </summary>
        [NameInMap("SkewedInfo")]
        [Validation(Required=false)]
        public DLSkewedInfo SkewedInfo { get; set; }

        /// <summary>
        /// <para>The description of the sorted columns.</para>
        /// </summary>
        [NameInMap("SortCols")]
        [Validation(Required=false)]
        public List<DLOrder> SortCols { get; set; }

    }

}
