// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ModifyDCdnDomainSchdmByPropertyRequest : TeaModel {
        /// <summary>
        /// The name of the accelerated domain for which you want to change the acceleration region. You can specify only one domain name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The region where the acceleration service is deployed. Valid values:
        /// 
        /// *   **domestic**: Chinese mainland
        /// *   **overseas**: global (excluding mainland China)
        /// *   **global**: global
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

    }

}
