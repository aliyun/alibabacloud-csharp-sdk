// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateRdDefaultSyncListRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the folders in the resource directory.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~GetRdTree~~">GetRdTree</a> operation to obtain the IDs of the folders. Separate multiple folder IDs with commas (,). If you do not specify a value for this parameter, the existing member list is cleared.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>fd-BwoXuf****,fd-CFamY7****</para>
        /// </summary>
        [NameInMap("FolderIds")]
        [Validation(Required=false)]
        public string FolderIds { get; set; }

    }

}
