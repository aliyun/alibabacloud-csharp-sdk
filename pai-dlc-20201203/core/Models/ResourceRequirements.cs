// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ResourceRequirements : TeaModel {
        /// <summary>
        /// 资源限制
        /// </summary>
        [NameInMap("Limits")]
        [Validation(Required=false)]
        public Dictionary<string, string> Limits { get; set; }

        /// <summary>
        /// 资源需求
        /// </summary>
        [NameInMap("Requests")]
        [Validation(Required=false)]
        public Dictionary<string, string> Requests { get; set; }

    }

}
