// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class TriggerNetworkRequest : TeaModel {
        /// <summary>
        /// 动作类型。CLOSE：关闭; OPEN：开启
        /// </summary>
        [NameInMap("actionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// 网络类型。PUBLIC：公网；PRIVATE：私网
        /// </summary>
        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// 实例类型。KIBANA kibana公私网/WORKER 集群公私网
        /// </summary>
        [NameInMap("nodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
