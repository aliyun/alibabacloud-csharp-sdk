// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class SearchInventoryRequest : TeaModel {
        /// <summary>
        /// The information about aggregators. You can use one or more aggregators to query the aggregate information of an instance. Valid values:
        /// 
        /// *   ACS:Application.Name
        /// *   ACS:Application.Version
        /// </summary>
        [NameInMap("Aggregator")]
        [Validation(Required=false)]
        public List<string> Aggregator { get; set; }

        /// <summary>
        /// The filter rules for the component.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<SearchInventoryRequestFilter> Filter { get; set; }
        public class SearchInventoryRequestFilter : TeaModel {
            /// <summary>
            /// The name of the component property. Valid values of N: 1 to 5. Different components have different property names. You can call the [GetInventorySchema](https://api.aliyun.com/#/?product=oos\&version=2019-06-01\&api=GetInventorySchema) operation to query the property names of different components. For example, the ACS:InstanceInformation component has the InstanceId property. Therefore, you can set this parameter to ACS:InstanceInformation.InstanceId.
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
            /// The property values to query.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 50.
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

    }

}
