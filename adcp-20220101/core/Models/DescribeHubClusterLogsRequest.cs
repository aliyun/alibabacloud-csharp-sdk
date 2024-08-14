// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribeHubClusterLogsRequest : TeaModel {
        /// <summary>
        /// The ID of the Fleet instance. You can call the [DescribeHubClusters](https://help.aliyun.com/document_detail/424404.html) operation to query the created Fleet instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
