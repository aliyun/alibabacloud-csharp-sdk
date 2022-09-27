// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateInstanceRequest : TeaModel {
        [NameInMap("clientNodeConfiguration")]
        [Validation(Required=false)]
        public ClientNodeConfiguration ClientNodeConfiguration { get; set; }

        [NameInMap("elasticDataNodeConfiguration")]
        [Validation(Required=false)]
        public ElasticDataNodeConfiguration ElasticDataNodeConfiguration { get; set; }

        [NameInMap("instanceCategory")]
        [Validation(Required=false)]
        public string InstanceCategory { get; set; }

        [NameInMap("kibanaConfiguration")]
        [Validation(Required=false)]
        public KibanaNodeConfiguration KibanaConfiguration { get; set; }

        [NameInMap("masterConfiguration")]
        [Validation(Required=false)]
        public MasterNodeConfiguration MasterConfiguration { get; set; }

        [NameInMap("nodeAmount")]
        [Validation(Required=false)]
        public int? NodeAmount { get; set; }

        [NameInMap("nodeSpec")]
        [Validation(Required=false)]
        public NodeSpec NodeSpec { get; set; }

        [NameInMap("warmNodeConfiguration")]
        [Validation(Required=false)]
        public WarmNodeConfiguration WarmNodeConfiguration { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        [NameInMap("orderActionType")]
        [Validation(Required=false)]
        public string OrderActionType { get; set; }

    }

}
