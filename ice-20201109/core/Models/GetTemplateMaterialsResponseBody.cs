// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetTemplateMaterialsResponseBody : TeaModel {
        /// <summary>
        /// 关联素材地址
        /// </summary>
        [NameInMap("MaterialUrls")]
        [Validation(Required=false)]
        public string MaterialUrls { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
