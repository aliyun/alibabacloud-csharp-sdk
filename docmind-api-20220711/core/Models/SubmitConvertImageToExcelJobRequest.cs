// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220711.Models
{
    public class SubmitConvertImageToExcelJobRequest : TeaModel {
        [NameInMap("EnableEventCallback")]
        [Validation(Required=false)]
        public bool? EnableEventCallback { get; set; }

        [NameInMap("ForceMergeExcel")]
        [Validation(Required=false)]
        public bool? ForceMergeExcel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>jpg</para>
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

        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

    }

}
