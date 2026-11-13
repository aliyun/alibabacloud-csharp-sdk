// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DeleteWebFilterTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the web filtering template to be deleted. This parameter is required. If this parameter is empty, a parameter fault is returned. The template must exist in the current Alibaba Cloud account. A template cannot be deleted if it is referenced by an access control policy of the Internet border, NAT, or virtual private cloud (VPC) firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wft-3f2a9c1d4b5e6f70</para>
        /// </summary>
        [NameInMap("WebFilterTemplateId")]
        [Validation(Required=false)]
        public string WebFilterTemplateId { get; set; }

    }

}
