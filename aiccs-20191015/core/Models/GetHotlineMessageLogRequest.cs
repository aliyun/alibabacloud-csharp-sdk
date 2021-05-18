// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetHotlineMessageLogRequest : TeaModel {
        /// <summary>
        /// 实例id
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [NameInMap("Acid")]
        [Validation(Required=false)]
        public string Acid { get; set; }

    }

}
