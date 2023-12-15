// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class InstantiateChaincodeRequest : TeaModel {
        [NameInMap("ChaincodeId")]
        [Validation(Required=false)]
        public string ChaincodeId { get; set; }

        [NameInMap("CollectionConfig")]
        [Validation(Required=false)]
        public string CollectionConfig { get; set; }

        [NameInMap("EndorsePolicy")]
        [Validation(Required=false)]
        public string EndorsePolicy { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
