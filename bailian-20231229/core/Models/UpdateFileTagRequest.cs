// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class UpdateFileTagRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>The list of tags to associate with the file. You can specify a maximum of 100 tags. The combined length of all tag values cannot exceed 700 characters.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}
