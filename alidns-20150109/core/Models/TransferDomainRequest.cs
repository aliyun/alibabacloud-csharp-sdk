// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class TransferDomainRequest : TeaModel {
        /// <summary>
        /// The list of domain names. Separate multiple domain names with commas (,). Only domain names registered with Alibaba Cloud are supported.
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

        /// <summary>
        /// The language type.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The detailed information.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The ID of the user to which domain names were transferred.
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public long? TargetUserId { get; set; }

    }

}
