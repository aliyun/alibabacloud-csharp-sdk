// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetInventorySchemaRequest : TeaModel {
        /// <summary>
        /// Specifies whether only to return a combination of specified properties.
        /// 
        /// Valid values:
        /// 
        /// *   true: only returns a combination of specified properties
        /// *   false: returns all properties of the component
        /// </summary>
        [NameInMap("Aggregator")]
        [Validation(Required=false)]
        public bool? Aggregator { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 100. Default value: 50.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used to retrieve the next page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the component. Valid values:
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
