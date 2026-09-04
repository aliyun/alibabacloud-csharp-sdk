// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class UpdateFileTagShrinkRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>The list of tags associated with the file. You can specify up to 100 tags, and the total character length of all tags cannot exceed 700.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
