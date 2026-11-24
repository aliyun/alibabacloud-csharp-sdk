// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SerDeInfoModel : TeaModel {
        /// <summary>
        /// <para>The name of the serialization information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configuration parameters for the serialization and deserialization sequence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;serialization.format&quot;:&quot;|&quot;,&quot;field.delim&quot;:&quot;|&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// <para>The ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("SerDeId")]
        [Validation(Required=false)]
        public long? SerDeId { get; set; }

        /// <summary>
        /// <para>The library used for serialization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org.apache.hadoop.hive.ql.io.parquet.serde.ParquetHiveSerDe</para>
        /// </summary>
        [NameInMap("SerializationLib")]
        [Validation(Required=false)]
        public string SerializationLib { get; set; }

    }

}
