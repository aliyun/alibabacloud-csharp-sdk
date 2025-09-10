// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class TaggingAdImageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://viapi-demo.oss-cn-shanghai.aliyuncs.com/viapi-demo/images/DetectImageElements/xxxx.png">https://viapi-demo.oss-cn-shanghai.aliyuncs.com/viapi-demo/images/DetectImageElements/xxxx.png</a></para>
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

    }

}
