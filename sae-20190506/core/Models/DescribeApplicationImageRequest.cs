// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationImageRequest : TeaModel {
        /// <summary>
        /// d700e680-aa4d-4ec1-afc2-6566b5ff\\*\\*\\*\\*
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// registry-vpc.cn-hangzhou.aliyuncs.com/demo/demo:latest
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

    }

}
