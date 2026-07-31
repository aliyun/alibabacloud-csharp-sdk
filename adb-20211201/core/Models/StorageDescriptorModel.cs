// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class StorageDescriptorModel : TeaModel {
        /// <summary>
        /// <para>Indicates whether the storage description is compressed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Compressed")]
        [Validation(Required=false)]
        public bool? Compressed { get; set; }

        /// <summary>
        /// <para>The input format of the storage description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org.apache.hadoop.hive.ql.io.parquet.MapredParquetInputFormat</para>
        /// </summary>
        [NameInMap("InputFormat")]
        [Validation(Required=false)]
        public string InputFormat { get; set; }

        /// <summary>
        /// <para>The location of the storage description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://**************</para>
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <para>The number of buckets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NumBuckets")]
        [Validation(Required=false)]
        public long? NumBuckets { get; set; }

        /// <summary>
        /// <para>The output format of the storage description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org.apache.hadoop.hive.ql.io.parquet.MapredParquetInputFormat</para>
        /// </summary>
        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// <para>The storage configuration parameter.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// <para>The ID of the storage description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SdId")]
        [Validation(Required=false)]
        public long? SdId { get; set; }

        /// <summary>
        /// <para>The information about serialization or deserialization.</para>
        /// </summary>
        [NameInMap("SerDeInfo")]
        [Validation(Required=false)]
        public SerDeInfoModel SerDeInfo { get; set; }

        /// <summary>
        /// <para>Indicates whether the storage description is stored in subdirectories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("StoredAsSubDirectories")]
        [Validation(Required=false)]
        public bool? StoredAsSubDirectories { get; set; }

    }

}
