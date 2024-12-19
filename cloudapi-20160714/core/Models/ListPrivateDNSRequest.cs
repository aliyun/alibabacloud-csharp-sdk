// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ListPrivateDNSRequest : TeaModel {
        /// <summary>
        /// <para>The internal domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api.demo.com</para>
        /// </summary>
        [NameInMap("IntranetDomain")]
        [Validation(Required=false)]
        public string IntranetDomain { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The internal domain name resolution type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VPC: resolution for virtual private cloud (VPC) access authorizations. A resolution of this type can be bound only to traditional dedicated instances.</description></item>
        /// <item><description>A: resolution that supports A records. A resolution of this type can be bound only to VPC integration dedicated instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
