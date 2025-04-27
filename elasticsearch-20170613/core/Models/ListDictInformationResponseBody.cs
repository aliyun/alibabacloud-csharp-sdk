// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDictInformationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7C4334EA-D22B-48BD-AE28-08EE68******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListDictInformationResponseBodyResult Result { get; set; }
        public class ListDictInformationResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2202301</para>
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("ossObject")]
            [Validation(Required=false)]
            public ListDictInformationResponseBodyResultOssObject OssObject { get; set; }
            public class ListDictInformationResponseBodyResultOssObject : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>es-osstest*</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2ABAB5E70BBF631145647F6BE533****</para>
                /// </summary>
                [NameInMap("etag")]
                [Validation(Required=false)]
                public string Etag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss/dict_0*.dic</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>STOP</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
