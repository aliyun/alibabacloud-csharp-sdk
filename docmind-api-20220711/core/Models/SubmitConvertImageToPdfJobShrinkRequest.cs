// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220711.Models
{
    public class SubmitConvertImageToPdfJobShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>JPG</para>
        /// </summary>
        [NameInMap("ImageNameExtension")]
        [Validation(Required=false)]
        public string ImageNameExtension { get; set; }

        [NameInMap("ImageNames")]
        [Validation(Required=false)]
        public string ImageNamesShrink { get; set; }

        [NameInMap("ImageUrls")]
        [Validation(Required=false)]
        public string ImageUrlsShrink { get; set; }

        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

    }

}
