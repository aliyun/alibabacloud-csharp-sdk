// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaDimensionRequest : TeaModel {
        /// <summary>
        /// The information about quota dimensions.
        /// </summary>
        [NameInMap("DependentDimensions")]
        [Validation(Required=false)]
        public List<GetProductQuotaDimensionRequestDependentDimensions> DependentDimensions { get; set; }
        public class GetProductQuotaDimensionRequestDependentDimensions : TeaModel {
            /// <summary>
            /// The key of the quota dimension on which the quota dimension that you want to query is dependent.
            /// 
            /// > The value range of N varies based on the number of quota dimensions that are supported by the specified Alibaba Cloud service.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the quota dimension on which the quota dimension that you want to query is dependent.
            /// 
            /// > The value range of N varies based on the number of quota dimensions that are supported by the specified Alibaba Cloud service.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The key of the quota dimension.
        /// </summary>
        [NameInMap("DimensionKey")]
        [Validation(Required=false)]
        public string DimensionKey { get; set; }

        /// <summary>
        /// The abbreviation of the Alibaba Cloud service name.
        /// 
        /// > For more information, see [Alibaba Cloud services that support Quota Center](https://help.aliyun.com/document_detail/182368.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
