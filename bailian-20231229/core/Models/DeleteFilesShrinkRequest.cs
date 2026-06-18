// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class DeleteFilesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of IDs of the files to be deleted. A maximum of 20 files can be deleted in a single request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public string FileIdsShrink { get; set; }

    }

}
