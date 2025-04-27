// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateSynonymsDictsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C5622CC-B312-426F-85AA-B0271*******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<UpdateSynonymsDictsResponseBodyResult> Result { get; set; }
        public class UpdateSynonymsDictsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The size of the dictionary file. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>220</para>
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The name of the dictionary file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deploy_0.txt</para>
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
            /// <para>The dictionary type. The value is fixed as SYNONYMS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYNONYMS</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
