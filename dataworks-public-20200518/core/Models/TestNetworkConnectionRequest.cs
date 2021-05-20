// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TestNetworkConnectionRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=true)]
        public long? ProjectId { get; set; }

        [NameInMap("DatasourceName")]
        [Validation(Required=true)]
        public string DatasourceName { get; set; }

        [NameInMap("EnvType")]
        [Validation(Required=true)]
        public string EnvType { get; set; }

        [NameInMap("ResourceGroup")]
        [Validation(Required=true)]
        public string ResourceGroup { get; set; }

    }

}
