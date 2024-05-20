// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeConfigVersionDifferenceRequest : TeaModel {
        /// <summary>
        /// The ID of the change record. You can call the [DescribeConfigHistory](https://help.aliyun.com/document_detail/452209.html) operation to query the ID of the change record.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChangeId")]
        [Validation(Required=false)]
        public string ChangeId { get; set; }

        /// <summary>
        /// The cluster ID. You can call the [DescribeDBClusters](https://help.aliyun.com/document_detail/170879.html) operation to query information about all the clusters that are deployed in a specific region. The information includes the cluster IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

    }

}
