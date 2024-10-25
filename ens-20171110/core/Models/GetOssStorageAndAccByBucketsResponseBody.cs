// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetOssStorageAndAccByBucketsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the bucket.</para>
        /// </summary>
        [NameInMap("BucketList")]
        [Validation(Required=false)]
        public List<GetOssStorageAndAccByBucketsResponseBodyBucketList> BucketList { get; set; }
        public class GetOssStorageAndAccByBucketsResponseBodyBucketList : TeaModel {
            /// <summary>
            /// <para>The number of times that the bucket is accessed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Acc")]
            [Validation(Required=false)]
            public long? Acc { get; set; }

            /// <summary>
            /// <para>The name of the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-bucket</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The storage usage of the bucket. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("StorageUsageByte")]
            [Validation(Required=false)]
            public long? StorageUsageByte { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>112F4860-F1B2-58DD-8FC0-75F19DA1C4BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
