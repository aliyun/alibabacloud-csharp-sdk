// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostAccountsRequest : TeaModel {
        /// <summary>
        /// Indicates whether a password is configured for the host account.
        /// 
        /// Valid values:
        /// 
        /// *   true: A password is configured for the host account.
        /// *   false: No passwords are configured for the host account.
        /// </summary>
        [NameInMap("HostAccountName")]
        [Validation(Required=false)]
        public string HostAccountName { get; set; }

        /// <summary>
        /// The protocol used by the host whose accounts you want to query.
        /// 
        /// Valid values:
        /// 
        /// *   SSH
        /// *   RDP
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// The ID of the shared key.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The operation that you want to perform.
        /// 
        /// Set the value to **ListHostAccounts**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Maximum value: 100. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// >  We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The name of the host account that you want to query. The name can be up to 128 characters in length. Only exact match is supported.
        /// </summary>
        [NameInMap("ProtocolName")]
        [Validation(Required=false)]
        public string ProtocolName { get; set; }

        /// <summary>
        /// The ID of the specified host whose accounts you want to query.
        /// 
        /// >  You can call the [ListHosts](~~200665~~) operation to query the ID of the host.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
