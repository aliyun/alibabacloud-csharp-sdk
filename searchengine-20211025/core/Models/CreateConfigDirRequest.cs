// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateConfigDirRequest : TeaModel {
        /// <summary>
        /// <para>The directory name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/clusters</para>
        /// </summary>
        [NameInMap("dirName")]
        [Validation(Required=false)]
        public string DirName { get; set; }

        /// <summary>
        /// <para>The path of the parent directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("parentFullPath")]
        [Validation(Required=false)]
        public string ParentFullPath { get; set; }

    }

}
