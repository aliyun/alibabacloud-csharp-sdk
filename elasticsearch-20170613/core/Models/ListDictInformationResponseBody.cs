// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDictInformationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C4334EA-D22B-48BD-AE28-08EE68******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListDictInformationResponseBodyResult Result { get; set; }
        public class ListDictInformationResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The size of the dictionary file. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2202301</para>
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The details of the OSS file.</para>
            /// </summary>
            [NameInMap("ossObject")]
            [Validation(Required=false)]
            public ListDictInformationResponseBodyResultOssObject OssObject { get; set; }
            public class ListDictInformationResponseBodyResultOssObject : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket where the file is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>es-osstest*</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The MD5 checksum (ETag) of the OSS file, in uppercase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2ABAB5E70BBF631145647F6BE533****</para>
                /// </summary>
                [NameInMap("etag")]
                [Validation(Required=false)]
                public string Etag { get; set; }

                /// <summary>
                /// <para>The storage path of the dictionary file in the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss/dict_0*.dic</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <para>The dictionary type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>MAIN: primary tokenization dictionary</para>
            /// </description></item>
            /// <item><description><para>STOP: stopword dictionary.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STOP</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
