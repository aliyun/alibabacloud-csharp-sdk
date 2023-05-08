// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class BindAuthToMachineRequest : TeaModel {
        /// <summary>
        /// The edition of Security Center. Valid values:
        /// 
        /// *   **6**: Anti-virus edition
        /// *   **5**: Advanced edition
        /// *   **3**: Enterprise edition
        /// *   **7**: Ultimate edition
        /// *   **10**: Value-added Plan edition
        /// </summary>
        [NameInMap("AuthVersion")]
        [Validation(Required=false)]
        public int? AuthVersion { get; set; }

        /// <summary>
        /// The shortage in the quota for cores of servers that can be protected.
        /// </summary>
        [NameInMap("AutoBind")]
        [Validation(Required=false)]
        public int? AutoBind { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("Bind")]
        [Validation(Required=false)]
        public List<string> Bind { get; set; }

        /// <summary>
        /// The UUID of the server that you want to bind to Security Center.
        /// 
        /// >  You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("BindAll")]
        [Validation(Required=false)]
        public bool? BindAll { get; set; }

        /// <summary>
        /// The status code that indicates the result. Valid values:
        /// 
        /// *   **0**: The servers are bound to or unbound from Security Center.
        /// *   **1**: The values that you specified for the parameters are invalid.
        /// *   **2**: The quota for servers that can be protected is insufficient.
        /// *   **3**: The quota for cores of servers that can be protected is insufficient.
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// The search conditions that are used to filter servers. The value of this parameter is in the JSON format and is case-sensitive.
        /// 
        /// >  A search condition can be an instance ID, instance name, virtual private cloud (VPC) ID, region, or public IP address. You can call the [DescribeCriteria](~~DescribeCriteria~~) operation to query the supported search conditions.
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// Binds servers to Security Center or unbinds servers from Security Center.
        /// </summary>
        [NameInMap("UnBind")]
        [Validation(Required=false)]
        public List<string> UnBind { get; set; }

    }

}
