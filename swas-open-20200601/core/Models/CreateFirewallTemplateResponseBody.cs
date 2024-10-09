// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateFirewallTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the firewall template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ft-bcf1a7hrdq717****</para>
        /// </summary>
        [NameInMap("FirewallTemplateId")]
        [Validation(Required=false)]
        public string FirewallTemplateId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30637AD6-D977-4833-A54C-CC89483E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
