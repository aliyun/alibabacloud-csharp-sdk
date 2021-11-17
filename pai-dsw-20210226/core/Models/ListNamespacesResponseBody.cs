// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class ListNamespacesResponseBody : TeaModel {
        /// <summary>
        /// 命名空间列表
        /// </summary>
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public List<ImageNamespace> Namespaces { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
