// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class ListNasesResponseBody : TeaModel {
        /// <summary>
        /// nas文件系统列表
        /// </summary>
        [NameInMap("Nases")]
        [Validation(Required=false)]
        public List<Nas> Nases { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
