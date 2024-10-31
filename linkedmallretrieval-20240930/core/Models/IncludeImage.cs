// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LinkedmallRetrieval20240930.Models
{
    public class IncludeImage : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>324</para>
        /// </summary>
        [NameInMap("height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://k.sinaimg.cn/n/sinakd20121/594/w2048h946/20240328/74cf-32c0d62e843df76567d760b4459d57c1.jpg/w700d1q75cms.jpg">http://k.sinaimg.cn/n/sinakd20121/594/w2048h946/20240328/74cf-32c0d62e843df76567d760b4459d57c1.jpg/w700d1q75cms.jpg</a></para>
        /// </summary>
        [NameInMap("imageLink")]
        [Validation(Required=false)]
        public string ImageLink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>700</para>
        /// </summary>
        [NameInMap("width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
