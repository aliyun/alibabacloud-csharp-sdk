// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class UpgradeFabricChaincodeDefinitionRequest : TeaModel {
        [NameInMap("ChaincodeId")]
        [Validation(Required=false)]
        public string ChaincodeId { get; set; }

        [NameInMap("ChaincodePackageId")]
        [Validation(Required=false)]
        public string ChaincodePackageId { get; set; }

        [NameInMap("ChaincodeVersion")]
        [Validation(Required=false)]
        public string ChaincodeVersion { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("CollectionConfig")]
        [Validation(Required=false)]
        public string CollectionConfig { get; set; }

        [NameInMap("EndorsePolicy")]
        [Validation(Required=false)]
        public string EndorsePolicy { get; set; }

        [NameInMap("InitRequired")]
        [Validation(Required=false)]
        public bool? InitRequired { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
