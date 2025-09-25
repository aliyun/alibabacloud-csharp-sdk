// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifySDKResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SDK download URL. When not empty, it indicates that the generation is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.xxx.com">https://www.xxx.com</a></para>
        /// </summary>
        [NameInMap("SdkUrl")]
        [Validation(Required=false)]
        public string SdkUrl { get; set; }

    }

}
