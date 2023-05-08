// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPrivateRegistryListRequest : TeaModel {
        /// <summary>
        /// The type of the image repository. Valid values:
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

}
