// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ImportImageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>android 12 custom image</para>
        /// </summary>
        [NameInMap("ImageDescription")]
        [Validation(Required=false)]
        public string ImageDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxx.oss-xxx/xxxx.tgz">https://xxx.oss-xxx/xxxx.tgz</a></para>
        /// </summary>
        [NameInMap("ImageFileURL")]
        [Validation(Required=false)]
        public string ImageFileURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>import custom image</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

    }

}
