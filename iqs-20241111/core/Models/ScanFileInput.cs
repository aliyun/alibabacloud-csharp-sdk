// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class ScanFileInput : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>wrwqr</para>
        /// </summary>
        [NameInMap("imageBase64")]
        [Validation(Required=false)]
        public string ImageBase64 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.1241.png">https://www.1241.png</a></para>
        /// </summary>
        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("scanFileInputConfig")]
        [Validation(Required=false)]
        public ScanFileInputConfig ScanFileInputConfig { get; set; }

    }

}
