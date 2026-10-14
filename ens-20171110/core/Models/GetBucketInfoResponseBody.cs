// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetBucketInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Bucket information list.</para>
        /// </summary>
        [NameInMap("BucketInfo")]
        [Validation(Required=false)]
        public GetBucketInfoResponseBodyBucketInfo BucketInfo { get; set; }
        public class GetBucketInfoResponseBodyBucketInfo : TeaModel {
            /// <summary>
            /// <para>Bucket access control list type:</para>
            /// <list type="bullet">
            /// <item><description><para><b>public-read-write</b>: public-read-write</para>
            /// </description></item>
            /// <item><description><para><b>public-read</b>: public-read</para>
            /// </description></item>
            /// <item><description><para><b>private</b>: private (default)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("BucketAcl")]
            [Validation(Required=false)]
            public string BucketAcl { get; set; }

            /// <summary>
            /// <para>Bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>Comments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>das</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>Bucket creation time. Represented in ISO8601 standard, using UTC time. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-12T05:45:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Single node storage. Value: sink.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sink</para>
            /// </summary>
            [NameInMap("LogicalBucketType")]
            [Validation(Required=false)]
            public string LogicalBucketType { get; set; }

            /// <summary>
            /// <para>Bucket modification time. Represented in ISO8601 standard, using UTC time. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-12T06:45:00Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C5831388-2D4B-46F4-A96B-D4E6BD06E7521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
