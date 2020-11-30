// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class ConfigLayer7RuleRequest : TeaModel {
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=true)]
        public string Domain { get; set; }

        [NameInMap("ProxyTypeList")]
        [Validation(Required=false)]
        public string ProxyTypeList { get; set; }

        [NameInMap("ProxyTypes")]
        [Validation(Required=false)]
        public List<string> ProxyTypes { get; set; }

        [NameInMap("RsType")]
        [Validation(Required=true)]
        public int? RsType { get; set; }

        [NameInMap("RealServers")]
        [Validation(Required=true)]
        public List<string> RealServers { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

    }

}
