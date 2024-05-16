// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class BatchDeleteCdnDomainConfigRequest : TeaModel {
        /// <summary>
        /// The accelerated domain names whose configurations you want to delete. Separate multiple accelerated domain names with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

        /// <summary>
        /// The names of the features that you want to delete. Separate multiple feature names with commas (,). For more information about feature names, see [Parameters for configuring features for domain names](https://help.aliyun.com/document_detail/388460.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FunctionNames")]
        [Validation(Required=false)]
        public string FunctionNames { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
