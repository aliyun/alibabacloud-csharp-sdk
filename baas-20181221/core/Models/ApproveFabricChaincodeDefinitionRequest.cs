// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class ApproveFabricChaincodeDefinitionRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChaincodeId")]
        [Validation(Required=false)]
        public string ChaincodeId { get; set; }

        [NameInMap("ChaincodePackageId")]
        [Validation(Required=false)]
        public string ChaincodePackageId { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
