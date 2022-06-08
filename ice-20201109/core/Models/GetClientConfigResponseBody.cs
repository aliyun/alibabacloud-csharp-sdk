// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetClientConfigResponseBody : TeaModel {
        /// <summary>
        /// oss bucket 名称
        /// </summary>
        [NameInMap("ClientUploadBucket")]
        [Validation(Required=false)]
        public string ClientUploadBucket { get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        [NameInMap("ClientUploadPath")]
        [Validation(Required=false)]
        public string ClientUploadPath { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [NameInMap("ClientUploadStorageStatus")]
        [Validation(Required=false)]
        public string ClientUploadStorageStatus { get; set; }

        /// <summary>
        /// 存储类型
        /// </summary>
        [NameInMap("ClientUploadStorageType")]
        [Validation(Required=false)]
        public string ClientUploadStorageType { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
