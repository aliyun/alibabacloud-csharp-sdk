// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ImportImageRequest : TeaModel {
        /// <summary>
        /// <para>The description of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>android 12 custom image</para>
        /// </summary>
        [NameInMap("ImageDescription")]
        [Validation(Required=false)]
        public string ImageDescription { get; set; }

        /// <summary>
        /// <para>The URL of the image. This must be an Alibaba Cloud OSS address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx.oss-xxx/xxxx.tgz">https://xxx.oss-xxx/xxxx.tgz</a></para>
        /// </summary>
        [NameInMap("ImageFileURL")]
        [Validation(Required=false)]
        public string ImageFileURL { get; set; }

        /// <summary>
        /// <para>The name of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>import custom image</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

    }

}
