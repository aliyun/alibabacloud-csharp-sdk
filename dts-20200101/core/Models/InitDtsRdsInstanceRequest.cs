// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class InitDtsRdsInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the data synchronization task.
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// If the node is a self-managed MySQL database that is connected over CEN, you must specify the ID of the CEN instance.
        /// 
        /// > You must specify the **EndpointRegion** and **EndpointInstanceId** parameters or the EndpointCenId parameter based on the type of the node.
        /// </summary>
        [NameInMap("EndpointCenId")]
        [Validation(Required=false)]
        public string EndpointCenId { get; set; }

        /// <summary>
        /// If the node is an ApsaraDB RDS for MySQL instance, you must specify the ID of the ApsaraDB RDS for MySQL instance.
        /// 
        /// > *   You must also specify the **EndpointRegion** parameter.
        /// >*   You must specify the EndpointInstanceId parameter or the **EndpointCenId** parameter based on the type of the node.
        /// </summary>
        [NameInMap("EndpointInstanceId")]
        [Validation(Required=false)]
        public string EndpointInstanceId { get; set; }

        /// <summary>
        /// The type of the node. Valid values:
        /// 
        /// *   **RDS**: an ApsaraDB RDS for MySQL instance
        /// *   **CEN**: a self-managed MySQL database that is connected over CEN
        /// </summary>
        [NameInMap("EndpointInstanceType")]
        [Validation(Required=false)]
        public string EndpointInstanceType { get; set; }

        /// <summary>
        /// If the node is an ApsaraDB RDS for MySQL instance, you must specify the region in which the ApsaraDB RDS for MySQL instance resides.
        /// 
        /// > *   You must also specify the **EndpointInstanceId** parameter.
        /// >*   You must specify the EndpointRegion parameter or the **EndpointCenId** parameter based on the type of the node.
        /// </summary>
        [NameInMap("EndpointRegion")]
        [Validation(Required=false)]
        public string EndpointRegion { get; set; }

        /// <summary>
        /// The ID of the region in which the active geo-redundancy database cluster resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
