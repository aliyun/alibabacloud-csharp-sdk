// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class UpdateSpecNodeGroup : TeaModel {
        /// <summary>
        /// 新实例类型。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NewInstanceType")]
        [Validation(Required=false)]
        public string NewInstanceType { get; set; }

        /// <summary>
        /// 节点组ID。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

    }

}
