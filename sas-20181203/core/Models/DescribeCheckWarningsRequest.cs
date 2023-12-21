// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningsRequest : TeaModel {
        /// <summary>
        /// The ID of the check item.
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// The type of the check item. Valid values:
        /// 
        /// *   **hc.check.type.identity_auth**: identity authentication
        /// *   **hc.check.type.access_control**: access control
        /// *   **hc.check.type.network_service**: network and service
        /// *   **hc.check.type.service_conf**: service configuration
        /// *   **hc.check.type.file_rights**: file permission
        /// *   **hc.check.type.security_audit**: security audit
        /// *   **hc.check.type.attack_defense**: intrusion prevention
        /// *   **hc.check.type.others**: others
        /// </summary>
        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public string CheckType { get; set; }

        /// <summary>
        /// The name of the container.
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The Alibaba Cloud account ID of the member in the resource directory.
        /// 
        /// >  You can call the [DescribeMonitorAccounts](~~DescribeMonitorAccounts~~) operation to obtain the IDs.
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// The ID of the risk item. This parameter is required.
        /// 
        /// >  To query the information about the risk items and check items of a server, you must specify the IDs of the risk items. You can call the [DescribeCheckWarningSummary](~~DescribeCheckWarningSummary~~) operation to query the IDs of risk items.
        /// </summary>
        [NameInMap("RiskId")]
        [Validation(Required=false)]
        public long? RiskId { get; set; }

        /// <summary>
        /// The status of the check item. Valid values:
        /// 
        /// *   **1**: failed
        /// *   **2**: verifying
        /// *   **3**: passed
        /// *   **5**: expired
        /// *   **6**: ignored
        /// </summary>
        [NameInMap("RiskStatus")]
        [Validation(Required=false)]
        public int? RiskStatus { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The UUID of the server on which the baseline check is performed.
        /// 
        /// > To query specified risk items and the check items of a specified server, you must provide the ID of the server on which the baseline check is performed. You can call the [DescribeWarningMachines](~~DescribeWarningMachines~~) operation to query the IDs of servers.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
