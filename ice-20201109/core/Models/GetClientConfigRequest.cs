// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetClientConfigRequest : TeaModel {
        /// <summary>
        /// 云端配置所对应的IOS BundleId
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// 云端配置所对应的包名。
        /// </summary>
        [NameInMap("PkgName")]
        [Validation(Required=false)]
        public string PkgName { get; set; }

        /// <summary>
        /// 云端配置所对应的包签名
        /// </summary>
        [NameInMap("PkgSignature")]
        [Validation(Required=false)]
        public string PkgSignature { get; set; }

    }

}
