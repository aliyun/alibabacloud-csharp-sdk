// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateDictResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<UpdateDictResponseBodyResult> Result { get; set; }
        public class UpdateDictResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The size of the dictionary file. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2782602</para>
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The name of the dictionary file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM_MAIN.dic</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The source type of the dictionary file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS</description></item>
            /// <item><description>ORIGIN</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ORIGIN</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The dictionary type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MAIN: IK main dicrionary</description></item>
            /// <item><description>STOP: IK stopword list</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MAIN</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
