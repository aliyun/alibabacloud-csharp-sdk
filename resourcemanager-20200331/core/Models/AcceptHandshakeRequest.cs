// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class AcceptHandshakeRequest : TeaModel {
        /// <summary>
        /// <para>The handshake ID.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/160006.html">ListHandshakesForAccount</a> to obtain the handshake ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h-Ih8IuPfvV0t0****</para>
        /// </summary>
        [NameInMap("HandshakeId")]
        [Validation(Required=false)]
        public string HandshakeId { get; set; }

    }

}
