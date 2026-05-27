// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class UploadForeignSampleFileRequest : TeaModel {
        [NameInMap("File")]
        [Validation(Required=false)]
        public string File { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FINANCE</para>
        /// </summary>
        [NameInMap("Tab")]
        [Validation(Required=false)]
        public string Tab { get; set; }

    }

}
