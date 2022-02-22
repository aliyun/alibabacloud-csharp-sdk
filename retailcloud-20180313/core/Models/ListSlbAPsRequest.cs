// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ListSlbAPsRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public long? EnvId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NetworkMode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProtocolList")]
        [Validation(Required=false)]
        public List<string> ProtocolList { get; set; }

        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

    }

}
