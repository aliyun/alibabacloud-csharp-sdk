// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class ListImagesResponseBody : TeaModel {
        /// <summary>
        /// 镜像列表
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<Image> Images { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
