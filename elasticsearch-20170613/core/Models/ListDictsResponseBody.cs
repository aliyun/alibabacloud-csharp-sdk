// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDictsResponseBody : TeaModel {
        /// <summary>
        /// <para>The header of the response.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListDictsResponseBodyHeaders Headers { get; set; }
        public class ListDictsResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2937F832-F39E-41EF-89BA-B528342A2A3A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDictsResponseBodyResult> Result { get; set; }
        public class ListDictsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The link that is used to download the dictionary over the Internet. The link is valid for 90s.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://test_bucket.oss-cn-hangzhou.aliyuncs.com/AliyunEs/test.dic?Expires=162573****&OSSAccessKeyId=LTAI*****V9&Signature=PNPO********BBGsJDO4V3VfU4sE%3D">http://test_bucket.oss-cn-hangzhou.aliyuncs.com/AliyunEs/test.dic?Expires=162573****&amp;OSSAccessKeyId=LTAI*****V9&amp;Signature=PNPO********BBGsJDO4V3VfU4sE%3D</a></para>
            /// </summary>
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The size of the dictionary file. Unit: byte.</para>
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
            /// <para>The source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ORIGIN</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The type of the IK dictionary. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MAIN: main dictionary</description></item>
            /// <item><description>STOP: stopword list</description></item>
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
