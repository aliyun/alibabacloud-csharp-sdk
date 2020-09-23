// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ResumeComponentUpgradeRequest : TeaModel {
        /// <summary>
        /// 集群ID。
        /// </summary>
        [NameInMap("clusterid")]
        [Validation(Required=false)]
        public string Clusterid { get; set; }

        /// <summary>
        /// 组件ID。
        /// </summary>
        [NameInMap("componentid")]
        [Validation(Required=false)]
        public string Componentid { get; set; }

    }

}
