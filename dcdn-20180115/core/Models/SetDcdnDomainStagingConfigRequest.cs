// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class SetDcdnDomainStagingConfigRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name. Separate multiple accelerated domain names with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The list of features. Format: `[{"functionArgs":[{"argName":"parameter key","argValue":"parameter value"},{"argName":"xx","argValue":"xx"}],"functionName": feature name"}]`
        /// 
        /// > Separate multiple parameters with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Functions")]
        [Validation(Required=false)]
        public string Functions { get; set; }

    }

}
