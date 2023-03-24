// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetDefaultDomainRequest : TeaModel {
        /// <summary>
        /// The default domain name.
        /// 
        /// The name is in the format of `<AccountAlias>.onaliyun.com`. `<AccountAlias>` indicates the account alias. By default, the value of AccountAlias is the ID of the Alibaba Cloud account. The default domain name must end with `.onaliyun.com`.
        /// 
        /// The default domain name can contain up to 64 characters in length. The name can contain letters, digits, periods (.), underscores (\_), and hyphens (-).
        /// 
        /// >  The default domain name cannot start or end with a hyphen (-) and cannot have two consecutive hyphens (-).
        /// </summary>
        [NameInMap("DefaultDomainName")]
        [Validation(Required=false)]
        public string DefaultDomainName { get; set; }

    }

}
