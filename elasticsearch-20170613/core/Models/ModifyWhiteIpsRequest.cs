// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ModifyWhiteIpsRequest : TeaModel {
        /// <summary>
        /// 修改方式，取值含义如下：
        /// 
        /// Cover（默认值）：使用ips参数的值覆盖原IP白名单。
        /// 
        /// Append：在原IP白名单中增加ips参数中输入的IP地址。
        /// 
        /// Delete：Delete：在原IP白名单中删除ips参数中输入的IP地址，至少需要保留一个IP地址。
        /// </summary>
        [NameInMap("modifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        /// <summary>
        /// 网络类型。可选值：PRIVATE（私网）、PUBLIC（公网）。如果选填了whiteIpList参数，则该参数必填。
        /// </summary>
        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// 节点类型。可选值：WORKER（Elasticsearch集群）、KIBANA（Kibana集群）。如果选填了whiteIpList参数，则该参数必填。
        /// </summary>
        [NameInMap("nodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// 以白名单组whiteIpGroup传参方式，更新实例白名单安全配置。仅支持更新一个白名单组。
        /// </summary>
        [NameInMap("whiteIpGroup")]
        [Validation(Required=false)]
        public ModifyWhiteIpsRequestWhiteIpGroup WhiteIpGroup { get; set; }
        public class ModifyWhiteIpsRequestWhiteIpGroup : TeaModel {
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }
            [NameInMap("ips")]
            [Validation(Required=false)]
            public List<string> Ips { get; set; }
        };

        /// <summary>
        /// 白名单列表。whiteIpGroup为空时可用，更改默认分组白名单
        /// </summary>
        [NameInMap("whiteIpList")]
        [Validation(Required=false)]
        public List<string> WhiteIpList { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
