// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceEstimateCostRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The subscription duration information about the purchase order of Alibaba Cloud Marketplace.
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public GetServiceEstimateCostRequestCommodity Commodity { get; set; }
        public class GetServiceEstimateCostRequestCommodity : TeaModel {
            /// <summary>
            /// The subscription duration.
            /// </summary>
            [NameInMap("PayPeriod")]
            [Validation(Required=false)]
            public int? PayPeriod { get; set; }

            /// <summary>
            /// The unit of the subscription duration. Valid values:
            /// 
            /// *   Year
            /// *   Month
            /// *   Day
            /// </summary>
            [NameInMap("PayPeriodUnit")]
            [Validation(Required=false)]
            public string PayPeriodUnit { get; set; }

        }

        /// <summary>
        /// The parameters that are specified to deploy the service instance.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The service ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The ID of the service instance.
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// The service version.
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// The package name.
        /// </summary>
        [NameInMap("SpecificationName")]
        [Validation(Required=false)]
        public string SpecificationName { get; set; }

        /// <summary>
        /// The template name.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
