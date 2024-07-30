// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceSharedAccountsRequest : TeaModel {
        /// <summary>
        /// The filters.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListServiceSharedAccountsRequestFilter> Filter { get; set; }
        public class ListServiceSharedAccountsRequestFilter : TeaModel {
            /// <summary>
            /// The parameter name of the filter. You can specify one or more parameter names to query services. Valid values:
            /// 
            /// *   Name: the name of the service.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The parameter value N of the filter. Valid values of N: 1 to 10.
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
        /// The permissions on the service. Valid values:
        /// 
        /// *   Deployable: Permissions to deploy the service.
        /// *   Accessible: Permissions to access the service.
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// The region ID where the service instance resides.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The service ID.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

    }

}
