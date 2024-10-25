// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetBucketInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of bucket information.</para>
        /// </summary>
        [NameInMap("BucketInfo")]
        [Validation(Required=false)]
        public GetBucketInfoResponseBodyBucketInfo BucketInfo { get; set; }
        public class GetBucketInfoResponseBodyBucketInfo : TeaModel {
            /// <summary>
            /// <para>The ACL of the bucket.</para>
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
            /// <para>das</para>
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
            /// <para>Single-node storage. Set the value to sink.</para>
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
        /// <para>C5831388-2D4B-46F4-A96B-D4E6BD06E7521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
