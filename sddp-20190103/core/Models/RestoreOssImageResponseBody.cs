// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class RestoreOssImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>208B016D-4CB9-4A85-96A5-0B8ED1EBF271</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The storage path of the restored image in the bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_dsc_original /dir1/test.png</para>
        /// </summary>
        [NameInMap("RestoredImageKey")]
        [Validation(Required=false)]
        public string RestoredImageKey { get; set; }

    }

}
