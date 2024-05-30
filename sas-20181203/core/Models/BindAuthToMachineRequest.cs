// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class BindAuthToMachineRequest : TeaModel {
        /// <summary>
        /// The edition of Security Center that is authorized to scan the asset. Valid values:
        /// 
        /// *   **6**: Anti-virus
        /// *   **5**: Advanced
        /// *   **3**: Enterprise
        /// *   **7**: Ultimate
        /// *   **10**: Value-added Plan
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
        /// Specifies whether to specify servers for protection when you purchase Security Center. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// 
        /// >  If you specify servers, the servers are automatically added to Security Center for protection after the purchase order is complete.
        /// </summary>
        [NameInMap("IsPreBind")]
        [Validation(Required=false)]
        public int? IsPreBind { get; set; }

        /// <summary>
        /// The logical relationship that you want to use to evaluate multiple search conditions. Default value: **OR**. Valid values:
        /// 
        /// *   **OR******
        /// *   **AND******
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// The edition of Security Center that you purchase in the order. Valid values:
        /// 
        /// *   **level7**: Anti-virus
        /// *   **level3**: Advanced
        /// *   **level2**: Enterprise
        /// *   **level8**: Ultimate
        /// *   **level10**: Value-added Plan
        /// </summary>
        [NameInMap("NtmVersion")]
        [Validation(Required=false)]
        public string NtmVersion { get; set; }

        /// <summary>
        /// The ID of the order in which Security Center is purchased and servers are specified for protection.
        /// </summary>
        [NameInMap("PreBindOrderId")]
        [Validation(Required=false)]
        public long? PreBindOrderId { get; set; }

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
