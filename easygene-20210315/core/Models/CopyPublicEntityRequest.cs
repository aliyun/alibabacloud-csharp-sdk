// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class CopyPublicEntityRequest : TeaModel {
        /// <summary>
        /// 数据集名称
        /// </summary>
        [NameInMap("Dataset")]
        [Validation(Required=false)]
        public string Dataset { get; set; }

        /// <summary>
        /// 表格名称
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// 要拷贝到的工作空间
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
