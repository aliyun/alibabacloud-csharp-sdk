// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DeleteBackupClientResourceRequest : TeaModel {
        /// <summary>
        /// <para>A list of client IDs. The list can contain up to 100 client IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;c-*********************&quot;]</para>
        /// </summary>
        [NameInMap("ClientIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> ClientIds { get; set; }

    }

}
