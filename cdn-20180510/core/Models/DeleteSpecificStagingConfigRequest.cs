// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DeleteSpecificStagingConfigRequest : TeaModel {
        /// <summary>
        /// The configuration IDs. Separate configuration IDs with commas (,). For more information about ConfigId, see [Usage notes on ConfigId](https://help.aliyun.com/document_detail/388994.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// The accelerated domain name. You can specify up to 50 domain names in each request. Separate multiple domain names with commas (,).
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
