// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateChatFlowLogSettingRequest : TeaModel {
        /// <summary>
        /// <para>Flow code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f4912c16943b4dfba44bd6fedacf****</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        /// <summary>
        /// <para>Setting ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Log enable status, enum values:</para>
        /// <list type="bullet">
        /// <item><description>ENABLED: Enabled, enables log writing</description></item>
        /// <item><description>DISABLED: Create or retain related resources, but do not enable log writing</description></item>
        /// <item><description>DELETED: Delete, and decide whether to delete related resources based on options</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
