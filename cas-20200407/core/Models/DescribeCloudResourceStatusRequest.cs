// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DescribeCloudResourceStatusRequest : TeaModel {
        /// <summary>
        /// The AccessKey secret used to access cloud resources.
        /// 
        /// >  You can call the [ListCloudAccess](https://help.aliyun.com/document_detail/2712219.html) operation to obtain the ID.
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public string SecretId { get; set; }

    }

}
