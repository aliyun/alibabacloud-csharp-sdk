// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListCollectorsRequest : TeaModel {
        [NameInMap("resId")]
        [Validation(Required=false)]
        public string ResId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
