// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateComfyUserDataDirRequest : TeaModel {
        /// <summary>
        /// <para>The path to create the directory. The single-level format is /dir1/, and the multi-level format is /dir1/dir2/.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/userdir1</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

    }

}
