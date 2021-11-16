// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CheckEngineMetaPartitionRequest : TeaModel {
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        [NameInMap("Partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

    }

}
