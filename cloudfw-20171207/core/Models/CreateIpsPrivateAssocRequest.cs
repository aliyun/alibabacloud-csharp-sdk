// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateIpsPrivateAssocRequest : TeaModel {
        /// <summary>
        /// <para>The language type for the request and response messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en: English.</description></item>
        /// <item><description>zh: Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The instance ID. This parameter is required. If this parameter is not specified, the API returns error code -103201. Only NAT gateway instance IDs (in the format ngw-<em>) that are protected by Cloud Firewall are accepted. Other resource types such as vpc-</em> or eip-* are rejected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-c5vhmjdfp5t****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
