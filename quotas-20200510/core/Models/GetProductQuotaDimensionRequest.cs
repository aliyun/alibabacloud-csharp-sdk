// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaDimensionRequest : TeaModel {
        /// <summary>
        /// The dimension details that are supported by the cloud service.
        /// </summary>
        [NameInMap("DependentDimensions")]
        [Validation(Required=false)]
        public List<GetProductQuotaDimensionRequestDependentDimensions> DependentDimensions { get; set; }
        public class GetProductQuotaDimensionRequestDependentDimensions : TeaModel {
            /// <summary>
            /// The dimension keys that are supported by the cloud service.
            /// 
            /// >  The value range of N varies based on the number of dimensions that are supported by the related cloud service.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The dimension values that are supported by the cloud service.
            /// 
            /// >  The value range of N varies based on the number of dimensions that are supported by the related cloud service.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The dimension key.
        /// </summary>
        [NameInMap("DimensionKey")]
        [Validation(Required=false)]
        public string DimensionKey { get; set; }

        /// <summary>
        /// The abbreviation of the cloud service name.
        /// 
        /// >  For more information, see [Alibaba Cloud services that support Quota Center](~~182368~~).
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
