// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class RemoveRspDomainServerHoldStatusForGatewayOteRequest : TeaModel {
        /// <summary>
        /// <para>Idempotency token</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwoefasdf</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Domain name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Description of the status change</para>
        /// 
        /// <b>Example:</b>
        /// <para>实名认证通过，解除serverHold状态</para>
        /// </summary>
        [NameInMap("StatusMsg")]
        [Validation(Required=false)]
        public string StatusMsg { get; set; }

    }

}
