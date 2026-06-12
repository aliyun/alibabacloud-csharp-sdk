// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Datahub20240620.Models
{
    public class CreateTopicRequest : TeaModel {
        /// <summary>
        /// <para>The description of the topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable multi-version schema. After this feature is enabled, a topic can have multiple schemas. You can select one of the schemas for writing. The consumer automatically parses each record based on the version tag. If the schema for the corresponding version has been deleted, parsing fails.</para>
        /// <remarks>
        /// <para>Enabling multi-version schema has the following impacts:</para>
        /// </remarks>
        /// <ol>
        /// <item><description>You can no longer use the appendFields operation.</description></item>
        /// <item><description>You can create, delete, modify, and query schemas.</description></item>
        /// <item><description>Connectors are created by using the schema of the latest version.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EnableSchemaRegistry")]
        [Validation(Required=false)]
        public bool? EnableSchemaRegistry { get; set; }

        /// <summary>
        /// <para>The expansion mode of the topic. After the expansion mode is enabled, shards support horizontal scaling and no longer support merge or split operations. The number of shards can only increase and cannot decrease. After this mode is enabled, you can consume the current topic by using Kafka.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ExpandMode")]
        [Validation(Required=false)]
        public bool? ExpandMode { get; set; }

        /// <summary>
        /// <para>The lifecycle of the topic. Unit: days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Lifecycle")]
        [Validation(Required=false)]
        public int? Lifecycle { get; set; }

        /// <summary>
        /// <para>The project name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xiaowutest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The schema table structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;fields\&quot;:[{\&quot;name\&quot;:\&quot;field_init\&quot;,\&quot;type\&quot;:\&quot;STRING\&quot;,\&quot;notnull\&quot;:\&quot;false\&quot;}]}&quot;</para>
        /// </summary>
        [NameInMap("RecordSchema")]
        [Validation(Required=false)]
        public string RecordSchema { get; set; }

        /// <summary>
        /// <para>The topic type. Valid values:</para>
        /// <ol>
        /// <item><description><para>Blob: supports writing a block of binary data as a single record.</para>
        /// </description></item>
        /// <item><description><para>Tuple: supports database-like records where each record contains multiple columns. You must specify RecordSchema because data is transmitted over the network as strings and requires a schema to convert the data into the corresponding types.</para>
        /// </description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TUPLE</para>
        /// </summary>
        [NameInMap("RecordType")]
        [Validation(Required=false)]
        public string RecordType { get; set; }

        /// <summary>
        /// <para>The number of shards.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The topic name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adsb_cat021</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
