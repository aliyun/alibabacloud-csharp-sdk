// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class AgentCancelCallRequest : TeaModel {
        /// <summary>
        /// 坐席ID
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// 坐席标签
        /// </summary>
        [NameInMap("AgentTag")]
        [Validation(Required=false)]
        public string AgentTag { get; set; }

        /// <summary>
        /// 号码列表
        /// </summary>
        [NameInMap("Numbers")]
        [Validation(Required=false)]
        public List<string> Numbers { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// 用户自定义标签列表
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}
