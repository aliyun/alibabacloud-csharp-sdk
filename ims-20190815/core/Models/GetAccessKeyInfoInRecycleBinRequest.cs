// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetAccessKeyInfoInRecycleBinRequest : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID of the Resource Access Management (RAM) user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LTAI*******************</para>
        /// </summary>
        [NameInMap("UserAccessKeyId")]
        [Validation(Required=false)]
        public string UserAccessKeyId { get; set; }

    }

}
