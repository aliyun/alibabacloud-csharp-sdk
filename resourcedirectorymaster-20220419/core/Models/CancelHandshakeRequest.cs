// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class CancelHandshakeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the invitation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h-ycm4rp****</para>
        /// </summary>
        [NameInMap("HandshakeId")]
        [Validation(Required=false)]
        public string HandshakeId { get; set; }

    }

}
