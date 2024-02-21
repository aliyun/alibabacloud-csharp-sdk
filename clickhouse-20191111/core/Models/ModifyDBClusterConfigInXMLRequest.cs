// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyDBClusterConfigInXMLRequest : TeaModel {
        /// <summary>
        /// The configuration parameters whose settings you want to modify. You can call the [DescribeDBClusterConfigInXML](~~452210~~) operation to query configuration parameters, and modify the settings of the returned configuration parameters.
        /// 
        /// > You must specify all configuration parameters even when you want to modify the setting of a single parameter. If a configuration parameter is not specified, the original value of this parameter is retained or the modification fails.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The cluster ID. You can call the [DescribeDBClusters](~~170879~~) operation to query information about all the clusters that are deployed in a specific region. The information includes the cluster IDs.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The reason for the modification.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The region ID of the cluster. You can call the [DescribeRegions](~~170875~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
