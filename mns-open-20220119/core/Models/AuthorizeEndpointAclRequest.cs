// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class AuthorizeEndpointAclRequest : TeaModel {
        /// <summary>
        /// <para>The access control list (ACL) policy. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>allow</b>: A CIDR whitelist. Only allow is supported.</description></item>
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
        /// <para>A list of CIDR blocks.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CidrList")]
        [Validation(Required=false)]
        public List<string> CidrList { get; set; }

        /// <summary>
        /// <para>The type of the endpoint. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>public</b>: An internet endpoint. Only public is supported.</description></item>
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
