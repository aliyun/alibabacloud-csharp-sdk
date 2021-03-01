// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateContainerConfigurationRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("ContextPath")]
        [Validation(Required=false)]
        public string ContextPath { get; set; }

        [NameInMap("HttpPort")]
        [Validation(Required=false)]
        public int? HttpPort { get; set; }

        [NameInMap("MaxThreads")]
        [Validation(Required=false)]
        public int? MaxThreads { get; set; }

        [NameInMap("URIEncoding")]
        [Validation(Required=false)]
        public string URIEncoding { get; set; }

        [NameInMap("UseBodyEncoding")]
        [Validation(Required=false)]
        public bool? UseBodyEncoding { get; set; }

    }

}
