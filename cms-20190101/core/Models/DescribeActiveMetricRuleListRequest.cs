// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeActiveMetricRuleListRequest : TeaModel {
        /// <summary>
        /// The abbreviation of the cloud service that supports initiative alert rules.
        /// 
        /// For more information about how to obtain the name of a cloud service, see [DescribeProductsOfActiveMetricRule](https://help.aliyun.com/document_detail/114930.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

    }

}
