// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetDefaultDomainRequest : TeaModel {
        /// <summary>
        /// <para>The default domain name.</para>
        /// <para>The default domain name is in the format of <c>&lt;AccountAlias&gt;.onaliyun.com</c>. <c>&lt;AccountAlias&gt;</c> indicates the account alias. By default, the value of AccountAlias is the ID of the Alibaba Cloud account. The default domain name must end with <c>.onaliyun.com</c>.</para>
        /// <para>The default domain name can contain up to 64 characters in length. The default domain name can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para> The default domain name cannot start or end with a hyphen (-) and cannot contain two consecutive hyphens (-).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>examplecompany.onaliyun.com</para>
        /// </summary>
        [NameInMap("DefaultDomainName")]
        [Validation(Required=false)]
        public string DefaultDomainName { get; set; }

    }

}
