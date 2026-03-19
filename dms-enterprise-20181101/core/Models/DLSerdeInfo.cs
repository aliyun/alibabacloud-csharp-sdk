// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DLSerdeInfo : TeaModel {
        /// <summary>
        /// <para>The description of serialization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;serialize&quot;</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the class used for deserialization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org.apache.hadoop.hive.serde2.OpenCSVSerde</para>
        /// </summary>
        [NameInMap("DeserializerClass")]
        [Validation(Required=false)]
        public string DeserializerClass { get; set; }

        /// <summary>
        /// <para>The name of serialization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Serialization-related parameters in key-value pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{          &quot;serialization.format&quot;: &quot;1&quot;
        ///         }</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>The type of serialization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SerdeType")]
        [Validation(Required=false)]
        public int? SerdeType { get; set; }

        /// <summary>
        /// <para>The class name of the serialization library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org.apache.hadoop.hive.serde2.lazy.LazySimpleSerDe</para>
        /// </summary>
        [NameInMap("SerializationLib")]
        [Validation(Required=false)]
        public string SerializationLib { get; set; }

        /// <summary>
        /// <para>The name of class used for serialization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org.apache.hadoop.hive.serde2.lazy.LazySimpleSerDe</para>
        /// </summary>
        [NameInMap("SerializerClass")]
        [Validation(Required=false)]
        public string SerializerClass { get; set; }

    }

}
