// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListLayerVersionsResponseBody : TeaModel {
        /// <summary>
        /// 层版本列表
        /// </summary>
        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<Layer> Layers { get; set; }

        /// <summary>
        /// 剩余列表起始版本号
        /// </summary>
        [NameInMap("nextVersion")]
        [Validation(Required=false)]
        public int? NextVersion { get; set; }

    }

}
