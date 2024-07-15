// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServicesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return all versions of a service. Default value: false, which specifies that only the default version of a service is returned.
        /// </summary>
        [NameInMap("AllVersions")]
        [Validation(Required=false)]
        public bool? AllVersions { get; set; }

        /// <summary>
        /// The filters.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListServicesRequestFilter> Filter { get; set; }
        public class ListServicesRequestFilter : TeaModel {
            /// <summary>
            /// The parameter name of the filter. You can specify one or more parameter names to query services. Valid values:
            /// 
            /// *   ServiceId: the ID of the service.
            /// *   Name: the name of the service.
            /// *   Status: the state of the service.
            /// *   SupplierName: the name of the service provider.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The parameter values of the filter.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 20.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The custom tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListServicesRequestTag> Tag { get; set; }
        public class ListServicesRequestTag : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
