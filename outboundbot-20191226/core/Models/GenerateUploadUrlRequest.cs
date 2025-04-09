// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GenerateUploadUrlRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>faaf8508-9542-4ac4-84a2-0ddcbb5f79a6 (2).json</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3b9b5dc6d67ee9fa</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

    }

}
