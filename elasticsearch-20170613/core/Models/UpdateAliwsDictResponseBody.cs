// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateAliwsDictResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<UpdateAliwsDictResponseBodyResult> Result { get; set; }
        public class UpdateAliwsDictResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The size of the dictionary file. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6226</para>
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The name of the uploaded dictionary file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliws_ext_dict.txt</para>
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
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The dictionary type. The value is fixed as ALI_WS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALI_WS</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
