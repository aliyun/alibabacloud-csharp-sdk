// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class LayerCode : TeaModel {
        /// <summary>
        /// 层代码位置
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// 层代码类型
        /// </summary>
        [NameInMap("repositoryType")]
        [Validation(Required=false)]
        public string RepositoryType { get; set; }

    }

}
