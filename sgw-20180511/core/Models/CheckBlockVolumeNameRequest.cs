// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class CheckBlockVolumeNameRequest : TeaModel {
        /// <summary>
        /// Bucket Endpoint。
        /// </summary>
        [NameInMap("BucketEndpoint")]
        [Validation(Required=false)]
        public string BucketEndpoint { get; set; }

        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("VolumeName")]
        [Validation(Required=false)]
        public string VolumeName { get; set; }

    }

}
