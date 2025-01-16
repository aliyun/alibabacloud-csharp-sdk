// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class RevokeEndpointAclRequest : TeaModel {
        /// <summary>
        /// <para>The ACL policy. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>allow</b>: indicates that the operation is initiated from an endpoint in CIDR whitelist. (Only allow is supported)</description></item>
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
        /// <para>The CIDR blocks.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CidrList")]
        [Validation(Required=false)]
        public List<string> CidrList { get; set; }

        /// <summary>
        /// <para>The type of the endpoint. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>public</b>: indicates an public endpoint. (Only public endpoint is supported.)</description></item>
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
