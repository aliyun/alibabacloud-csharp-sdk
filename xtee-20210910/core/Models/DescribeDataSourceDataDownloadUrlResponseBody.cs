// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeDataSourceDataDownloadUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeDataSourceDataDownloadUrlResponseBodyResultObject ResultObject { get; set; }
        public class DescribeDataSourceDataDownloadUrlResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Download URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https:/xxxxx.oss-cn-xxxxxx.aliyuncs.com/xxxx/xxx/xxxxxx/xxx/xxxxxxxxxx?Expires=1753421064&amp;OSSAccessKeyId=xxxxxxx&amp;Signature=xxxxxxx%3D</para>
            /// </summary>
            [NameInMap("downloadFileUrl")]
            [Validation(Required=false)]
            public string DownloadFileUrl { get; set; }

        }

    }

}
