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
        /// Specifies whether to automatically bind servers to Security Center. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("AutoBind")]
        [Validation(Required=false)]
        public int? AutoBind { get; set; }

        /// <summary>
        /// The UUIDs of the servers that you want to bind to Security Center.
        /// 
        /// >  You must specify at least one of the **Bind** and **UnBind** parameters.
        /// </summary>
        [NameInMap("Bind")]
        [Validation(Required=false)]
        public List<string> Bind { get; set; }

        /// <summary>
        /// Specifies whether to bind all servers to Security Center. Default value: **false**. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("BindAll")]
        [Validation(Required=false)]
        public bool? BindAll { get; set; }

        /// <summary>
        /// The search conditions that are used to filter servers. The value of this parameter is in the JSON format and is case-sensitive.
        /// 
        /// >  A search condition can be an instance ID, instance name, virtual private cloud (VPC) ID, region, or public IP address. You can call the [DescribeCriteria](~~DescribeCriteria~~) operation to query the supported search conditions.
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// The logical relationship among multiple search conditions. Valid values:
        /// 
        /// *   **OR**: Search conditions are evaluated by using a logical **OR**.
        /// *   **AND**: Search conditions are evaluated by using a logical **AND**.
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// The UUIDs of the servers that you want to unbind from Security Center.
        /// 
        /// >  You must specify at least one of the **Bind** and **UnBind** parameters.
        /// </summary>
        [NameInMap("UnBind")]
        [Validation(Required=false)]
        public List<string> UnBind { get; set; }

    }

}
