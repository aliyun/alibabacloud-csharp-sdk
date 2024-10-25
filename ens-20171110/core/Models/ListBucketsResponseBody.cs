// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListBucketsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of bucket information.</para>
        /// </summary>
        [NameInMap("BucketInfos")]
        [Validation(Required=false)]
        public List<ListBucketsResponseBodyBucketInfos> BucketInfos { get; set; }
        public class ListBucketsResponseBodyBucketInfos : TeaModel {
            /// <summary>
            /// <para>The access control list (ACL) of the bucket.</para>
            /// <list type="bullet">
            /// <item><description><b>public-read-write</b></description></item>
            /// <item><description><b>public-read</b></description></item>
            /// <item><description><b>private</b> (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("BucketAcl")]
            [Validation(Required=false)]
            public string BucketAcl { get; set; }

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
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>numb</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The time when the bucket was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-12T05:45:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the region where the node is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-dalian-unicom</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The type of the single-node storage. Set the value to sink.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sink</para>
            /// </summary>
            [NameInMap("LogicalBucketType")]
            [Validation(Required=false)]
            public string LogicalBucketType { get; set; }

            /// <summary>
            /// <para>The time when the bucket was modified. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-12T06:45:00Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>435769C7-AA6F-4DC5-B3DB-A3DC0DE7E853</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of buckets that match the conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
