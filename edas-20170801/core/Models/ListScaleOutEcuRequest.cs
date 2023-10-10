// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListScaleOutEcuRequest : TeaModel {
        /// <summary>
        /// The ID of the application. Specify this parameter if you want to query the available ECUs in the cluster where the application is deployed.
        /// 
        /// >  Specify at least one of the ClusterId and AppId parameters as the query parameter.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The ID of the cluster. Specify this parameter if you want to query the available ECUs in the cluster.
        /// 
        /// > Specify at least one of the ClusterId and AppId parameters as the query parameter.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The number of CPU cores based on which you want to query the available ECUs in the cluster.
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// The ID of the instance group. Specify this parameter if you want to query the available ECUs in the cluster where the instance group resides.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The number of ECUs that you want to query. If this parameter is not specified, all the ECUs that meet the query conditions are returned.
        /// </summary>
        [NameInMap("InstanceNum")]
        [Validation(Required=false)]
        public int? InstanceNum { get; set; }

        /// <summary>
        /// The ID of the namespace.
        /// 
        /// *   The ID of a custom namespace is in the `region ID:namespace identifier` format. Example: cn-beijing:test.
        /// *   The ID of the default namespace is in the `region ID` format. Example: cn-beijing.
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        /// <summary>
        /// The size of available memory based on which you want to query the available ECUs in the cluster. Unit: MB.
        /// </summary>
        [NameInMap("Mem")]
        [Validation(Required=false)]
        public int? Mem { get; set; }

    }

}
