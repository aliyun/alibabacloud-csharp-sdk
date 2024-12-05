// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListAdvanceConfigDirRequest : TeaModel {
        /// <summary>
        /// <para>The name of the directory</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/zones/general</para>
        /// </summary>
        [NameInMap("dirName")]
        [Validation(Required=false)]
        public string DirName { get; set; }

    }

}
