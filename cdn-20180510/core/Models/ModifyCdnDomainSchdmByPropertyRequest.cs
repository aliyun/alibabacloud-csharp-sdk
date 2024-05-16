// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ModifyCdnDomainSchdmByPropertyRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name for which you want to change the acceleration region. You can specify only one domain name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The information about the acceleration region. {"coverage":"overseas"}
        /// 
        /// Valid values for coverage:
        /// 
        /// *   **domestic**: Chinese mainland
        /// *   **overseas**: global (excluding the Chinese mainland)
        /// *   **global**: global
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

    }

}
