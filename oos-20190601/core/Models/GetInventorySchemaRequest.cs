// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetInventorySchemaRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return only properties that support the aggregate feature in the configuration list. Valid values:
        /// 
        /// *   true: only returns properties that support the aggregate feature in the configuration list.
        /// *   false: returns all properties in the configuration list.
        /// </summary>
        [NameInMap("Aggregator")]
        [Validation(Required=false)]
        public bool? Aggregator { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 50.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The configuration list type name. Valid values:
        /// 
        /// *   ACS:InstanceInformation
        /// *   ACS:Application
        /// *   ACS:File
        /// *   ACS:Network
        /// *   ACS:WindowsRole
        /// *   ACS:Service
        /// *   ACS:WindowsUpdate
        /// *   ACS:WindowsRegistry
        /// </summary>
        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

    }

}
