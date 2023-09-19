// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListInventoryEntriesRequest : TeaModel {
        /// <summary>
        /// The filter rules for the component.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListInventoryEntriesRequestFilter> Filter { get; set; }
        public class ListInventoryEntriesRequestFilter : TeaModel {
            /// <summary>
            /// The name of the component property. Valid values of N: 1 to 5.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The comparison operator that is used to filter property values. Valid values of N: 1 to 5. Valid values:
            /// 
            /// *   Equal
            /// *   NotEqual
            /// *   BeginWith
            /// *   LessThan
            /// *   GreaterThan
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// The values of properties. Valid values of the first N: 1 to 5. Valid values of the second N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 50.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the region in which the instance resides.
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
        /// *   ACS:WindowsRegistry
        /// *   ACS:WindowsUpdate
        /// </summary>
        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

    }

}
