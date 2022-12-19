// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateFileDetectUploadUrlRequest : TeaModel {
        /// <summary>
        /// The hash values of files.
        /// 
        /// >  You must specify at least one of the **HashKeyList** and **HashKeyContextList** parameters.
        /// </summary>
        [NameInMap("HashKeyContextList")]
        [Validation(Required=false)]
        public List<CreateFileDetectUploadUrlRequestHashKeyContextList> HashKeyContextList { get; set; }
        public class CreateFileDetectUploadUrlRequestHashKeyContextList : TeaModel {
            /// <summary>
            /// The size of the file. Unit: bytes.
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public int? FileSize { get; set; }

            /// <summary>
            /// The hash value of the file.
            /// </summary>
            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

        }

        /// <summary>
        /// The identifier of the file. Only MD5 hash values are supported.
        /// 
        /// >  You must specify at least one of the **HashKeyList** and **HashKeyContextList** parameters.
        /// </summary>
        [NameInMap("HashKeyList")]
        [Validation(Required=false)]
        public List<string> HashKeyList { get; set; }

        /// <summary>
        /// The type of the file. Valid values:
        /// 
        /// *   **0**: unknown files
        /// *   **1**: binary files
        /// *   **2**: webshell files
        /// *   **4**: script files
        /// 
        /// >  If you do not know the type of the file, set this parameter to **0**.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
