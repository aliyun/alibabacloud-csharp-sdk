// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Grace20220606.Models
{
    public class UploadFileByOSSRequest : TeaModel {
        [NameInMap("bucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// oss endpoint
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("objectName")]
        [Validation(Required=false)]
        public string ObjectName { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
