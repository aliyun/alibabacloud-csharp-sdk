// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateFileDetectRequest : TeaModel {
        /// <summary>
        /// The identifier of the file. Only MD5 hash values are supported.
        /// </summary>
        [NameInMap("HashKey")]
        [Validation(Required=false)]
        public string HashKey { get; set; }

        /// <summary>
        /// The key of the file that is stored in the Object Storage Service (OSS) bucket. You can call the [CreateFileDetectUploadUrl](~~CreateFileDetectUploadUrl~~) operation to query the keys of files.
        /// </summary>
        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The type of the file. Valid values:
        /// 
        /// *   **0**: unknown files
        /// *   **1**: binary files
        /// *   **2**: webshell files
        /// *   **4**: script files
        /// 
        /// >  If you do not know the type of the file, set this parameter to 0.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
