// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddVodStorageForAppRequest : TeaModel {
        /// <summary>
        /// The ID of the application. You can obtain the application ID from the response to the [CreateAppInfo](https://help.aliyun.com/zh/vod/developer-reference/api-vod-2017-03-21-createappinfo) or [ListAppInfo](https://help.aliyun.com/zh/vod/developer-reference/api-vod-2017-03-21-listappinfo) operation.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The address of an Object Storage Service (OSS) bucket. This parameter does not take effect. You can call this operation to add only VOD buckets.
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        /// <summary>
        /// The storage type. Default value: vod_oss_bucket.
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
