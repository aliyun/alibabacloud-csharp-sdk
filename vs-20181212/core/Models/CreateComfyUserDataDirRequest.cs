// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateComfyUserDataDirRequest : TeaModel {
        /// <summary>
        /// <para>The path of the directory to create. Use /dir1/ for a single-level directory, or /dir1/dir2/ for a multi-level directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/userdir1</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

    }

}
