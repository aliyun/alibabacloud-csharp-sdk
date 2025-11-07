// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeOssStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeOssStatusResponseBodyData Data { get; set; }
        public class DescribeOssStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the OSS bucket for delivering authentication information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-aliyun-cloudauth-20250516xxxxxx</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>User activation status, SUCCESS indicates activated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public string UserStatus { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2DB870B-EEB7-51BD-9F0A-B5D8D3C79308</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
