// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCloudResourcesShrinkRequest : TeaModel {
        [NameInMap("CertIds")]
        [Validation(Required=false)]
        public string CertIdsShrink { get; set; }

        /// <summary>
        /// The cloud service provider.
        /// 
        /// Valid values:
        /// 
        /// *   Tencent: Tencent Cloud
        /// *   aliyun: Alibaba Cloud
        /// </summary>
        [NameInMap("CloudName")]
        [Validation(Required=false)]
        public string CloudName { get; set; }

        /// <summary>
        /// The cloud service. Only Content Delivery Network (CDN) is supported for Tencent Cloud.
        /// </summary>
        [NameInMap("CloudProduct")]
        [Validation(Required=false)]
        public string CloudProduct { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The domain name bound to the cloud resource.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The AccessKey ID used to access cloud resources.
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public string SecretId { get; set; }

        /// <summary>
        /// The number of revoked certificates per page. Default value: **20**.
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

    }

}
