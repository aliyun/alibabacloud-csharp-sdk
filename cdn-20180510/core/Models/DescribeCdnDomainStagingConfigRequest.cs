// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDomainStagingConfigRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name. You can specify only one domain name in each request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The list of feature names. Separate multiple values with commas (,). For more information, see [A list of features](https://help.aliyun.com/document_detail/388460.html).
        /// </summary>
        [NameInMap("FunctionNames")]
        [Validation(Required=false)]
        public string FunctionNames { get; set; }

    }

}
