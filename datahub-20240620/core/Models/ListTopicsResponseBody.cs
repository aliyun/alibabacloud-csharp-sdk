// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Datahub20240620.Models
{
    public class ListTopicsResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public ListTopicsResponseBodyList List { get; set; }
        public class ListTopicsResponseBodyList : TeaModel {
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public List<ListTopicsResponseBodyListTopic> Topic { get; set; }
            public class ListTopicsResponseBodyListTopic : TeaModel {
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("EnableSchemaRegistry")]
                [Validation(Required=false)]
                public string EnableSchemaRegistry { get; set; }

                [NameInMap("ExpandMode")]
                [Validation(Required=false)]
                public string ExpandMode { get; set; }

                [NameInMap("Lifecycle")]
                [Validation(Required=false)]
                public int? Lifecycle { get; set; }

                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("RecordSchema")]
                [Validation(Required=false)]
                public string RecordSchema { get; set; }

                [NameInMap("RecordType")]
                [Validation(Required=false)]
                public string RecordType { get; set; }

                [NameInMap("ShardCount")]
                [Validation(Required=false)]
                public int? ShardCount { get; set; }

                [NameInMap("Storage")]
                [Validation(Required=false)]
                public long? Storage { get; set; }

                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9892074a2a89600ae4b0d5a34fb99a3f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A20A7093-8FE0-058C-BE0C-3C8057D5F1A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
