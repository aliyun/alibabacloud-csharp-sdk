// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeRdStatusResponseBody : TeaModel {
        /// <summary>
        /// The Alibaba Cloud account ID of the current account.
        /// </summary>
        [NameInMap("CurrentUid")]
        [Validation(Required=false)]
        public string CurrentUid { get; set; }

        /// <summary>
        /// The type of the Alibaba Cloud account. Valid values:
        /// 
        /// *   **MasterAccount**: management account
        /// *   **DelegatedAdminAccount**: delegated administrator account
        /// *   **MasterAccount**: member
        /// </summary>
        [NameInMap("CurrentUidType")]
        [Validation(Required=false)]
        public string CurrentUidType { get; set; }

        /// <summary>
        /// Indicates whether the multi-account management feature is enabled for Anti-DDoS Origin.
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Indicates whether the multi-account management feature is enabled for the current account in Anti-DDoS Origin.
        /// </summary>
        [NameInMap("LocalEnable")]
        [Validation(Required=false)]
        public bool? LocalEnable { get; set; }

        /// <summary>
        /// The Alibaba Cloud account ID of the management account in the resource directory.
        /// </summary>
        [NameInMap("MasterUid")]
        [Validation(Required=false)]
        public string MasterUid { get; set; }

        /// <summary>
        /// Indicates whether Resource Directory is enabled in the [Resource Management console](https://resourcemanager.console.aliyun.com).
        /// </summary>
        [NameInMap("RemoteEnable")]
        [Validation(Required=false)]
        public bool? RemoteEnable { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The Alibaba Cloud account ID of the management account for which the multi-account management feature is enabled in Anti-DDoS Origin.
        /// </summary>
        [NameInMap("RootUid")]
        [Validation(Required=false)]
        public string RootUid { get; set; }

        /// <summary>
        /// Indicates whether the trusted service is enabled.
        /// </summary>
        [NameInMap("ServicePrincipalEnabled")]
        [Validation(Required=false)]
        public bool? ServicePrincipalEnabled { get; set; }

    }

}
