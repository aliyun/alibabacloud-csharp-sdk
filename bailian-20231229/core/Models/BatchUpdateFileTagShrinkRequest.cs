// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class BatchUpdateFileTagShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of documents to update.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileInfos")]
        [Validation(Required=false)]
        public string FileInfosShrink { get; set; }

        /// <summary>
        /// <para>The update mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>APPEND: appends tags to existing tags.</description></item>
        /// <item><description>OVERWRITE: overwrites existing tags.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OVERWRITE</para>
        /// </summary>
        [NameInMap("UpdateMode")]
        [Validation(Required=false)]
        public string UpdateMode { get; set; }

    }

}
