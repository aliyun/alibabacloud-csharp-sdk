// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceInstancesRequest : TeaModel {
        /// <summary>
        /// The filter.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListServiceInstancesRequestFilter> Filter { get; set; }
        public class ListServiceInstancesRequestFilter : TeaModel {
            /// <summary>
            /// The parameter name of the filter. You can specify one or more filters. Valid values:
            /// 
            /// *   Name: The service name. If you want to perform a fuzzy match, specify the service name in the *xxx* format. For example, if the service name is My Service, you can set the filter value to *My* or *Service*.
            /// *   ServiceInstanceId: The ID of the service instance.
            /// *   ServiceId: The service ID.
            /// *   UserId: The user ID.
            /// *   Version: The service version.
            /// *   Status: The status of the service instance.
            /// *   DeployType: The deployment type of the service.
            /// *   ServiceType: The service type.
            /// *   OperationStartTimeBefore: The time before the hosted O\\&M starts.
            /// *   OperationStartTimeAfter: The time after the hosted O\\&M starts.
            /// *   OperationEndTimeBefore: The time before the hosted O\\&M ends.
            /// *   OperationEndTimeAfter: The time after the hosted O\\&M ends.
            /// *   OperatedServiceInstanceId: The ID of the hosted O\\&M instance that belongs to a private service.
            /// *   OperationServiceInstanceId: The ID of the hosted O\\&M service instance that belongs to a hosted O\\&M service.
            /// *   EnableInstanceOps: Whether the hosted O\\&M feature is enabled for service instances.
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
        /// Specifies whether to display the information that the service instance is deleted. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("ShowDeleted")]
        [Validation(Required=false)]
        public bool? ShowDeleted { get; set; }

        /// <summary>
        /// The custom tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListServiceInstancesRequestTag> Tag { get; set; }
        public class ListServiceInstancesRequestTag : TeaModel {
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
