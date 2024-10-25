// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListObjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>If the delimiter parameter is specified in the request, the response contains CommonPrefixes. Objects whose names contain the same string from the prefix to the next occurrence of the delimiter are grouped as a single result element in CommonPrefixes.</para>
        /// </summary>
        [NameInMap("CommonPrefixes")]
        [Validation(Required=false)]
        public List<string> CommonPrefixes { get; set; }

        /// <summary>
        /// <para>The list of object metadata.</para>
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<ListObjectsResponseBodyContents> Contents { get; set; }
        public class ListObjectsResponseBodyContents : TeaModel {
            /// <summary>
            /// <para>The entity tag (ETag). When an object is created, an ETag is created to identify the content of the object.</para>
            /// <list type="bullet">
            /// <item><description>For an object that is created by calling the PutObject operation, the ETag value of the object is the MD5 hash of the object content.</description></item>
            /// <item><description>For an object that is not created by calling the PutObject operation, the ETag value of the object is the UUID of the object content.</description></item>
            /// <item><description>The ETag of an object can be used to check whether the object content is modified. However, we recommend that you use the MD5 hash of an object rather than the ETag value of the object to verify data integrity.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5B3C1A2E053D763E1B002CC607C5****</para>
            /// </summary>
            [NameInMap("ETag")]
            [Validation(Required=false)]
            public string ETag { get; set; }

            /// <summary>
            /// <para>The name of the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ceshi.txt1617853706546</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The time when the object was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-08T03:48:47.488Z</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <para>The size of the returned object. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        /// <summary>
        /// <para>The token used in this list operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1.txt</para>
        /// </summary>
        [NameInMap("ContinuationToken")]
        [Validation(Required=false)]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// <para>The character used to group objects by name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("Delimiter")]
        [Validation(Required=false)]
        public string Delimiter { get; set; }

        /// <summary>
        /// <para>The encoding type of the object names in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("EncodingType")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

        /// <summary>
        /// <para>Indicates whether the listed objects are truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b></description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The number of keys returned for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("KeyCount")]
        [Validation(Required=false)]
        public long? KeyCount { get; set; }

        /// <summary>
        /// <para>The position from which the list operation starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ceshi.txt1617853707991</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The maximum number of objects returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxKeys")]
        [Validation(Required=false)]
        public long? MaxKeys { get; set; }

        /// <summary>
        /// <para>The token used in the next list operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CgJiYw--</para>
        /// </summary>
        [NameInMap("NextContinuationToken")]
        [Validation(Required=false)]
        public string NextContinuationToken { get; set; }

        /// <summary>
        /// <para>The position from which the next list operation starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ceshi.txt1617853707991</para>
        /// </summary>
        [NameInMap("NextMarker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        /// <summary>
        /// <para>The prefix contained in the names of returned objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b</para>
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4833C4AC-9396-458C-8F25-1D701334E560</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
