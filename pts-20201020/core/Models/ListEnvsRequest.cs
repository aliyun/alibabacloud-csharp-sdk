// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class ListEnvsRequest : TeaModel {
        /// <summary>
        /// 环境ID
        /// </summary>
        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public string EnvId { get; set; }

        /// <summary>
        /// 环境名
        /// </summary>
        [NameInMap("EnvName")]
        [Validation(Required=false)]
        public string EnvName { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
