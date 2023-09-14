// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListClustersRequest : TeaModel {
        /// <summary>
        /// The IDs of the clusters. You can specify a maximum of 100 items.
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public List<string> ClusterIds { get; set; }

        /// <summary>
        /// The name of the cluster.
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// The states of clusters. You can specify a maximum of 100 items.
        /// </summary>
        [NameInMap("ClusterStates")]
        [Validation(Required=false)]
        public List<string> ClusterStates { get; set; }

        /// <summary>
        /// The types of the clusters. You can specify a maximum of 100 items.
        /// </summary>
        [NameInMap("ClusterTypes")]
        [Validation(Required=false)]
        public List<string> ClusterTypes { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The starting point of the current query. If you do not configure this parameter, the query starts from the beginning.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The billing methods. You can specify a maximum of 2 items.
        /// </summary>
        [NameInMap("PaymentTypes")]
        [Validation(Required=false)]
        public List<string> PaymentTypes { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// Valid values:
        /// 
        /// *   center
        /// *   cn-hangzhou
        /// *   cn-shanghai
        /// *   cn-qingdao
        /// *   cn-beijing
        /// *   cn-zhangjiakou
        /// *   cn-huhehaote
        /// *   cn-wulanchabu
        /// *   cn-shenzhen
        /// *   cn-chengdu
        /// *   cn-hongkong
        /// *   ap-southeast-1
        /// *   ap-southeast-2
        /// *   ap-southeast-3
        /// *   ap-southeast-5
        /// *   ap-northeast-1
        /// *   eu-central-1
        /// *   eu-west-1
        /// *   us-west-1
        /// *   us-east-1
        /// *   ap-south-1
        /// *   me-east-1
        /// *   me-central-1
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags. You can specify a maximum of 20 items.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
