// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Datahub20240620.Models
{
    public class PutRecordsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<PutRecordsRequestRecords> Records { get; set; }
        public class PutRecordsRequestRecords : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;key1&quot;:&quot;val1&quot;,&quot;key2&quot;:&quot;val2&quot;}</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public Dictionary<string, string> Attributes { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;aa&quot;, &quot;bb&quot;, &quot;12&quot;, &quot;12.34&quot;]</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<string> Data { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ShardId")]
        [Validation(Required=false)]
        public string ShardId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_topic</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
