// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetTemplateMaterialsResponseBody : TeaModel {
        /// <summary>
        /// <para>The URLs of the associated materials.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;music.mp3&quot;:&quot;<a href="https://bucket.oss-cn-shanghai.aliyuncs.com/music.mp3?sign=xxx%22,%22config.json%22:%22https://bucket.oss-cn-shanghai.aliyuncs.com/config.json?sign=xxx%22,%22assets/1.jpg%22:%22https://bucket.oss-cn-shanghai.aliyuncs.com/assets/1.jpg?sign=xxx%22%7D">https://bucket.oss-cn-shanghai.aliyuncs.com/music.mp3?sign=xxx&quot;,&quot;config.json&quot;:&quot;https://bucket.oss-cn-shanghai.aliyuncs.com/config.json?sign=xxx&quot;,&quot;assets/1.jpg&quot;:&quot;https://bucket.oss-cn-shanghai.aliyuncs.com/assets/1.jpg?sign=xxx&quot;}</a></para>
        /// </summary>
        [NameInMap("MaterialUrls")]
        [Validation(Required=false)]
        public string MaterialUrls { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
