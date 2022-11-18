// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetPublicDatasetEntityRequest : TeaModel {
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

    }

}
