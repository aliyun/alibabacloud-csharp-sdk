// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListLayersResponseBody : TeaModel {
        /// <summary>
        /// 层列表
        /// </summary>
        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<Layer> Layers { get; set; }

        /// <summary>
        /// 剩余列表起始层名
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
