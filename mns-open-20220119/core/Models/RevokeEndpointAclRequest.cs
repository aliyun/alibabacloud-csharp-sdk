// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class RevokeEndpointAclRequest : TeaModel {
        /// <summary>
        /// <para>The ACL policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>allow</b>: The operation is for a Classless Inter-Domain Routing (CIDR) whitelist. Currently, only \<c>allow\\</c> is supported.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>allow</para>
        /// </summary>
        [NameInMap("AclStrategy")]
        [Validation(Required=false)]
        public string AclStrategy { get; set; }

        /// <summary>
        /// <para>The list of network segments.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CidrList")]
        [Validation(Required=false)]
        public List<string> CidrList { get; set; }

        /// <summary>
        /// <para>The endpoint type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>public</b>: The Internet endpoint. Currently, only \<c>public\\</c> is supported.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

    }

}
