// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ReadChatFlowLogSettingRequest : TeaModel {
        /// <summary>
        /// <para>Process code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f4912c16943b4dfba44bd6fedacf****</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
