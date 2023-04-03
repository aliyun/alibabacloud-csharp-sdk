// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeTransferDomainsRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("FromUserId")]
        [Validation(Required=false)]
        public long? FromUserId { get; set; }

        /// <summary>
        /// The language type.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 100. Default value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public long? TargetUserId { get; set; }

        /// <summary>
        /// The transfer type. Valid values:
        /// 
        /// *   IN: transferred to this account.
        /// *   OUT: transferred from this account.
        /// </summary>
        [NameInMap("TransferType")]
        [Validation(Required=false)]
        public string TransferType { get; set; }

    }

}
