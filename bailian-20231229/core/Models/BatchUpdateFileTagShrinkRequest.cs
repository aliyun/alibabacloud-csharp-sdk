// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class BatchUpdateFileTagShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileInfos")]
        [Validation(Required=false)]
        public string FileInfosShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OVERWRITE</para>
        /// </summary>
        [NameInMap("UpdateMode")]
        [Validation(Required=false)]
        public string UpdateMode { get; set; }

    }

}
