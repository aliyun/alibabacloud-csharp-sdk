// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetClientConfigRequest : TeaModel {
        /// <summary>
        /// 云端配置所对应的IOS BundleId
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// 端侧上传存储Bucket信息
        /// </summary>
        [NameInMap("ClientUploadBucket")]
        [Validation(Required=false)]
        public string ClientUploadBucket { get; set; }

        /// <summary>
        /// 端侧上传存储bucket下路径信息
        /// </summary>
        [NameInMap("ClientUploadPath")]
        [Validation(Required=false)]
        public string ClientUploadPath { get; set; }

        /// <summary>
        /// 端侧上传存储类型，vod_oss_bucket: vod托管bucket，user_oss_bucket: 用户私有bucket
        /// </summary>
        [NameInMap("ClientUploadStorageType")]
        [Validation(Required=false)]
        public string ClientUploadStorageType { get; set; }

        /// <summary>
        /// 云端配置所对应的安卓包名。
        /// </summary>
        [NameInMap("PkgName")]
        [Validation(Required=false)]
        public string PkgName { get; set; }

        /// <summary>
        /// 云端配置所对应的安卓包签名，当包名不为空时，必填。
        /// </summary>
        [NameInMap("PkgSignature")]
        [Validation(Required=false)]
        public string PkgSignature { get; set; }

    }

}
