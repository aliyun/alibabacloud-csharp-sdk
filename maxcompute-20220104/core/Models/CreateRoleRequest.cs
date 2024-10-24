// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateRoleRequest : TeaModel {
        /// <summary>
        /// The request body parameters. For valid values, see [MaxCompute permissions](https://help.aliyun.com/document_detail/27935.html).
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
