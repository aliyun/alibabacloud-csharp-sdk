// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DeleteComfyUserDataRequest : TeaModel {
        /// <summary>
        /// <para>The name of the file or directory to delete. If a path is passed, it is treated as a directory and must end with a forward slash (/).
        /// File name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mytest</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

    }

}
