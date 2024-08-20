// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DeleteDcdnSpecificStagingConfigRequest : TeaModel {
        /// <summary>
        /// The ID of the configuration to be deleted. You can specify multiple configuration IDs and separate them with commas (,).
        /// 
        /// You can call the DescribeDcdnDomainStagingConfig operation to query the environment configuration.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// The accelerated domain name. You can specify only one domain name in each call.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
