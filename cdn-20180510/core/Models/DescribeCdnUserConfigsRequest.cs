// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserConfigsRequest : TeaModel {
        /// <summary>
        /// The configuration that you want to query. Valid values:
        /// 
        /// *   **domain_business_control**: user configurations
        /// *   **waf**: Web Application Firewall (WAF) configurations
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

    }

}
