// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaRequest : TeaModel {
        /// <summary>
        /// The quota dimensions.
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<GetProductQuotaRequestDimensions> Dimensions { get; set; }
        public class GetProductQuotaRequestDimensions : TeaModel {
            /// <summary>
            /// The key of the dimension.
            /// 
            /// > 
            /// 
            /// *   The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.
            /// 
            /// *   If you call the operation to query the details of a quota that belongs to a cloud service that supports dimensions, you must configure this parameter. You must configure the `Dimensions.N.Key` and `Dimensions.N.Value` parameters at the same time. The following cloud services support dimensions: ECS whose service code is ecs, Enterprise Distributed Application Service (EDAS) whose service code is edas, ECS Quotas by Instance Type whose service code is ecs-spec, and Auto Scaling (ESS) whose service code is ess.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the dimension.
            /// 
            /// > 
            /// 
            /// *   The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.
            /// 
            /// *   If you call the operation to query the details of a quota that belongs to a cloud service that supports dimensions, you must configure this parameter. You must configure the `Dimensions.N.Key` and `Dimensions.N.Value` parameters at the same time. The following cloud services support dimensions: ECS whose service code is ecs, EDAS whose service code is edas, ECS Quotas by Instance Type whose service code is ecs-spec, and ESS whose service code is ess.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The abbreviation of the Alibaba Cloud service name.
        /// 
        /// > For more information, see [Alibaba Cloud services that support Quota Center](~~182368~~).
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The ID of the quota.
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

    }

}
