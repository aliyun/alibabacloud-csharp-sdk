// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListRayLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. The value 1000000 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListRayLogsResponseBodyData Data { get; set; }
        public class ListRayLogsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The OSS bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mybucket</para>
            /// </summary>
            [NameInMap("bucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The character used to group object names. All objects whose names contain the specified prefix and between which the delimiter character appears for the first time are grouped as a set of elements (CommonPrefixes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("delimiter")]
            [Validation(Required=false)]
            public string Delimiter { get; set; }

            /// <summary>
            /// <para>Indicates whether the results returned in the request are truncated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isTruncated")]
            [Validation(Required=false)]
            public bool? IsTruncated { get; set; }

            /// <summary>
            /// <para>The marker after which the returned objects are listed in alphabetical order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1.txt</para>
            /// </summary>
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            /// <summary>
            /// <para>The maximum number of objects to return.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("maxKeys")]
            [Validation(Required=false)]
            public long? MaxKeys { get; set; }

            /// <summary>
            /// <para>The marker from which the next listing of files starts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test2.txt</para>
            /// </summary>
            [NameInMap("nextMarker")]
            [Validation(Required=false)]
            public string NextMarker { get; set; }

            /// <summary>
            /// <para>The list of object metadata.</para>
            /// </summary>
            [NameInMap("objectList")]
            [Validation(Required=false)]
            public List<ListRayLogsResponseBodyDataObjectList> ObjectList { get; set; }
            public class ListRayLogsResponseBodyDataObjectList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the entry is a directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isDir")]
                [Validation(Required=false)]
                public bool? IsDir { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1.txt</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The file path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/w-xxxxxxx/ray/logs/rj-xxxxxxxxxx_default/test1.txt</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The file size, in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>535345</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The modification time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17344656363434</para>
                /// </summary>
                [NameInMap("timeModified")]
                [Validation(Required=false)]
                public long? TimeModified { get; set; }

            }

            /// <summary>
            /// <para>The prefix that the keys of the returned files must start with.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/w-xxxxxxx/ray/logs/rj-xxxxxxxxxx_default/</para>
            /// </summary>
            [NameInMap("prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
