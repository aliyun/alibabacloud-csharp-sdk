// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeFabricExplorerRequest : TeaModel {
        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("ExMethod")]
        [Validation(Required=false)]
        public string ExMethod { get; set; }

        [NameInMap("ExUrl")]
        [Validation(Required=false)]
        public string ExUrl { get; set; }

        [NameInMap("ExBody")]
        [Validation(Required=false)]
        public string ExBody { get; set; }

    }

}
