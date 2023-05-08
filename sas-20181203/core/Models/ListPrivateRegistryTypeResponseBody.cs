// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPrivateRegistryTypeResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of image repository types.
        /// </summary>
        [NameInMap("RegistryTypeInfos")]
        [Validation(Required=false)]
        public List<ListPrivateRegistryTypeResponseBodyRegistryTypeInfos> RegistryTypeInfos { get; set; }
        public class ListPrivateRegistryTypeResponseBodyRegistryTypeInfos : TeaModel {
            /// <summary>
            /// The number of image repositories.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The name of the image repository type. Valid values:
            /// 
            /// *   **acr**: Container Registry
            /// *   **harbor**: Harbor
            /// *   **quay**: Quay
            /// *   **CI/CD**: Jenkins
            /// </summary>
            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
