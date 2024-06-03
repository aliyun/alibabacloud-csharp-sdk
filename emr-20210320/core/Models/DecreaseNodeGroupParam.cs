// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class DecreaseNodeGroupParam : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReleaseInstanceIds")]
        [Validation(Required=false)]
        public List<string> ReleaseInstanceIds { get; set; }

    }

}
