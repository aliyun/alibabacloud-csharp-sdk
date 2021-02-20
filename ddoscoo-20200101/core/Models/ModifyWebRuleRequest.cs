// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebRuleRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("ProxyTypes")]
        [Validation(Required=false)]
        public string ProxyTypes { get; set; }

        [NameInMap("RsType")]
        [Validation(Required=false)]
        public int? RsType { get; set; }

        [NameInMap("HttpsExt")]
        [Validation(Required=false)]
        public string HttpsExt { get; set; }

        [NameInMap("RealServers")]
        [Validation(Required=false)]
        public List<string> RealServers { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

    }

}
