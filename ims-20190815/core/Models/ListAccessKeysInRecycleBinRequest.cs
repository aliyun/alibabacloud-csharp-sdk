// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListAccessKeysInRecycleBinRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Resource Access Management (RAM) user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20732900249392****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
