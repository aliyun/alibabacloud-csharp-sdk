// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetDepGroupTreeDataRequest : TeaModel {
        /// <summary>
        /// 租户实例ID
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 坐席ID
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

    }

}
