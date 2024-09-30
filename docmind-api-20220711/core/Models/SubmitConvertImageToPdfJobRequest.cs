// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220711.Models
{
    public class SubmitConvertImageToPdfJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>JPG</para>
        /// </summary>
        [NameInMap("ImageNameExtension")]
        [Validation(Required=false)]
        public string ImageNameExtension { get; set; }

        [NameInMap("ImageNames")]
        [Validation(Required=false)]
        public List<string> ImageNames { get; set; }

        [NameInMap("ImageUrls")]
        [Validation(Required=false)]
        public List<string> ImageUrls { get; set; }

    }

}
